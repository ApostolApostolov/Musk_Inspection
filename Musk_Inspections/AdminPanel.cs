using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Musk_Inspections
{
    public partial class AdminPanel : Form
    {
        public static class Directories
        {
            public static string dirPDFfile;
            public static string dirWordFile;
            public static string databasePath;
        }

        public AdminPanel()
        {

            //Ignore and DO NOT REMOVE THIS GIBBERISH
            //V momenta v  koito cuknish sumbmit se pravi Word file 
            // sled tova se pravi nova row s id i drygite atribyti
            //sled tova vzima word fila i go preimenyva s id to 
            //chak togava pravi pdf file s id na reporta
            //!! no moje i da napravim purvo row i sled tova da kopirame id-to i da go slojim na word fila
            // Da napravish 
            // 1 da pokazva iztegli vmesto linka kum failsa
            // nameri nachin da otvaeq faila sled kato cuknish na kletkata (VIEW) tova e samo za PDF
            // chujdite klychove da pokazvat value vmesto reference
            //fynkciq za proverqvaneto dali e napisano neshto v HSQE (zasega samo purvite 3 reda) ako ne suobshenie che e ne e napisal nishto ili prosto go ignorira

            // YeeYee
            //test
            InitializeComponent();
            //correct format for picking a date
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
            gettingDirectories();
           
        }
        public void gettingDirectories()
        {
            string directory = Directory.GetCurrentDirectory();
            directory = directory.Substring(0, directory.Length - 9); //remove the unneccesery parts of the current directory
            Directories.databasePath = directory;
            Directories.dirPDFfile = Path.Combine(directory, "pdf_files");
            Directories.dirWordFile = Path.Combine(directory, "word_files");

        }

        private void btnOpenCreateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_report_page Cr = new Create_report_page();
            Cr.ShowDialog();
            this.Close();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Refresh();
            LoginPage lp = new LoginPage();
            lp.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private int getRowIndex(string value)
        {
            for(int i = 0; 1 < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[6].Value.ToString() == value)
                {
                    return (int)dgv.Rows[i].Cells[0].Value;
                }
               
            }
            return -1;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1) //7 or 8
            {
                if (dgv.CurrentCell != null && dgv.CurrentCell.Value != null)
                {
                    MessageBox.Show(dgv.CurrentCell.Value.ToString());

                    string fileId = dgv.CurrentCell.Value.ToString();
                    MessageBox.Show(fileId);
                    //OpenFile(fileId)
                    OpenFile(2);
                    var selectedRow = dgv.SelectedRows;
                    foreach (var row in selectedRow)
                    {
                        int id = (int)((DataGridViewRow)row).Cells[0].Value;
                        MessageBox.Show(id.ToString());
                    }

                   // string filename = Path.Combine(Directories.dirPDFfile, "5.pdf");
                   // System.Diagnostics.Process.Start(filename);

                    //SLED kato razgadaish kak da napravish fail s imeto koeto da e id-to 
                    //IMPORTANT THE FILE NAME HAS TO BE THE SAME AS THE ID

                }
            }
        }
 
        private void btnSearch_Click(object sender, EventArgs e)
            
        {
            using (SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT Inpections_id, Date, SiteName, Work_Area, FirstName, Interventions, Outstanding, FileName  FROM Inspection " +
                    " INNER JOIN Sites ON Sites.Site_id = Inspection.Site_id" +
                    " INNER JOIN Inspector ON Inspector.Inspector_id = Inspection.Inspector_id " +
                    " INNER JOIN pdf_files ON pdf_files.ID = Inspection.PDF_file", sqlcon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dgv.DataSource = dtb1;
                //proper names in the table displayed to the user
                dgv.Columns["Inpections_id"].HeaderText = "Id";
                dgv.Columns["SiteName"].HeaderText = "Site";
                dgv.Columns["Work_Area"].HeaderText = "Work Area";
                dgv.Columns["FileName"].HeaderText = "Inspection";



            }
        }

        private SqlConnection GetConnection()
        {

            return new SqlConnection(Properties.Settings.Default.DB_MUSK);
        }
        private void LoadData()
        {
            using(SqlConnection cn = GetConnection())
            {
                string query = "SELECT ID,FileName,Extension FROM pdf_files";
                SqlDataAdapter adp = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
            }
        }

        private void OpenFile(int id)
        {
            using (SqlConnection cn = GetConnection())
            {
                string query = "SELECT Data,FileName,Extension FROM pdf_files WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.Add("@id",SqlDbType.Int).Value=id;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FIleName"].ToString();
                    var data = (byte[])reader["data"];
                    var extn = reader["Extension"].ToString();
                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;

                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);
                }
            }
        }
       
    }
}
