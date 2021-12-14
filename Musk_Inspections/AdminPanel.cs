using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musk_Inspections
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lp = new LoginPage();
            lp.ShowDialog();
            this.Close();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            Admin_Functions.AddUser au = new Admin_Functions.AddUser();
            au.Show();
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            Admin_Functions.RemoveUser ru = new Admin_Functions.RemoveUser();
            ru.Show();
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            Admin_Functions.EditUser eu = new Admin_Functions.EditUser();
            eu.Show();
        }

        private void viewPdf_Click(object sender, EventArgs e)
        {
            OpenDocumentDialog("pdf");
        }

        private void OpenDocumentDialog(string type)
        {
            string process = String.Empty;

            switch (type)
            {
                default:
                case "pdf":
                    {
                        try
                        {
                            process = "chrome.exe";
                        }
                        catch (Exception f)
                        {
                            process = "msedge.exe";
                        }

                        break;
                    }
                case "docx":
                    {
                        try
                        {
                            process = "winword.exe";
                        }
                        catch (Exception f)
                        {
                            process = "wordpad.exe";
                        }


                        break;
                    }
            }

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Developement\Musk_Inspection\Musk_Inspections\pdf_files\";
                openFileDialog.Filter = $"{type} files (*.{type})|*.{type}|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    using (Stream str = openFileDialog.OpenFile())
                    {
                        try
                        {
                            Process.Start(process, filePath);
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show("Error Opening File!");
                        }
                    }
                }
            }
        }
    }
}
