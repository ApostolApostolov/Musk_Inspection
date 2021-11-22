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
            this.pForms.Controls.Add(HSQE);
            this.pForms.Controls.Add(HSQE2);
            HSQE.Show();
        }

        private void pForms_Paint(object sender, PaintEventArgs e)
        {
            
        }

        // do not exist but remove them and it break the program
        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }
        ///
      

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
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(Properties.Settings.Default.Musk_DBConnectionString);
            //return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Database=db_Musk.mdf;Integrated Security= sspi;  ");
            
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

        private void Create_report_page_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string filePath = Dashboard.Directories.dirPDFfile;
            filePath = Path.Combine(filePath, "test.pdf");
            SaveFile(filePath);
            MessageBox.Show("A Great Success");
        }
    }
}
