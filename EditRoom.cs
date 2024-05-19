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
    public partial class EditRoom : Form
    {
        private static SQLiteHandler sQLiteHandler;
        private string roomID;

        public EditRoom(string RoomID)
        {
            InitializeComponent();
            roomID = RoomID;
            textBox_RoomID.Text = roomID;
            sQLiteHandler = SQLiteHandler.Instance;
            //open connection
            sQLiteHandler.OpenConnection();

            //Get the guest name
            textBox_GuestName.Text = AESHandler.DecryptString(sQLiteHandler.StringExecuteScalar("SELECT GuestName FROM Room WHERE RoomID = '" + roomID + "'"));

            //Get checkin and checkout date time
            #region
            label_CheckinDateTime.Text = sQLiteHandler.StringExecuteScalar("SELECT CheckinDateTime FROM Room WHERE RoomID = '" + roomID + "'");
            string checkoutDateTime = sQLiteHandler.StringExecuteScalar("SELECT CheckoutDateTime FROM Room WHERE RoomID = '" + roomID + "'");
            // check if string contains the word 'Unknown'
            if (checkoutDateTime.Contains("Unknown"))
            {
                checkBox_CheckoutUnknownDate.Checked = true;
            }
            else
            {
                checkBox_CheckoutUnknownDate.Checked = false;
                dateTimePicker_CheckoutDate.Value = DateTime.Parse(checkoutDateTime);
                dateTimePicker_CheckoutTime.Value = DateTime.Parse(checkoutDateTime);
            }
            #endregion

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

            // get the note
            textBox_Note.Text = sQLiteHandler.StringExecuteScalar("SELECT Note FROM Room WHERE RoomID = '" + roomID + "'");

            // get the list of drinks from table RoomDrinks ('RoomID' 'DrinkID' 'Amount') and Drinks ('DrinkID' 'Name' 'Price)
            // to the list view with 2 columns: 'Drinks' and 'Amount'
            listView_Drinks.Items.Clear();
            #region
            DataTable dataTable = sQLiteHandler.ExecuteQueryTable("SELECT Drinks.Name, RoomDrinks.Amount FROM RoomDrinks INNER JOIN Drinks ON RoomDrinks.DrinkID = Drinks.DrinkID WHERE RoomDrinks.RoomID = '" + roomID + "'");
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                listView_Drinks.Items.Add(item);
            }
            #endregion

            // get the list of foods from table RoomFoods ('RoomID' 'FoodID' 'Amount') and Foods ('FoodID' 'Name' 'Price)
            // to the list view with 2 columns: 'Foods' and 'Amount'
            listView_Foods.Items.Clear();
            #region
            dataTable = sQLiteHandler.ExecuteQueryTable("SELECT Foods.Name, RoomFoods.Amount FROM RoomFoods INNER JOIN Foods ON RoomFoods.FoodID = Foods.FoodID WHERE RoomFoods.RoomID = '" + roomID + "'");
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                listView_Foods.Items.Add(item);
            }
            #endregion

            // get the list of services from table RoomServices ('RoomID' 'ServiceID' 'Amount') and Services ('ServiceID' 'Name' 'Price)
            // to the list view with 2 columns: 'Services' and 'Amount'
            listView_Services.Items.Clear();
            #region
            dataTable = sQLiteHandler.ExecuteQueryTable("SELECT Services.Name, RoomServices.Amount FROM RoomServices INNER JOIN Services ON RoomServices.ServiceID = Services.ServiceID WHERE RoomServices.RoomID = '" + roomID + "'");
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                listView_Services.Items.Add(item);
            }
            #endregion
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

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            // close connection to the database
            sQLiteHandler.CloseConnection();
            this.Close();
        }

        // update the database
        private void updateGuestName()
        {
            string guestName = AESHandler.EncryptString(textBox_GuestName.Text, true);
            string roomID = textBox_RoomID.Text;
            string query = "UPDATE Room SET GuestName = '" + guestName + "' WHERE RoomID = '" + roomID + "'";
            sQLiteHandler.ExecuteNonQuery(query);
        }

        private void updateCheckoutDateTime()
        {
            // check if the checkbox unknown is checked
            if (checkBox_CheckoutUnknownDate.Checked)
            {
                string roomID = textBox_RoomID.Text;
                string query = "UPDATE Room SET CheckoutDateTime = 'Unknown' WHERE RoomID = '" + roomID + "'";
                sQLiteHandler.ExecuteNonQuery(query);
            }
            else
            {
                string roomID = textBox_RoomID.Text;
                string checkoutDate = dateTimePicker_CheckoutDate.Value.ToString("yyyy-MM-dd");
                string checkoutTime = dateTimePicker_CheckoutTime.Value.ToString("HH:mm");
                string checkoutDateTime = checkoutDate + " " + checkoutTime;
                string query = "UPDATE Room SET CheckoutDateTime = '" + checkoutDateTime + "' WHERE RoomID = '" + roomID + "'";
                sQLiteHandler.ExecuteNonQuery(query);
            }
        }

        private void updateNote()
        {
            string roomID = textBox_RoomID.Text;
            string note = textBox_Note.Text;
            string query = "UPDATE Room SET Note = '" + note + "' WHERE RoomID = '" + roomID + "'";
            sQLiteHandler.ExecuteNonQuery(query);
        }

        private void updateDrinks()
        {
            // remove all the drinks of the room in the table "RoomDrinks" 'DrinkID' 'RoomID' 'Amount'
            string roomID = textBox_RoomID.Text;
            string query = "DELETE FROM RoomDrinks WHERE RoomID = '" + roomID + "'";
            sQLiteHandler.ExecuteNonQuery(query);

            // add all the drinks of the room to the table "RoomDrinks" 'DrinkID' 'RoomID' 'Amount'
            foreach (ListViewItem item in listView_Drinks.Items)
            {
                string drinkName = item.Text;
                string amount = item.SubItems[1].Text;
                string drinkID = sQLiteHandler.IntExecuteScalar("SELECT DrinkID FROM Drinks WHERE Name = '" + drinkName + "'").ToString();
                query = "INSERT INTO RoomDrinks (DrinkID, RoomID, Amount) VALUES ('" + drinkID + "', '" + roomID + "', '" + amount + "')";
                sQLiteHandler.ExecuteNonQuery(query);
            }
        }

        private void updateFoods()
        {
            // remove all the foods of the room in the table "RoomFoods" 'FoodID' 'RoomID' 'Amount'
            string roomID = textBox_RoomID.Text;
            string query = "DELETE FROM RoomFoods WHERE RoomID = '" + roomID + "'";
            sQLiteHandler.ExecuteNonQuery(query);

            // add all the foods of the room to the table "RoomFoods" 'FoodID' 'RoomID' 'Amount'
            foreach (ListViewItem item in listView_Foods.Items)
            {
                string foodName = item.Text;
                string amount = item.SubItems[1].Text;
                string foodID = sQLiteHandler.IntExecuteScalar("SELECT FoodID FROM Foods WHERE Name = '" + foodName + "'").ToString();
                query = "INSERT INTO RoomFoods (FoodID, RoomID, Amount) VALUES ('" + foodID + "', '" + roomID + "', '" + amount + "')";
                sQLiteHandler.ExecuteNonQuery(query);
            }
        }

        private void updateServices()
        {
            // remove all the services of the room in the table "RoomServices" 'ServiceID' 'RoomID' 'Amount'
            string roomID = textBox_RoomID.Text;
            string query = "DELETE FROM RoomServices WHERE RoomID = '" + roomID + "'";
            sQLiteHandler.ExecuteNonQuery(query);

            // add all the services of the room to the table "RoomServices" 'ServiceID' 'RoomID' 'Amount'
            foreach (ListViewItem item in listView_Services.Items)
            {
                string serviceName = item.Text;
                string amount = item.SubItems[1].Text;
                string serviceID = sQLiteHandler.IntExecuteScalar("SELECT ServiceID FROM Services WHERE Name = '" + serviceName + "'").ToString();
                query = "INSERT INTO RoomServices (ServiceID, RoomID, Amount) VALUES ('" + serviceID + "', '" + roomID + "', '" + amount + "')";
                sQLiteHandler.ExecuteNonQuery(query);
            }
        }

        private void updateRoomDrinksFoodsSevicesStringsToTheMainRoomTable()
        {
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

            string query = "UPDATE Room SET Drinks = '" + allDrinksAndAmount + "', Foods = '" + allFoodsAndAmount + "', Services = '" + allServicesAndAmount + "' WHERE RoomID = '" + textBox_RoomID.Text + "'";
            sQLiteHandler.ExecuteNonQuery(query);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            updateCheckoutDateTime();
            updateGuestName();
            updateNote();
            updateDrinks();
            updateFoods();
            updateServices();
            updateRoomDrinksFoodsSevicesStringsToTheMainRoomTable();
            // message box
            MessageBox.Show("Update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // close connection
            sQLiteHandler.CloseConnection();
            // close this form
            this.Close();
        }
    }
}
