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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin(tbUsername.Text, tbPassword.Text);
        }

        private static void CheckLogin(string username, string password)
        { 
            using(SqlConnection cn = clsDB.DBConnection.Connect());
            {
                DataTable table = clsDB.Get_DataTable("Inspector");

                Boolean valid = true ? table.Rows(username)
            }
        }
    }
}
