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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO pdf_files (Data,Extension)VALUES(@data,@extn) ";

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.Musk_DBConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
