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

        private static Boolean CheckLogin(string username, string password)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                cn.Open();

                try
                {
                    SqlDataAdapter data = new SqlDataAdapter();
                    DataTable table = new DataTable();

                    try
                    {
                        data = GetPassword(cn, "Inspector", username, password);

                        Reconnect(cn);
                        data.Fill(table);
                        if (table.Rows.Count < 1)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception f)
                    {
                        //MessageBox.Show("f");

                        try
                        {
                            data = GetPassword(cn, "Administrator", username, password);

                            Reconnect(cn);
                            data.Fill(table);
                            if (table.Rows.Count < 1)
                            {
                                throw new Exception();
                            }
                        }
                        catch (Exception g)
                        {
                            LoginFail fail = new LoginFail();
                            fail.Show();

                           // MessageBox.Show("g");
                        }
                    }

                    return table.Rows.Count > 0 ? true : false;
                }
                catch (Exception e) { MessageBox.Show("Error!"); return false; }
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
            if (CheckLogin(tbUsername.Text, tbPassword.Text))
            {
                this.Hide();
                Dashboard dash = new Dashboard();
                dash.ShowDialog();
                this.Close();
            }

        }
    }
}
