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

        private static void Reconnect(SqlConnection cn)
        {
            cn.ConnectionString = Properties.Settings.Default.DB_MUSK;
            cn.Open();
        }

        private static int CheckLogin(string username, string password)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                cn.Open();

                try
                {
                    SqlDataAdapter data = new SqlDataAdapter();
                    DataTable table = new DataTable();

                    int role = 0; // 0 = N/A, 1 = Inspector, 2 = Admin

                    try
                    {
                        data = GetPassword(cn, "Inspector", username, password);

                        Reconnect(cn);
                        data.Fill(table);
                        if (table.Rows.Count < 1)
                        {
                            throw new Exception();
                        }

                        role = 1;

                    }
                    catch (Exception f)
                    {
                        try
                        {
                            data = GetPassword(cn, "Administrator", username, password);

                            Reconnect(cn);
                            data.Fill(table);
                            if (table.Rows.Count < 1)
                            {
                                throw new Exception();
                            }

                            role = 2;
                        }
                        catch (Exception g)
                        {
                            LoginFail fail = new LoginFail();
                            fail.Show();

                            role = 0;
                        }
                    }

                    return role;
                }
                catch (Exception e) { MessageBox.Show("Error!"); return 0; }
            }
        }

        private static SqlDataAdapter GetPassword(SqlConnection cn, string table, string username, string password)
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
                            column = "Username";
                            username = "'" + username + "'";
                            break;
                        }
                }
                    data.SelectCommand = new SqlCommand("SELECT Pwd FROM " + table + " WHERE " + column + " = " + username + " AND Pwd = '" + password + "';", cn);

                return data;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            switch (CheckLogin(tbUsername.Text, tbPassword.Text))
            {
                case 1:
                    {
                        this.Hide();
                        Dashboard dash = new Dashboard();
                        dash.ShowDialog();
                        this.Close();
                        break;
                    }
                case 2:
                    {
                        this.Hide();
                        AdminPanel adPan = new AdminPanel();
                        adPan.ShowDialog();
                        this.Close();
                        break;
                    }
            }
        }
    }
}
