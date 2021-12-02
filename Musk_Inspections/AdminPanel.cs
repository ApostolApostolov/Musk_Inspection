using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void listReports_Click(object sender, EventArgs e)
        {
            Admin_Functions.ListReports lr = new Admin_Functions.ListReports();
            lr.Show();
        }

        private void viewDocx_Click(object sender, EventArgs e)
        {
            Admin_Functions.ViewDocx vd = new Admin_Functions.ViewDocx();
            vd.Show();
        }

        private void viewPdf_Click(object sender, EventArgs e)
        {
            Admin_Functions.ViewPDF vp = new Admin_Functions.ViewPDF();
            vp.Show();
        }
    }
}
