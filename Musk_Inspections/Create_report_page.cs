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
            this.pForms.Controls.Add(HSQE);
            HSQE.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.pForms.Controls.Add(HSQE2);
            HSQE2.Show();
        }
        ///
      

        private void SaveFile(string filePath)
        {
            using(Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string name = fi.Name;
                string query = "INSERT INTO pdf_files(FileName,Data,Extension)VALUES(@name,@data,@extn)";

                using (SqlConnection cn=GetConnection())
                {
                    
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public SqlConnection GetConnection()
        {
          
            return new SqlConnection(Properties.Settings.Default.DB_MUSK);
            // "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_Musk.mdf;Integrated Security=True"
            //(Properties.Settings.Default.db_Musk
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string filePath = Dashboard.Directories.dirPDFfile;
            filePath = Path.Combine(filePath, "test.pdf");
            SaveFile(filePath);
            //insert into inspection
            MessageBox.Show("A Great Success");
        }
        private void intoDatabase()
        {
            //we have the inspector
            //site 
            //and pfd file (id + 1) resetni countera i da pochava ot 0

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
