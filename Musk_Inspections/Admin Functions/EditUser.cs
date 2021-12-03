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

namespace Musk_Inspections.Admin_Functions
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (!sureCB.Checked)
            {
                MessageBox.Show("You must tick the Checkbox to confirm.");
                return;
            }
            if (!gotUser)
            {
                MessageBox.Show("Please select a user to edit, and press 'Get User'.");
                return;
            }

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                cn.Open();

                string un = unText.Text;
                char role = un[0]; // First character is role identifier -> i = Inspector, a = Admin
                string u = un.Substring(1); // The rest is ID in the tables

                SqlCommand get = new SqlCommand();
                SqlCommand set = new SqlCommand();

                // Check the db entry to check for unchanged values
                switch (role)
                {
                    case 'a':
                        {
                            get = new SqlCommand("SELECT * FROM Administrator WHERE Admin_id = " + u, cn);
                            break;
                        }
                    case 'i':
                        {
                            get = new SqlCommand("SELECT * FROM Inspector WHERE Inspector_id = " + u, cn);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Invalid Username. Make sure you include the character at the beginning. ie. 'i123'");
                            return;
                        }
                }
                DataTable dt = new DataTable();
                SqlDataReader reader = get.ExecuteReader();
                dt.Load(reader);

                // Initialize the local variables only if they are different
                string pw = pwText.Text == dt.Rows[0].Field<string>("Pwd") ? null : pwText.Text;
                string fn = fnText.Text == dt.Rows[0].Field<string>("FirstName") ? null : fnText.Text;
                string ln = lnText.Text == dt.Rows[0].Field<string>("LastName") ? null : lnText.Text;

                switch (role)
                {
                    case 'a':
                        {
                            set = new SqlCommand(GenerateEditScript("Administrator", u, fn, ln, pw), cn);
                            break;
                        }
                    case 'i':
                        {
                            set = new SqlCommand(GenerateEditScript("Inspector", u, fn, ln, pw), cn);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Invalid Username. Make sure you include the character at the beginning. ie. 'i123'");
                            return;
                        }
                }

                try
                {
                    set.ExecuteNonQuery();
                    MessageBox.Show("User records updated successfully.");
                    this.Close();
                }
                catch (Exception f)
                {
                    MessageBox.Show("User records could not be updated.");
                    return;
                }
            }

            this.Close();
        }

        private string GenerateEditScript(string table, string user, string fn , string ln, string pw)
        {
            bool fnApply = fn != null ? true : false;
            bool lnApply = ln != null ? true : false;
            bool pwApply = pw != null ? true : false;

            string query = "UPDATE " + table + " SET ";

            if (fnApply)
            {
                query += $"FirstName = '{fn}'";
            }
            if (lnApply)
            {
                if (fnApply)
                    query += ", ";

                query += $"LastName = '{ln}'";
            }
            if (pwApply)
            {
                if (fnApply || lnApply)
                    query += ", ";

                query += $"Pwd = '{pw}'";
            }

            switch (table)
            {
                case "Administrator":
                    {
                        query += " WHERE Admin_id = " + user;
                        break;
                    }
                case "Inspector":
                    {
                        query += " WHERE Inspector_id = " + user;
                        break;
                    }
            }

            return query;
        }

        Boolean gotUser = false;
        private void unText_TextChanged(object sender, EventArgs e)
        {
            gotUser = false;
        }

        private void getUser_Click(object sender, EventArgs e)
        {
            string un = unText.Text;
            char role = 'n';
            string u = null;

            if (unText.Text != null)
            {
                role = un[0]; // First character is role identifier -> i = Inspector, a = Admin
                u = un.Substring(1); // The rest is ID in the tables
            }

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();

                switch (role)
                {
                    case 'a':
                        {
                            cmd = new SqlCommand("SELECT * FROM Administrator WHERE Admin_id = " + u, cn);
                            break;
                        }
                    case 'i':
                        {
                            cmd = new SqlCommand("SELECT * FROM Inspector WHERE Inspector_id = " + u, cn);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Invalid Username. Make sure you include the character at the beginning. ie. 'i123'");
                            break;
                        }
                }

                try
                {
                    DataTable dt = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);

                    fnText.Text = dt.Rows[0].Field<string>("FirstName");
                    lnText.Text = dt.Rows[0].Field<string>("LastName");
                    pwText.Text = dt.Rows[0].Field<string>("Pwd");

                }
                catch (Exception f)
                {
                    MessageBox.Show("Could not retrieve User details.");
                }
            }

            gotUser = true;
        }

        private void showPw_CheckedChanged(object sender, EventArgs e)
        {
            switch (showPw.Checked)
            {
                case true:
                    {
                        pwText.PasswordChar = '\0';
                        break;
                    }
                case false:
                    {
                        pwText.PasswordChar = '*';
                        break;
                    }
            }
        }
    }
}