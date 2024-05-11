using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Re_QuanLiKS
{
    internal class PrintReceipt
    {
        private static string filePath = @"../../Invoice.txt";

        private static string ReadFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading the file: " + ex.Message);
                return null;
            }
        }

        private static void PrintText(string textToPrint)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (sender, e) =>
                {
                    e.Graphics.DrawString(textToPrint, new Font("Arial", 12), Brushes.Black, new PointF(10, 10));
                    e.HasMorePages = false; // Set to true if you want to print multiple pages
                };

                pd.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error printing the file: " + ex.Message);
            }
        }

        private static void PrintTextPrintDialog(string textToPrint)
        {
            try
            {
                PrintDialog pd = new PrintDialog();
                PrintDocument pdoc = new PrintDocument();
                pdoc.PrintPage += (sender, e) =>
                {
                    e.Graphics.DrawString(textToPrint, new Font("Courier New", 10), Brushes.Black, new PointF(10, 10));
                    e.HasMorePages = false; // Set to true if you want to print multiple pages
                };

                pd.Document = pdoc;
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error printing the file: " + ex.Message);
            }
        }

        public static void Print()
        {
            string textToPrint = ReadFile(filePath);

            if (!string.IsNullOrEmpty(textToPrint))
            {
                PrintTextPrintDialog(textToPrint);
            }
            else
            {
                // message box warning
                MessageBox.Show("Nothing to print", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Print(string filePath)
        {
            string textToPrint = ReadFile(filePath);

            if (!string.IsNullOrEmpty(textToPrint))
            {
                PrintTextPrintDialog(textToPrint);
            }
            else
            {
                // message box warning
                MessageBox.Show("Nothing to print", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
