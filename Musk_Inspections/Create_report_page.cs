using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;


namespace Musk_Inspections
{
    public partial class Create_report_page : Form
    {
        // Class to host the instances of the different pages of the report that may need to refer to eachother's fields/data
        public class Pages
        {
            public inspectionHSQE HSQE;
            public inspectionHSQE2 HSQE2;

            internal Pages()
            {
                HSQE = new inspectionHSQE() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                HSQE2 = new inspectionHSQE2(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            }
        }
        
        public Pages pages;

        public Create_report_page()
        {
            InitializeComponent();
            pages = new Pages();
        }
                     
        //database push


        private void button1_Click(object sender, EventArgs e)
        {
            //Open the dashboard
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.ShowDialog();
            this.Close();
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {
            //opent the HSQE form inside the panel
            this.pForms.Controls.Add(pages.HSQE);
            this.pForms.Controls.Add(pages.HSQE2);
            pages.HSQE.Show();
        }

        private void pForms_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
        private void Button2_Click(object sender, EventArgs e)
        {
            if (pForms.Controls.Count == 0)
            {
                return;
            }
            this.pForms.Controls.Add(pages.HSQE);
            pages.HSQE.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (pForms.Controls.Count == 0)
            {
                return;
            }
            this.pForms.Controls.Add(pages.HSQE2);
            pages.HSQE2.Show();
        }
        ///
      

        public SqlConnection GetConnection()
        {
          
            return new SqlConnection(Properties.Settings.Default.DB_MUSK);
        }

        private void intoDatabase()
        {
 

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_report_page_Load(object sender, EventArgs e)
        {

        }

     
    }
}
