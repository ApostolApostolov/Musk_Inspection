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
            public  static string currentInspectorId;

        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private static void Reconnect(SqlConnection cn)
        {
            cn.ConnectionString = Properties.Settings.Default.DB_MUSK;
            cn.Open();
        }

        private static char CheckLogin(string username, string password)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                cn.Open();

                SqlDataAdapter data = new SqlDataAdapter();
                DataTable table = new DataTable();
                char role = char.MinValue;
                string u = string.Empty;

                if (username != "")
                {
                    role = username[0]; // First character is role identifier -> i = Inspector, a = Admin
                    u = username.Substring(1); // The rest is ID in the tables
                }

                try
                {
                    if (role == 'i')
                    {
                        data = GetUser(cn, "Inspector", u, password);

                        
                        Reconnect(cn);
                        data.Fill(table);
                        if (table.Rows.Count != 1)
                        {
                            throw new Exception();
                        }
                    }
                    else if (role == 'a')
                    {
                            data = GetUser(cn, "Administrator", u, password);

                            Reconnect(cn);
                            data.Fill(table);
                            if (table.Rows.Count != 1)
                            {
                                throw new Exception();
                            }
                    }

                    return role;
                }
                catch (Exception g)
                {
                    return role = 'n';
                }
            }
        }

        private static SqlDataAdapter GetUser(SqlConnection cn, string table, string username, string password)
        {
            using (cn)
            {
                SqlDataAdapter data = new SqlDataAdapter();
                string column;

                switch (table)
                {
                    default:
                    case "Inspector":
                        {
                            column = "Inspector_id";
                            break;
                        }
                    case "Administrator":
                        {
                            column = "Admin_id";
                            break;
                        }
                }
                    data.SelectCommand = new SqlCommand("SELECT * FROM " + table + " WHERE " + column + " = " + username + " AND Pwd = '" + password + "';", cn);

                return data;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            switch (CheckLogin(tbUsername.Text, tbPassword.Text))
            {
                case 'i':
                    {
                        userid.currentInspectorId = tbUsername.Text.Remove(0,1);
                        this.Hide();
                        Dashboard dash = new Dashboard();
                        dash.ShowDialog();
                        this.Close();
                        break;
                    }
                case 'a':
                    {
                        this.Hide();
                        AdminPanel adPan = new AdminPanel();
                        adPan.ShowDialog();
                        this.Close();
                        break;
                    }
                default:
                case 'n':
                    {
                        MessageBox.Show("The Username or Password you entered were incorrect. Try Again.", "Invalid Login");
                        break;  
                    }
            }
        }
    }
}
