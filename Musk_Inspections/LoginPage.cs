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
        public static class userid
        {
            public static string currentInspectorId;

        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private static Boolean CheckLogin(string username, string password)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                cn.Open();

                try
                {
                    SqlDataAdapter data = new SqlDataAdapter(new SqlCommand("SELECT Pwd FROM Inspector WHERE Inspector_id = " + username + " AND Pwd = " + password));

                    DataTable table = new DataTable();

                    data.Fill(table);

                    return table.Rows.Count > 0 ? true : false;
                }
                catch (Exception e) { return false; }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin(tbUsername.Text, tbPassword.Text))
            {
                userid.currentInspectorId = tbUsername.Text;
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.ShowDialog();
                this.Close();
            }

        }
    }
}
