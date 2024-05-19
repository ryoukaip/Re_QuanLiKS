using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Re_QuanLiKS
{
    public partial class AddNewRoom : Form
    {
        public static SQLiteHandler sQLiteHandler;
        public AddNewRoom()
        {
            InitializeComponent();
            sQLiteHandler = SQLiteHandler.Instance;
            sQLiteHandler.OpenConnection();


            // Add all the name of drinks from 'Drinks' table of the database to the comboBox_Drinks
            #region
            comboBox_Drinks.Items.Clear();
            comboBox_Drinks.Items.AddRange(sQLiteHandler.GetASingleColumnQuery("SELECT Name FROM Drinks").ToArray());
            comboBox_Drinks.SelectedIndex = 0;
            #endregion
            // Add all the name of foods from 'Foods' table of the database to the comboBox_Foods
            #region
            comboBox_Foods.Items.Clear();
            comboBox_Foods.Items.AddRange(sQLiteHandler.GetASingleColumnQuery("SELECT Name FROM Foods").ToArray());
            comboBox_Foods.SelectedIndex = 0;
            #endregion
            // Add all the name of services from 'Services' table of the database to the comboBox_Services
            #region
            comboBox_Services.Items.Clear();
            comboBox_Services.Items.AddRange(sQLiteHandler.GetASingleColumnQuery("SELECT Name FROM Services").ToArray());
            comboBox_Services.SelectedIndex = 0;
            #endregion


        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            // get all the information from the form to variables
            #region
            string RoomID = textBox_RoomID.Text;
            //string GuestName = textBox_GuestName.Text;
            string GuestName = Convert.ToBase64String(AESHandler.EncryptString(textBox_GuestName.Text).encrypted);
            string CheckinDate = dateTimePicker_CheckinDate.Value.ToString("yyyy-MM-dd");
            string CheckoutDate = dateTimePicker_CheckoutDate.Value.ToString("yyyy-MM-dd");
            string CheckinTime = dateTimePicker_CheckinTime.Value.ToString("HH:mm");
            string CheckoutTime = dateTimePicker_CheckoutTime.Value.ToString("HH:mm");
            bool isCheckoutUnknown = checkBox_CheckoutUnknownDate.Checked;
            List<string> Drinks = new List<string>();
            List<string> Foods = new List<string>();
            List<string> Services = new List<string>();
            foreach (ListViewItem item in listView_Drinks.Items)
            {
                Drinks.Add(item.Text);
            }
            foreach (ListViewItem item in listView_Foods.Items)
            {
                Foods.Add(item.Text);
            }
            foreach (ListViewItem item in listView_Services.Items)
            {
                Services.Add(item.Text);
            }
            List<string> DrinksQuantity = new List<string>();
            List<string> FoodsQuantity = new List<string>();
            List<string> ServicesQuantity = new List<string>();
            foreach (ListViewItem item in listView_Drinks.Items)
            {
                DrinksQuantity.Add(item.SubItems[1].Text);
            }
            foreach (ListViewItem item in listView_Foods.Items)
            {
                FoodsQuantity.Add(item.SubItems[1].Text);
            }
            foreach (ListViewItem item in listView_Services.Items)
            {
                ServicesQuantity.Add(item.SubItems[1].Text);
            }
            #endregion

            // testing region
            #region
            // create a string that contains all the information of the new room
            //string data = RoomID + "|" + GuestName + "|" + CheckinDate + "|" + CheckoutDate + "|" + CheckinTime + "|" + CheckoutTime + "|" + isCheckoutUnknown.ToString() + "|";
            //for (int i = 0; i < Drinks.Count; i++)
            //{
            //    data += Drinks[i] + "|" + DrinksQuantity[i] + "|";
            //}
            //for (int i = 0; i < Foods.Count; i++)
            //{
            //    data += Foods[i] + "|" + FoodsQuantity[i] + "|";
            //}
            //for (int i = 0; i < Services.Count; i++)
            //{
            //    data += Services[i] + "|" + ServicesQuantity[i] + "|";
            //}
            //data += textBox_Note.Text;
            //// create a message box for testing
            //MessageBox.Show(data);
            #endregion

            // check if checkout date and time is valid and the time must exceed 1 hour
            #region
            if (isCheckoutUnknown)
            {
                CheckoutDate = "Unknown";
                CheckoutTime = "Unknown";
            }
            else
            {
                DateTime checkinDateTime = DateTime.Parse(CheckinDate + " " + CheckinTime);
                DateTime checkoutDateTime = DateTime.Parse(CheckoutDate + " " + CheckoutTime);
                if (checkoutDateTime <= checkinDateTime)
                {
                    MessageBox.Show("Ngày trả phòng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (checkoutDateTime <= checkinDateTime.AddHours(1))
                {
                    MessageBox.Show("Thời gian trả phòng phải sau ít nhất 1 tiếng so với thời gian nhận phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            #endregion

            // check if the room is already in the database using ExecuteScalar
            #region
            string query = "SELECT COUNT(*) FROM Room WHERE RoomID = '" + RoomID + "'";
            // ExecuteScalar return a <T> so you have to convert it to int
            int count = sQLiteHandler.IntExecuteScalar(query);
            if (count > 0)
            {
                MessageBox.Show("Phòng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            // check if RoomID and GuestName is empty
            #region
            if (RoomID == "" || GuestName == "")
            {
                MessageBox.Show("Phòng và tên khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            // check if the room is in the maintenance
            // table Maintenance with 'RoomID' and 'Status' as 'Repairing', 'Cleaning'
            #region
            query = "SELECT COUNT(*) FROM Maintenance WHERE RoomID = '" + RoomID + "' AND (Status = 'Repairing' OR Status = 'Cleaning')";
            count = sQLiteHandler.IntExecuteScalar(query);
            MessageBox.Show(count.ToString());
            if (count > 0)
            {
                MessageBox.Show("Phòng đang trong quá trình bảo trì!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion



            // table info 
            //--Table: Room
            //CREATE TABLE Room(RoomID INTEGER PRIMARY KEY, GuestName TEXT NOT NULL, CheckinDateTime TEXT NOT NULL, CheckoutDateTime TEXT NOT NULL, MaintenanceStatus TEXT NOT NULL, Drinks TEXT NOT NULL DEFAULT "Nothing", Foods TEXT NOT NULL DEFAULT "Nothing", Services TEXT NOT NULL DEFAULT "Nothing");
            //--Table: RoomDrinks
            //CREATE TABLE RoomDrinks(RoomID INTEGER NOT NULL, DrinkID INTEGER NOT NULL, Amount INTEGER NOT NULL DEFAULT (1), FOREIGN KEY(RoomID) REFERENCES Room(RoomID), FOREIGN KEY(DrinkID) REFERENCES Drinks(DrinkID), PRIMARY KEY(RoomID, DrinkID));
            //--Table: RoomFoods
            //CREATE TABLE RoomFoods(
            //    RoomID INTEGER NOT NULL,
            //    FoodID INTEGER NOT NULL,
            //    FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
            //    FOREIGN KEY (FoodID) REFERENCES Foods(FoodID),
            //    PRIMARY KEY (RoomID, FoodID)
            //);

            // insert the new room to the database
            // no more region
            string allDrinksAndAmount = "";
            string allFoodsAndAmount = "";
            string allServicesAndAmount = "";
            for (int i = 0; i < Drinks.Count; i++)
            {
                allDrinksAndAmount += Drinks[i] + " | " + DrinksQuantity[i] + ";";
            }
            for (int i = 0; i < Foods.Count; i++)
            {
                allFoodsAndAmount += Foods[i] + " | " + FoodsQuantity[i] + ";";
            }
            for (int i = 0; i < Services.Count; i++)
            {
                allServicesAndAmount += Services[i] + " | " + ServicesQuantity[i] + ";";
            }

            // check if Note is empty or all spaces, if do, set it to "Empty"
            if (textBox_Note.Text.Trim() == "")
            {
                textBox_Note.Text = "Empty";
            }
            

            sQLiteHandler.ExecuteNonQuery("INSERT INTO Room(RoomID, GuestName, CheckinDateTime, CheckoutDateTime, MaintenanceStatus, Drinks, Foods, Services, Note) VALUES('" + RoomID + "', '" + GuestName + "', '" + CheckinDate + " " + CheckinTime + "', '" + CheckoutDate + " " + CheckoutTime + "', 'Occupied', '" + allDrinksAndAmount + "', '" + allFoodsAndAmount + "', '" + allServicesAndAmount + "', '" + textBox_Note.Text + "')");
            

            // insert the drinks of the new room to the database
            // create a list to get DrinkID from Drinks
            List<int> drinkIDs = new List<int>();
            for (int i = 0; i < Drinks.Count; i++)
            {
                drinkIDs.Add(sQLiteHandler.IntExecuteScalar("SELECT DrinkID FROM Drinks WHERE Name = '" + Drinks[i] + "'"));
            }
            for (int i = 0; i < Drinks.Count; i++)
            {
                sQLiteHandler.ExecuteNonQuery("INSERT INTO RoomDrinks(RoomID, DrinkID, Amount) VALUES('" + RoomID + "', '" + drinkIDs[i] + "', '" + DrinksQuantity[i] + "')");
            }
            
            // insert the foods of the new room to the database
            // create a list to get FoodID from Foods
            List<int> foodIDs = new List<int>();
            for (int i = 0; i < Foods.Count; i++)
            {
                foodIDs.Add(sQLiteHandler.IntExecuteScalar("SELECT FoodID FROM Foods WHERE Name = '" + Foods[i] + "'"));
            }
            for (int i = 0; i < Foods.Count; i++)
            {
                sQLiteHandler.ExecuteNonQuery("INSERT INTO RoomFoods(RoomID, FoodID, Amount) VALUES('" + RoomID + "', '" + foodIDs[i] + "', '" + FoodsQuantity[i] + "')");
            }
            
            // insert the services of the new room to the database
            // create a list to get ServiceID from Services
            List<int> serviceIDs = new List<int>();
            for (int i = 0; i < Services.Count; i++)
            {
                serviceIDs.Add(sQLiteHandler.IntExecuteScalar("SELECT ServiceID FROM Services WHERE Name = '" + Services[i] + "'"));
            }
            for (int i = 0; i < Services.Count; i++)
            {
                sQLiteHandler.ExecuteNonQuery("INSERT INTO RoomServices(RoomID, ServiceID, Amount) VALUES('" + RoomID + "', '" + serviceIDs[i] + "', '" + ServicesQuantity[i] + "')");
            }
            
            // show a message box to notify the user that the new room has been added to the database
            MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // close the form
            this.Close();
        }

        private void button_PlusDrinks_Click(object sender, EventArgs e)
        {
            // if the drink is already in the listView_Drinks, then increase the quantity of that drink by 1
            // else add a new row to the listView_Drinks
            #region
            string drinkName = comboBox_Drinks.SelectedItem.ToString();
            bool isAlreadyInListView = false;
            foreach (ListViewItem item in listView_Drinks.Items)
            {
                if (item.Text == drinkName)
                {
                    item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                    isAlreadyInListView = true;
                    break;
                }
            }
            if (!isAlreadyInListView)
            {
                ListViewItem item = new ListViewItem(drinkName);
                item.SubItems.Add("1");
                listView_Drinks.Items.Add(item);
            }
            #endregion
        }

        private void button_MinusDrinks_Click(object sender, EventArgs e)
        {
            // if the drink is already in the listView_Drinks, then decrease the quantity of that drink by 1
            // else do nothing
            #region
            string drinkName = comboBox_Drinks.SelectedItem.ToString();
            foreach (ListViewItem item in listView_Drinks.Items)
            {
                if (item.Text == drinkName)
                {
                    if (int.Parse(item.SubItems[1].Text) > 1)
                    {
                        item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) - 1).ToString();
                    }
                    break;
                }
            }
            #endregion
        }

        private void button_PlusFoods_Click(object sender, EventArgs e)
        {
            // if the food is already in the listView_Foods, then increase the quantity of that food by 1
            // else add a new row to the listView_Foods
            #region
            string foodName = comboBox_Foods.SelectedItem.ToString();
            bool isAlreadyInListView = false;
            foreach (ListViewItem item in listView_Foods.Items)
            {
                if (item.Text == foodName)
                {
                    item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                    isAlreadyInListView = true;
                    break;
                }
            }
            if (!isAlreadyInListView)
            {
                ListViewItem item = new ListViewItem(foodName);
                item.SubItems.Add("1");
                listView_Foods.Items.Add(item);
            }
            #endregion
        }

        private void button_MinusFoods_Click(object sender, EventArgs e)
        {
            // if the food is already in the listView_Foods, then decrease the quantity of that food by 1
            // else do nothing
            #region
            string foodName = comboBox_Foods.SelectedItem.ToString();
            foreach (ListViewItem item in listView_Foods.Items)
            {
                if (item.Text == foodName)
                {
                    if (int.Parse(item.SubItems[1].Text) > 1)
                    {
                        item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) - 1).ToString();
                    }
                    break;
                }
            }
            #endregion
        }

        // Use for preventing the user from resizing the columns of the listView, on 'Drinks' 'Foods' 'Services' tab
        private void listView_Drinks_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView_Drinks.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void button_PlusServices_Click(object sender, EventArgs e)
        {
            // if the service is already in the listView_Services, then increase the quantity of that service by 1
            // else add a new row to the listView_Services
            #region
            string serviceName = comboBox_Services.SelectedItem.ToString();
            bool isAlreadyInListView = false;
            foreach (ListViewItem item in listView_Services.Items)
            {
                if (item.Text == serviceName)
                {
                    item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) + 1).ToString();
                    isAlreadyInListView = true;
                    break;
                }
            }
            if (!isAlreadyInListView)
            {
                ListViewItem item = new ListViewItem(serviceName);
                item.SubItems.Add("1");
                listView_Services.Items.Add(item);
            }
            #endregion
        }

        private void button_MinusServices_Click(object sender, EventArgs e)
        {
            // if the service is already in the listView_Services, then decrease the quantity of that service by 1
            // else do nothing
            #region
            string serviceName = comboBox_Services.SelectedItem.ToString();
            foreach (ListViewItem item in listView_Services.Items)
            {
                if (item.Text == serviceName)
                {
                    if (int.Parse(item.SubItems[1].Text) > 1)
                    {
                        item.SubItems[1].Text = (int.Parse(item.SubItems[1].Text) - 1).ToString();
                    }
                    break;
                }
            }
            #endregion
        }
    }
}
