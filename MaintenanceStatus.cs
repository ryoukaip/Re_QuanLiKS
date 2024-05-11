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
    public partial class MaintenanceStatus : Form
    {
        private static SQLiteHandler sQLiteHandler;
        private bool isExistInRoomTable = false;
        public MaintenanceStatus()
        {
            InitializeComponent();

            sQLiteHandler = SQLiteHandler.Instance;
            //open connection
            sQLiteHandler.OpenConnection();
            // get table 'Maintanence' from database with columns 'RoomID', 'Status' to datagridview1
            DataTable dataTable = sQLiteHandler.ExecuteQueryTable("SELECT RoomID, Status FROM Maintenance");
            dataGridView1.DataSource = dataTable;
            // set the size of each column to 70
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 72;
            }

            checkRoomIDExistInRoomTable();
        }

        private void refreshData()
        {
              if (sQLiteHandler != null)
            {
                //open connection
                sQLiteHandler.OpenConnection();
                // get table 'Maintanence' from database with columns 'RoomID', 'Status' to datagridview1
                DataTable dataTable = sQLiteHandler.ExecuteQueryTable("SELECT RoomID, Status FROM Maintenance");
                dataGridView1.DataSource = dataTable;
                // set the size of each column to 70
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].Width = 72;
                }
                // close connection
                sQLiteHandler.CloseConnection();
            }
        }      

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            // close connection
            sQLiteHandler.CloseConnection();
            this.Close();

        }

        private void button_SetAvailable_Click(object sender, EventArgs e)
        {
            checkRoomIDExistInRoomTable();
            // check if room does not exist in 'Room' table then set status to 'Available'
            if (isExistInRoomTable == false)
            {
                DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;

                if (dataGridViewCell != null)
                {
                    int rowIndex = dataGridViewCell.RowIndex;
                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                    string roomID = dataGridViewRow.Cells[0].Value.ToString();
                    // set status to 'Available' in table 'Maintenance' using StringExecuteNonQuery
                    sQLiteHandler.ExecuteNonQuery("UPDATE Maintenance SET Status = 'Available' WHERE RoomID = '" + roomID + "'");
                    refreshData();
                }
            }
            else
            {
                MessageBox.Show("Room is not available to set to 'Available' status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // open connection
            sQLiteHandler.OpenConnection();
        }

        private void button_SetCleaning_Click(object sender, EventArgs e)
        {
            checkRoomIDExistInRoomTable();
            // check if the room exist in the 'Room' table then set 'Status' of table 'Maintenance' and 'MaintenanceStatus' of table 'Room' to 'Cleaning'
            // if not exist then only set 'Status' of table 'Maintenance' to 'Cleaning'
            if (isExistInRoomTable == true)
            {
                DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;

                if (dataGridViewCell != null)
                {
                    int rowIndex = dataGridViewCell.RowIndex;
                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                    string roomID = dataGridViewRow.Cells[0].Value.ToString();
                    // set status to 'Cleaning' in table 'Maintenance' using StringExecuteNonQuery
                    sQLiteHandler.ExecuteNonQuery("UPDATE Maintenance SET Status = 'Cleaning' WHERE RoomID = '" + roomID + "'");
                    // set 'MaintenanceStatus' to 'Cleaning' in table 'Room' using StringExecuteNonQuery
                    sQLiteHandler.ExecuteNonQuery("UPDATE Room SET MaintenanceStatus = 'Cleaning' WHERE RoomID = '" + roomID + "'");
                    refreshData();
                }
            }
            else
            {
                DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;

                if (dataGridViewCell != null)
                {
                    int rowIndex = dataGridViewCell.RowIndex;
                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                    string roomID = dataGridViewRow.Cells[0].Value.ToString();
                    // set status to 'Cleaning' in table 'Maintenance' using StringExecuteNonQuery
                    sQLiteHandler.ExecuteNonQuery("UPDATE Maintenance SET Status = 'Cleaning' WHERE RoomID = '" + roomID + "'");
                    refreshData();
                }
            }
            // open connection
            sQLiteHandler.OpenConnection();
        }

        private void button_SetOccupied_Click(object sender, EventArgs e)
        {
            checkRoomIDExistInRoomTable();
            // check if the room exist in the 'Room' table then set 'Status' of table 'Maintenance' and 'MaintenanceStatus' of table 'Room' to 'Occupied'
            // if not show error message that room is not available to set to 'Occupied' status
            if (isExistInRoomTable == true)
            {
                DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;

                if (dataGridViewCell != null)
                {
                    int rowIndex = dataGridViewCell.RowIndex;
                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                    string roomID = dataGridViewRow.Cells[0].Value.ToString();
                    // set status to 'Occupied' in table 'Maintenance' using StringExecuteNonQuery
                    sQLiteHandler.ExecuteNonQuery("UPDATE Maintenance SET Status = 'Occupied' WHERE RoomID = '" + roomID + "'");
                    // set 'MaintenanceStatus' to 'Occupied' in table 'Room' using StringExecuteNonQuery
                    sQLiteHandler.ExecuteNonQuery("UPDATE Room SET MaintenanceStatus = 'Occupied' WHERE RoomID = '" + roomID + "'");
                    refreshData();
                }
            }
            else
            {
                MessageBox.Show("Room is not available to set to 'Occupied' status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // open connection
            sQLiteHandler.OpenConnection();
        }

        private void button_SetRepairing_Click(object sender, EventArgs e)
        {
            checkRoomIDExistInRoomTable();
            // check if the room does not exist in the 'Room' table then set 'Status' of table 'Maintenance' to 'Repairing'
            // if not show error message that room is not available to set to 'Repairing' status
            if (isExistInRoomTable == false)
            {
                DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;

                if (dataGridViewCell != null)
                {
                    int rowIndex = dataGridViewCell.RowIndex;
                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                    string roomID = dataGridViewRow.Cells[0].Value.ToString();
                    // set status to 'Repairing' in table 'Maintenance' using StringExecuteNonQuery
                    sQLiteHandler.ExecuteNonQuery("UPDATE Maintenance SET Status = 'Repairing' WHERE RoomID = '" + roomID + "'");
                    refreshData();
                }
            }
            else
            {
                MessageBox.Show("Room is not available to set to 'Repairing' status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // open connection
            sQLiteHandler.OpenConnection();
        }

        private void checkRoomIDExistInRoomTable()
        {

            DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;

            if (dataGridViewCell != null)
            {
                int rowIndex = dataGridViewCell.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                string roomID = dataGridViewRow.Cells[0].Value.ToString();
                // check if 'RoomID' exist in table 'Room' using StringExecuteScalar
                if (sQLiteHandler.IntExecuteScalar("Select count(*) from 'Room' where RoomID = '" + roomID + "'") > 0)
                {
                    isExistInRoomTable = true;
                }
                else
                {
                    isExistInRoomTable = false;
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //checkRoomIDExistInRoomTable();
        }

        private void MaintenanceStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close connection
            sQLiteHandler.CloseConnection();
        }
    }
}
