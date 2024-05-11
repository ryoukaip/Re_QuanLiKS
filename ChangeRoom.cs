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
    public partial class ChangeRoom : Form
    {
        private static SQLiteHandler sQLiteHandler;

        public ChangeRoom()
        {
            InitializeComponent();
            sQLiteHandler = SQLiteHandler.Instance;
            //open connection
            sQLiteHandler.OpenConnection();
            // get a list of room numbers from the database
            List<string> roomNumbers = sQLiteHandler.GetASingleColumnQuery("SELECT RoomID FROM Room");
            comboBox_CurrentRoomList.DataSource = roomNumbers;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            // close connection
            sQLiteHandler.CloseConnection();
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // check if the room exist in table 'Maintenance' 'RoomID' 'Status'
            if (sQLiteHandler.IntExecuteScalar("SELECT COUNT(*) FROM Maintenance WHERE RoomID = " + textBox_DestinationRoom.Text + " AND Status = 'Repairing' OR Status = 'Cleaning'") > 0)
            {
                MessageBox.Show("This room is not available, please choose another room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if the room occupied in table 'Room' 'RoomID'
            if (sQLiteHandler.IntExecuteScalar("SELECT COUNT(*) FROM Room WHERE RoomID = " + textBox_DestinationRoom.Text) > 0)
            {
                MessageBox.Show("This room is occupied, please choose another room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // change RoomID of the selected Room to the new RoomID in 'Room'
            sQLiteHandler.ExecuteNonQuery("UPDATE Room SET RoomID = " + textBox_DestinationRoom.Text + " WHERE RoomID = " + comboBox_CurrentRoomList.Text);

            // message box to notify the user that the room has been changed
            MessageBox.Show("Room changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // close connection
            sQLiteHandler.CloseConnection();
            this.Close();
            
        }

        private void textBox_DestinationRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters like backspace and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
