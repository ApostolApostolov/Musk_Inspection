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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                cn.Open();
                SqlCommand cmd = null;

                string un = unText.Text;
                string table = null;

                if (!sureCB.Checked)
                { 
                    MessageBox.Show("You must tick the Checkbox to confirm.");
                    return;
                }

                char role = un[0]; // First character is role identifier -> i = Inspector, a = Admin
                string u = un.Substring(1); // The rest is ID in the tables

                switch (role)
                {
                    case 'a':
                        {
                            cmd = new SqlCommand("DELETE FROM Administrator WHERE Admin_id = " + u, cn);
                            break;
                        }
                    case 'i':
                        {
                            cmd = new SqlCommand("DELETE FROM Inspector WHERE Inspector_id = " + u, cn);
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
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User Records Deleted!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("User Records Were Not Deleted!");
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                }
            }

            this.Close();
        }
    }
}
