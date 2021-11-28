using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Musk_Inspections
{
    public partial class Dashboard : Form
    {
        public static class Directories
        {
            public static string dirPDFfile;
            public static string dirWordFile;
            public static string databasePath;
        }

        public Dashboard()
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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dgv.CurrentCell != null && dgv.CurrentCell.Value != null)
                {
                    MessageBox.Show(dgv.CurrentCell.Value.ToString());
                  
                    MessageBox.Show(Directories.dirPDFfile);

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
                /*
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT Ins.Date, s.SiteName, Ins.Work_Area, inp.FirstName, Ins.Interventions, Ins.Outstanding, Ins.PDF_file " +
                    "FROM Inspection AS Ins , Sites AS s , Inspector AS inp" +
                    "JOIN Inspection ON Inspection.Site_id  = s.Site_id", sqlcon);
                    */
                SqlDataAdapter sqlDa = new SqlDataAdapter(
                    "SELECT Date, SiteName, Work_Area, FirstName, Interventions, Outstanding, PDF_file FROM Inspection " +
                    " INNER JOIN Sites ON Sites.Site_id = Inspection.Site_id" +
                    " INNER JOIN Inspector ON Inspector.Inspector_id = Inspection.Inspector_id", sqlcon);

                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dgv.DataSource = dtb1;

            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* private void fillByToolStripButton_Click(object sender, EventArgs e)
         {
             try
             {
                 this.inspectionTableAdapter.FillBy(this.musk_DBDS.Inspection);
             }
             catch (System.Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }

        }*/
    }
}
