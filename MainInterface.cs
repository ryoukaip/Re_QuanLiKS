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
    public partial class MainInterface : Form
    {
        private static SQLiteHandler sQLiteHandler;
        public MainInterface()
        {
            InitializeComponent();
            sQLiteHandler = SQLiteHandler.Instance;
            //open connection
            sQLiteHandler.OpenConnection();
            // create a data table using ExecuteQueryTable to store the data from the database, then assign it to the data grid view
            DataTable dataTable = sQLiteHandler.ExecuteQueryTable("SELECT * FROM Room");
            dataGridView1.DataSource = dataTable;
            // set the size of each column to 100
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 100;
            }

            // decrypt the value of second columnof the data grid view
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) //
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 1)
                    {
                        string encryptedValue = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        //MessageBox.Show(encryptedValue);
                        string decryptedValue = AESHandler.DecryptString(Convert.FromBase64String(encryptedValue));
                        dataGridView1.Rows[i].Cells[j].Value = decryptedValue.ToString();
                    }
                }
            }


            // close connection
            sQLiteHandler.CloseConnection();
        }

        private void refreshData()
        {
            if (sQLiteHandler != null)
            {
                //open connection
                sQLiteHandler.OpenConnection();
                // create a data table using ExecuteQueryTable to store the data from the database, then assign it to the data grid view
                DataTable dataTable = sQLiteHandler.ExecuteQueryTable("SELECT * FROM Room");
                dataGridView1.DataSource = dataTable;
                // set the size of each column to 100
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].Width = 100;
                }

                // decrypt the value of second columnof the data grid view
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) //
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 1)
                        {
                            string encryptedValue = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            //MessageBox.Show(encryptedValue);
                            string decryptedValue = AESHandler.DecryptString(Convert.FromBase64String(encryptedValue));
                            dataGridView1.Rows[i].Cells[j].Value = decryptedValue.ToString();
                        }
                    }
                }

                // close connection
                sQLiteHandler.CloseConnection();
            }
        }

        private void button_AddNewRoom_Click(object sender, EventArgs e)
        {
            AddNewRoom addNewRoom = new AddNewRoom();
            addNewRoom.ShowDialog();
            refreshData();
        }

        private void button_MainenanceRequest_Click(object sender, EventArgs e)
        {
            MaintenanceRequest maintenanceRequest = new MaintenanceRequest();
            maintenanceRequest.ShowDialog();
            refreshData();
        }

        private void button_EditRoom_Click(object sender, EventArgs e)
        {
            DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;
            if (dataGridViewCell != null)
            {
                int rowIndex = dataGridViewCell.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                string roomID = dataGridViewRow.Cells[0].Value.ToString();
                EditRoom editRoom = new EditRoom(roomID);
                editRoom.ShowDialog();
                refreshData();
            }
            // message box attention to inform the user to select a row
            else
            {
                MessageBox.Show("Please select a row to edit", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button_ChangeRoom_Click(object sender, EventArgs e)
        {
            ChangeRoom changeRoom = new ChangeRoom();
            changeRoom.ShowDialog();
            refreshData();
        }

        private void button_RoomCheckout_Click(object sender, EventArgs e)
        {
            DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;
            if (dataGridViewCell != null)
            {
                int rowIndex = dataGridViewCell.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                string roomID = dataGridViewRow.Cells[0].Value.ToString();
                RoomCheckout roomCheckout = new RoomCheckout(roomID);
                roomCheckout.ShowDialog();
                refreshData();
            }
        }

        private void button_RoomReport_Click(object sender, EventArgs e)
        {
            DataGridViewCell dataGridViewCell = dataGridView1.CurrentCell;
            if (dataGridViewCell != null)
            {
                int rowIndex = dataGridViewCell.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                string roomID = dataGridViewRow.Cells[0].Value.ToString();
                RoomReport roomReport = new RoomReport(roomID);
                roomReport.ShowDialog();
                refreshData();
            }
        }

        private void button_MaintanenceStatus_Click(object sender, EventArgs e)
        {
            MaintenanceStatus maintananceStatus = new MaintenanceStatus();
            maintananceStatus.ShowDialog();
            refreshData();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            // close connection
            sQLiteHandler.CloseConnection();
            // close this form 
            this.Close();
        }
    }
}
