using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Re_QuanLiKS
{
    internal class SQLHandler
    {
        // singleton pattern for SQLite
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;
        private static SQLHandler instance;
        private SQLHandler()
        {
            connection = new SQLiteConnection("Data Source=../../database.db;Version=3;");
            connection.Open();
            command = new SQLiteCommand(connection);
        }
        public static SQLHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SQLHandler();
                }
                return instance;
            }
        }
        public SQLiteDataReader ExecuteQuery(string query)
        {
            command.CommandText = query;
            reader = command.ExecuteReader();
            return reader;
        }
        public void ExecuteNonQuery(string query)
        {
            command.CommandText = query;
            command.ExecuteNonQuery();
        }
        public void Close()
        {
            connection.Close();
        }
        // refresh connection
        public void Refresh()
        {
            connection.Close();
            connection.Open();
        }
        // get a single integer value from a query
        public int GetInt(string query)
        {
            command.CommandText = query;
            reader = command.ExecuteReader();
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            return result;
        }
        // get a single string value from a query
        public string GetString(string query)
        {
            command.CommandText = query;
            reader = command.ExecuteReader();
            reader.Read();
            string result = reader.GetString(0);
            reader.Close();
            return result;
        }

        // get a single double value from a query
        public double GetDouble(string query)
        {
            command.CommandText = query;
            reader = command.ExecuteReader();
            reader.Read();
            double result = reader.GetDouble(0);
            reader.Close();
            return result;
        }
        public List<string> GetUsernameAndPassword(string username, string password)
        {
            string query = "SELECT username, password FROM Receptionist WHERE username = '" + username + "' AND password = '" + password + "'";
            List<string> result = new List<string>();
            command.CommandText = query;
            reader = command.ExecuteReader();
            // if the query returns nothing, show a message box and return null
            if (!reader.Read())
            {
                //MessageBox.Show("Username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
                return null;
            }
            // if the query returns something, add the username and password to the list and return it
            result.Add(reader.GetString(0));
            result.Add(reader.GetString(1));
            reader.Close();
            return result;
        }
        

    }
}
