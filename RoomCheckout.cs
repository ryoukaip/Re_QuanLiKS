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
    public partial class RoomCheckout : Form
    {
        private static SQLiteHandler sQLiteHandler;
        private string roomID;
        public RoomCheckout(string RoomID)
        {
            InitializeComponent();

            roomID = RoomID;
            textBox_RoomID.Text = roomID;

            sQLiteHandler = SQLiteHandler.Instance;
            //open connection
            sQLiteHandler.OpenConnection();

            // get GuestName
            textBox_GuestName.Text = AESHandler.DecryptString(sQLiteHandler.StringExecuteScalar("SELECT GuestName FROM Room WHERE RoomID = '" + roomID + "'"));
            //get CheckinDateTime
            label_CheckinDateTime.Text = sQLiteHandler.StringExecuteScalar("SELECT CheckinDateTime FROM Room WHERE RoomID = '" + roomID + "'");
            //get CheckoutDateTime
            label_CheckoutDateTime.Text = sQLiteHandler.StringExecuteScalar("SELECT CheckoutDateTime FROM Room WHERE RoomID = '" + roomID + "'");
            string checkoutDateTime = label_CheckoutDateTime.Text;
            if (checkoutDateTime.Contains("Unknown"))
            {
                label_CheckoutDateTime.Text = DateTime.Now.ToString();
            }
            label_TotalPriceOfTime.Text = calculatePriceOfTotalTimeToString();
            //get Note
            textBox_Note.Text = sQLiteHandler.StringExecuteScalar("SELECT Note FROM Room WHERE RoomID = '" + roomID + "'");

            // get the list of drinks from table RoomDrinks ('RoomID' 'DrinkID' 'Amount') and Drinks ('DrinkID' 'Name' 'Price)
            // to the list view with 2 columns: 'Drinks' and 'Amount'
            listView_Drinks.Items.Clear();
            #region
            DataTable dataTable = sQLiteHandler.ExecuteQueryTable("SELECT Drinks.Name, RoomDrinks.Amount FROM RoomDrinks INNER JOIN Drinks ON RoomDrinks.DrinkID = Drinks.DrinkID WHERE RoomDrinks.RoomID = '" + roomID + "'");
            foreach (DataRow row in dataTable.Rows)
            {
                string price = sQLiteHandler.DoubleExecuteScalar("SELECT Price FROM Drinks WHERE Name = '" + row[0].ToString() + "'").ToString();

                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString() + " x $" + price);
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
                string price = sQLiteHandler.DoubleExecuteScalar("SELECT Price FROM Foods WHERE Name = '" + row[0].ToString() + "'").ToString();

                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString() + " x $" + price);
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

                string price = sQLiteHandler.DoubleExecuteScalar("SELECT Price FROM Services WHERE Name = '" + row[0].ToString() + "'").ToString();

                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString() + " x $" + price);
                listView_Services.Items.Add(item);
            }
            #endregion


            label_TotalPrice.Text = CalculateTotalPrice();
        }


        private string calculatePriceOfTotalTimeToString()
        {
            // calculate the total time of the guest staying in the room in days and hours
            DateTime checkinDateTime = DateTime.Parse(label_CheckinDateTime.Text);
            DateTime checkoutDateTime = DateTime.Parse(label_CheckoutDateTime.Text);
            TimeSpan timeSpan = checkoutDateTime - checkinDateTime;
            int totalHours = timeSpan.Days * 24 + timeSpan.Hours;

            // messagebox to show the timespan
            //MessageBox.Show(timeSpan.Days.ToString() + " days and " + timeSpan.Hours.ToString() + " hours. " + totalHours.ToString());

            double pricePerHour = sQLiteHandler.DoubleExecuteScalar("SELECT PricePerHour FROM RoomPrices WHERE RoomType = 'Normal'");
            double pricePer12Hours = sQLiteHandler.DoubleExecuteScalar("SELECT PricePer12Hours FROM RoomPrices WHERE RoomType = 'Normal'");
            // calculate the price of the total time using totalHours and the formula: price = number of 12 hours x price per 12 hours + number of hours left x price per hour
            double price = totalHours / 12 * pricePer12Hours + totalHours % 12 * pricePerHour;

            // string result format: 'number of 12 hours' (12hrs) x 'price per 12 hours' + 'number of hours' (hrs) x 'price per hour' = 'price'
            return totalHours / 12 + " (12hrs) x " + pricePer12Hours + " + " + totalHours % 12 + " (hrs) x " + pricePerHour + " = $" + price;
        }

        private double calculatePriceOfTotalTimeToDouble()
        {
            // calculate the total time of the guest staying in the room in days and hours
            DateTime checkinDateTime = DateTime.Parse(label_CheckinDateTime.Text);
            DateTime checkoutDateTime = DateTime.Parse(label_CheckoutDateTime.Text);
            TimeSpan timeSpan = checkoutDateTime - checkinDateTime;
            int totalHours = timeSpan.Days * 24 + timeSpan.Hours;

            // messagebox to show the timespan
            //MessageBox.Show(timeSpan.Days.ToString() + " days and " + timeSpan.Hours.ToString() + " hours. " + totalHours.ToString());

            double pricePerHour = sQLiteHandler.DoubleExecuteScalar("SELECT PricePerHour FROM RoomPrices WHERE RoomType = 'Normal'");
            double pricePer12Hours = sQLiteHandler.DoubleExecuteScalar("SELECT PricePer12Hours FROM RoomPrices WHERE RoomType = 'Normal'");
            // calculate the price of the total time using totalHours and the formula: price = number of 12 hours x price per 12 hours + number of hours left x price per hour
            double price = totalHours / 12 * pricePer12Hours + totalHours % 12 * pricePerHour;

            return price;
        }

        private double CalculatePriceInListView(ListView listView)
        {

            //string input = "2 x $5.49";

            //// Remove any non-numeric characters and split the string
            //string[] parts = input.Replace("$", "").Split('x');

            double price = 0;
            foreach (ListViewItem item in listView.Items)
            {
                string[] priceString = item.SubItems[1].Text.Replace("$", "").Split('x');
                price += double.Parse(priceString[0]) * double.Parse(priceString[1]);
            }
            return price;
        }

        private string CalculateTotalPrice()
        {
            double priceOfTotalTime = calculatePriceOfTotalTimeToDouble();
            double priceOfDrinks = CalculatePriceInListView(listView_Drinks);
            double priceOfFoods = CalculatePriceInListView(listView_Foods);
            double priceOfServices = CalculatePriceInListView(listView_Services);

            double totalPrice = priceOfTotalTime + priceOfDrinks + priceOfFoods + priceOfServices;

            // return format: 'price of total time' + 'price of drinks' + 'price of foods' + 'price of services' = 'total price'
            return "$" + priceOfTotalTime + " + $" + priceOfDrinks + " + $" + priceOfFoods + " + $" + priceOfServices + " = $" + totalPrice;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            // close connection
            sQLiteHandler.CloseConnection();
            this.Close();
        }

        private void WriteToFile()
        {
            WriteToTxt.ClearTextFile();
            WriteToTxt.Line("Checkout");
            WriteToTxt.WriteSeperator();

            // write basic information
            #region
            WriteToTxt.Line("Room ID: " + textBox_RoomID.Text);
            WriteToTxt.Line("Guest Name: " + textBox_GuestName.Text);
            WriteToTxt.Line("Checkin Date & Time: " + label_CheckinDateTime.Text);
            WriteToTxt.Line("Checkout Date & Time: " + label_CheckoutDateTime.Text);
            WriteToTxt.Line("Total Time: " + calculatePriceOfTotalTimeToString());
            #endregion
            WriteToTxt.WriteSeperator();

            // write the listview
            #region
            WriteToTxt.Line("Drinks:");
            foreach (ListViewItem item in listView_Drinks.Items)
            {
                WriteToTxt.WriteTab();
                WriteToTxt.Line(item.SubItems[0].Text + " " + item.SubItems[1].Text);
            }
            WriteToTxt.WriteSeperator();
            WriteToTxt.Line("Foods:");
            foreach (ListViewItem item in listView_Foods.Items)
            {
                WriteToTxt.WriteTab();
                WriteToTxt.Line(item.SubItems[0].Text + " " + item.SubItems[1].Text);
            }
            WriteToTxt.WriteSeperator();
            WriteToTxt.Line("Services:");
            foreach (ListViewItem item in listView_Services.Items)
            {
                WriteToTxt.WriteTab();
                WriteToTxt.Line(item.SubItems[0].Text + " " + item.SubItems[1].Text);
            }
            #endregion

            WriteToTxt.WriteSeperator();
            WriteToTxt.Line("Total Price: " + label_TotalPrice.Text);
            WriteToTxt.WriteSeperator();
            WriteToTxt.Line("Thank you for using our service!");
            WriteToTxt.WriteSeperator();
        }

        private void button_Checkout_Click(object sender, EventArgs e)
        {
            WriteToFile();
            // message box write complete
            //MessageBox.Show("Write complete!");
            PrintReceipt.Print();

            // add the room to 'Maintenance' table 'RoomID' 'Status' = "Cleaning" then remove the room from the 'Room' table
            sQLiteHandler.ExecuteNonQuery("INSERT INTO Maintenance (RoomID, Status) VALUES ('" + textBox_RoomID.Text + "', 'Cleaning')");
            sQLiteHandler.ExecuteNonQuery("DELETE FROM Room WHERE RoomID = '" + textBox_RoomID.Text + "'");
            // message box info checkout complete
            MessageBox.Show("Checkout complete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);



            // close connection
            sQLiteHandler.CloseConnection();
            this.Close();
        }
    }
}
