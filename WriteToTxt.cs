using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Re_QuanLiKS
{
    internal class WriteToTxt
    {
        private static string pathToFile = @"../../Invoice.txt";
        public WriteToTxt()
        {
            
        }
        public static void setFilePath(string filePath)
        {
            pathToFile = filePath;
        }

        public static void Line(string line)
        {
            // write 1 line to the txt file
            StreamWriter streamWriter = new StreamWriter(pathToFile, true);
            streamWriter.WriteLine(line);
            streamWriter.Close();
        }

        public static void Table(DataTable dataTable)
        {
            // write the whole data table to the txt file
            WriteDataTableToFile(dataTable, pathToFile);
        }

        public static void WriteSeperator()
        {
            StreamWriter streamWriter = new StreamWriter(pathToFile, true);
            streamWriter.WriteLine("------------------------------------------------");
            streamWriter.Close();
        }

        public static void WriteTab()
        {
            StreamWriter streamWriter = new StreamWriter(pathToFile, true);
            streamWriter.Write("\t");
            streamWriter.Close();
        }
        public static void WriteTab(string Line)
        {
            StreamWriter streamWriter = new StreamWriter(pathToFile, true);
            streamWriter.Write("\t");
            streamWriter.Write(Line);
            streamWriter.Close();
        }

        public static void ClearTextFile(string filePath = @"../../Invoice.txt")
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    sw.Write(string.Empty);
                }
                //Console.WriteLine("File cleared successfully: " + filePath);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error clearing the file: " + ex.Message);
                MessageBox.Show("Error clearing the file: " + ex.Message);
            }
        }
        static void WriteDataTableToFile(DataTable dataTable, string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    // reformat the data table
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string name = row[0].ToString();
                        if (name.Length > 12)
                        {
                            row[0] = name.Substring(0, 8) + "...";
                        }
                    }

                    // Write column headers
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        sw.Write("{0,-10}", column.ColumnName);
                    }
                    sw.WriteLine();

                    // Write data rows
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            sw.Write("{0,-10}", item);
                        }
                        sw.WriteLine();
                    }
                }

                //Console.WriteLine("Data written to the file: " + filePath);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error writing to the file: " + ex.Message);
                MessageBox.Show("Error writing to the file: " + ex.Message);
            }
        }
        
    }
}
