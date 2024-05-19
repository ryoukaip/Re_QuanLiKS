using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Re_QuanLiKS
{
    public partial class LoginMenu : Form
    {
        //private static SQLHandler sql;
        private static SQLiteHandler sqlite;

        // Brute-force login times
        private int maxLogin = 3;
        private int currentLoginTimes = 0;

        public LoginMenu()
        {
            InitializeComponent();
            //sql = SQLHandler.Instance;
            sqlite = SQLiteHandler.Instance;

        }

        private void button_clear_input_Click(object sender, EventArgs e)
        {
            textBox_password.Text = "";
            textBox_username.Text = "";
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                this.Show();
                return;
            }
            Application.Exit();
        }

        //private void button_login_Click(object sender, EventArgs e, int a)
        //{
        //    string username = textBox_username.Text;
        //    string password = textBox_password.Text;
        //    List<string> usernameAndPassword = sql.GetUsernameAndPassword(username, password);
        //    // if list is null
        //    if (usernameAndPassword == null)
        //    {
        //        MessageBox.Show("Username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    // if list is not null and username = List[0] and password = List[1]
        //    else if (usernameAndPassword[0] == username && usernameAndPassword[1] == password)
        //    {
        //        MainInterface mainInterface = new MainInterface();
        //        mainInterface.ShowDialog();
        //        this.Show();
        //    }

        //    sql.Close();
        //}
        //private void button_login_Click(object sender, EventArgs e)
        //{
        //    sqlite.OpenConnection();
        //    string username = textBox_username.Text;
        //    string password = textBox_password.Text;
        //    string usernameFromDatabase = sqlite.ExecuteScalar<string>
        //    (
        //    "SELECT Username from Receptionist " +
        //    "WHERE Username = '" + username +"'" +
        //    "AND Password = '" + password + "'");
        //    string passwordFromDatabase = sqlite.ExecuteScalar<string>
        //    (
        //        "SELECT Password from Receptionist " +
        //        "WHERE Username = '" + username + "'");
        //    // if username and password are correct
        //    if ((username == usernameFromDatabase) && BCrypt.Net.BCrypt.Verify(password, passwordFromDatabase))
        //    {
        //        MainInterface mainInterface = new MainInterface();
        //        this.Hide();
        //        mainInterface.ShowDialog();
        //        this.Show();
        //        sqlite.CloseConnection();
        //    }
        //    // if username and password are incorrect
        //    else
        //    {
        //        MessageBox.Show("Username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}
        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            sqlite.OpenConnection();

            // The account is blocked
            if (IsAccountBlocked(username) == "BLOCK")
            {
                MessageBox.Show("Your account is blocked. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve the password from the database based on the username
            string passwordFromDatabase = sqlite.ExecuteScalar<string>
            (
                "SELECT Password FROM Receptionist WHERE Username = '" + username + "'"
            );

            // Verify the password if the username exists in the database
            if (!string.IsNullOrEmpty(passwordFromDatabase) && BCrypt.Net.BCrypt.Verify(password, passwordFromDatabase) && (textBox_iv.Text == AESHandler.defaultIV))
            {
                MainInterface mainInterface = new MainInterface();
                this.Hide();
                mainInterface.ShowDialog();
                this.Show();
                sqlite.CloseConnection();
            }
            else
            {
                // Username is exist but enter password is incorrect
                if (isUsernameExist(username))
                {
                    // Block account if incorrect
                    if (currentLoginTimes == maxLogin)
                    {
                        BlockAccount(username);
                        return;
                    }

                    MessageBox.Show("Password is incorrect, your account will be blocked after " + (maxLogin - currentLoginTimes) + " tries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentLoginTimes++;
                }
                // Not found username
                else
                {
                    MessageBox.Show("Please check username again");
                } 
            }
        }

        private bool isUsernameExist(string username)
        {
            return !string.IsNullOrEmpty(sqlite.ExecuteScalar<string>
            (
                "SELECT Username FROM Receptionist WHERE Username = '" + username + "'"
            ));
        }

        // Block account (anti Brute-Force),
        // "BLOCK" = account is block
        // "UNLOCK" = account is unlock
        private string IsAccountBlocked(string username)
        {
            return sqlite.ExecuteScalar<string>
            (
                "SELECT isBlock FROM Receptionist WHERE Username = '" + username + "'"
            );
        }

        private void BlockAccount(string username)
        {
            // Set isBlock column to 1 (true) for the specified username
            sqlite.ExecuteNonQuery(
                "UPDATE Receptionist SET isBlock = 'BLOCK' WHERE Username = '" + username + "'"
            );

            MessageBox.Show("Your account has been blocked due to multiple incorrect login attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Reset login attempt counter
            currentLoginTimes = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = new MainInterface();
            this.Hide();
            mainInterface.ShowDialog();
            this.Show();
        }
    }
}
