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
    public partial class MaintenanceRequest : Form
    {
        private static SQLiteHandler sQLiteHandler;
        public MaintenanceRequest()
        {
            InitializeComponent();
            comboBox_Reason.SelectedIndex = 0;
            sQLiteHandler = SQLiteHandler.Instance;
            //open connection
            sQLiteHandler.OpenConnection();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            // close connection
            sQLiteHandler.CloseConnection();
            this.Close();
        }

        private void button_Request_Click(object sender, EventArgs e)
        {
            if (checkIfTextBoxIsEmpty())
            {
                return;
            }

            // check if the room is available
            string query = "SELECT COUNT(*) FROM Maintenance WHERE RoomID = '" + textBox_RoomID.Text + "' AND Status = 'Available' OR Status = 'Occupied'";
            if (sQLiteHandler.IntExecuteScalar(query) > 0)
            {
                // update the status of the room to combobox_Reason.Text
                sQLiteHandler.ExecuteNonQuery("UPDATE Maintenance SET Status = '" + comboBox_Reason.Text + "' WHERE RoomID = '" + textBox_RoomID.Text + "'");
                // update 'MaintenanceStatus' of 'Room' table to combobox_Reason.Text
                sQLiteHandler.ExecuteNonQuery("UPDATE Room SET MaintenanceStatus = '" + comboBox_Reason.Text + "' WHERE RoomID = '" + textBox_RoomID.Text + "'");
                // request successfully
                MessageBox.Show("Request successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // close connection
                sQLiteHandler.CloseConnection();
                this.Close();
                return;
            }
            else
            {
                //table Maintenance with 'RoomID' and 'Status' as 'Repairing', 'Cleaning'
                sQLiteHandler.ExecuteNonQuery("INSERT INTO Maintenance(RoomID, Status) VALUES('" + textBox_RoomID.Text + "', '" + comboBox_Reason.Text + "')");
                // request successfully
                MessageBox.Show("Request successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // close connection
                sQLiteHandler.CloseConnection();
                this.Close();
            }
        }

        private void button_make_available_Click(object sender, EventArgs e)
        {
            // update if exist in table Maintenance status = 'Available'
            // select the room if currently in maintenance
            string query = "SELECT COUNT(*) FROM Maintenance WHERE RoomID = '" + textBox_RoomID.Text + "' AND Status = 'Repairing' OR Status = 'Cleaning'";
            if (sQLiteHandler.IntExecuteScalar(query) > 0)
            {
                // update the status of the room to available
                sQLiteHandler.ExecuteNonQuery("UPDATE Maintenance SET Status = 'Available' WHERE RoomID = '" + textBox_RoomID.Text + "'");
                // request successfully
                MessageBox.Show("Room is now available!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // close connection
                sQLiteHandler.CloseConnection();
                this.Close();
            }
            else
            {
                // request unsuccessfully
                MessageBox.Show("Room is not in maintenance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool checkIfTextBoxIsEmpty()
        {
            if (textBox_RoomID.Text == "")
            {
                MessageBox.Show("Please enter RoomID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
