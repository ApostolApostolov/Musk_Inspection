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
        inspectionHSQE HSQE = new inspectionHSQE() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        inspectionHSQE2 HSQE2 = new inspectionHSQE2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        public Create_report_page()
        {
            InitializeComponent();
        }
                     


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
            this.pForms.Controls.Add(HSQE);
            this.pForms.Controls.Add(HSQE2);
            HSQE.Show();
        }

        private void pForms_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HSQE.Hide();
            HSQE2.TopLevel = false;
            HSQE2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HSQE2.Hide();
            HSQE.Show();
        }

      

        private void SaveFile(string filePath)
        {
            using(Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                string extn = new FileInfo(filePath).Extension;
                string query = "INSERT INTO pdf_files (Data,Extension)VALUES(@data,@extn) ";

                using (SqlConnection cn=GetConnection())
                {
                    
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\Local; Database=Musk_DB.mdf;Integrated Security= sspi;  ");
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string filePath = Dashboard.Directories.dirPDFfile;
            filePath = Path.Combine(filePath, "test.pdf");
            SaveFile(filePath);
            MessageBox.Show("A Great Success");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
