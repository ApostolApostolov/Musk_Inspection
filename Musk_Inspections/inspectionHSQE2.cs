using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Musk_Inspections
{
    public partial class inspectionHSQE2 : Form
    
    {
        public int Interventions;
        public int inspectionId;

        public inspectionHSQE2(Create_report_page.Pages pages)
        {
            InitializeComponent();
            //removes the arrows
            //totalInterventions.Controls.RemoveAt(0);
            this.pages = pages;
        }

        public Create_report_page.Pages pages;
        public inspectionHSQE HSQE;

        public static string workArea;
        public int sumInterventionsHSQE2;
        public static int siteIndex;
        public static string datePicked = null;
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                inspectionHSQE hsqe = pages.HSQE;
                this.FindAndReplace(wordApp, "<site>", hsqe.cb1.Text);
                this.FindAndReplace(wordApp, "<workArea>", hsqe.workBox.Text);
                this.FindAndReplace(wordApp, "<supervisorName>", hsqe.supervisorBox.Text);
                this.FindAndReplace(wordApp, "<jobDescription>", hsqe.jobBox.Text);
                this.FindAndReplace(wordApp, "<type>", hsqe.typeBox.Text);
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                this.FindAndReplace(wordApp, "<upP1>", hsqe.upP1.Text);
                this.FindAndReplace(wordApp, "<upN1>", hsqe.upN1.Text);
                this.FindAndReplace(wordApp, "<comments1>", hsqe.comments2.Text);
                this.FindAndReplace(wordApp, "<upP2>", hsqe.upP2.Text);
                this.FindAndReplace(wordApp, "<upN2>", hsqe.upN2.Text);
                this.FindAndReplace(wordApp, "<comments2>", hsqe.comments2.Text);
                this.FindAndReplace(wordApp, "<upP3>", hsqe.upP3.Text);
                this.FindAndReplace(wordApp, "<upN3>", hsqe.upN3.Text);
                this.FindAndReplace(wordApp, "<comments3>", hsqe.comments3.Text);
                this.FindAndReplace(wordApp, "<upP4>", hsqe.upP4.Text);
                this.FindAndReplace(wordApp, "<upN4>", hsqe.upN4.Text);
                this.FindAndReplace(wordApp, "<comments4>", hsqe.comments4.Text);
                this.FindAndReplace(wordApp, "<upP5>", hsqe.upP5.Text);
                this.FindAndReplace(wordApp, "<upN5>", hsqe.upN5.Text);
                this.FindAndReplace(wordApp, "<comments5>", hsqe.comments5.Text);
                this.FindAndReplace(wordApp, "<upP6>", hsqe.upP6.Text);
                this.FindAndReplace(wordApp, "<upN6>", hsqe.upN6.Text);
                this.FindAndReplace(wordApp, "<comments6>", hsqe.comments6.Text);
                this.FindAndReplace(wordApp, "<upP7>", hsqe.upP7.Text);
                this.FindAndReplace(wordApp, "<upN7>", hsqe.upN7.Text);
                this.FindAndReplace(wordApp, "<comments7>", hsqe.comments7.Text);
                this.FindAndReplace(wordApp, "<upP8>", hsqe.upP8.Text);
                this.FindAndReplace(wordApp, "<upN8>", hsqe.upN8.Text);
                this.FindAndReplace(wordApp, "<comments8>", hsqe.comments8.Text);
                this.FindAndReplace(wordApp, "<upP9>", hsqe.upP9.Text);
                this.FindAndReplace(wordApp, "<upN9>", hsqe.upN9.Text);
                this.FindAndReplace(wordApp, "<comments9>", hsqe.comments9.Text);
                this.FindAndReplace(wordApp, "<upP10>", hsqe.upP10.Text);
                this.FindAndReplace(wordApp, "<upN10>", hsqe.upN10.Text);
                this.FindAndReplace(wordApp, "<comments10>", hsqe.comments10.Text);
                this.FindAndReplace(wordApp, "<upP11>", hsqe.upP11.Text);
                this.FindAndReplace(wordApp, "<upN11>", hsqe.upN11.Text);
                this.FindAndReplace(wordApp, "<comments11>", hsqe.comments11.Text);
                this.FindAndReplace(wordApp, "<upP12>", hsqe.upP12.Text);
                this.FindAndReplace(wordApp, "<upN12>", hsqe.upN12.Text);
                this.FindAndReplace(wordApp, "<comments12>", hsqe.comments12.Text);
                this.FindAndReplace(wordApp, "<upP13>", hsqe.upP13.Text);
                this.FindAndReplace(wordApp, "<upN13>", hsqe.upN13.Text);
                this.FindAndReplace(wordApp, "<comments13>", hsqe.comments13.Text);
                this.FindAndReplace(wordApp, "<upP14>", hsqe.upP14.Text);
                this.FindAndReplace(wordApp, "<upN14>", hsqe.upN14.Text);
                this.FindAndReplace(wordApp, "<comments14>", hsqe.comments14.Text);
                this.FindAndReplace(wordApp, "<upP15>", hsqe.upP15.Text);
                this.FindAndReplace(wordApp, "<upN15>", hsqe.upN15.Text);
                this.FindAndReplace(wordApp, "<comments15>", hsqe.comments15.Text);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                           ref missing, ref missing, ref missing,
                           ref missing, ref missing, ref missing,
                           ref missing, ref missing, ref missing,
                           ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            sumtotalInterventions();
            if (sumInterventionsHSQE2 == 0)
            {
                MessageBox.Show("You have not entered any interventions yet");
                return;
            }
            
             //gets the template
            string fpMain = Dashboard.Directories.mainDirectory;
            string filePathWord = Path.Combine(fpMain, "Temp.docx");

            //create the path for the new file
            string fpWord = Dashboard.Directories.dirWordFile;
            string newWordFilePath = Path.Combine(fpWord, inspectionId + ".docx");

            string filePath = Dashboard.Directories.dirPDFfile;
            filePath = Path.Combine(filePath, "test.pdf");

            CreateWordDocument(filePathWord, newWordFilePath);

            SaveFileIntoDatabase(filePath);
            inspectionIntoDatabase();

            MessageBox.Show("A Great Success");
        }


        private void SaveFileIntoDatabase(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string name = fi.Name;
                string query = "INSERT INTO pdf_files(FileName,Data,Extension)VALUES(@name,@data,@extn)";

                using (SqlConnection cn = GetConnection())
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

        private int InsepctionHSQE2Interventions()
        {
            int total = Convert.ToInt32(upN16.Value + upN17.Value + upN18.Value + upN19.Value + upN20.Value + upN21.Value + upN22.Value + upN23.Value + upN24.Value);
            return total;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(Properties.Settings.Default.DB_MUSK);
        }

        private void inspectionIntoDatabase()
        {
            using (SqlConnection cn = GetConnection())
            {
                cn.Open();
                string query = "SELECT IDENT_CURRENT('Inspection')";
                SqlCommand cmd = new SqlCommand(query, cn);
                inspectionId = Convert.ToInt32(cmd.ExecuteScalar());

            }
            using (SqlConnection cn = GetConnection())
            {
                
               
                string query = "INSERT INTO Inspection(inspectionDate,Site_id,Work_Area,Inspector_id,Interventions,Outstanding,PDF_file) " +
                    "VALUES(@Date,@Site_id,@Work_Area,@Inspector_id,@Interventions,@Outstanding,@PDF_file )";
                SqlCommand cmd = new SqlCommand(query, cn);

               
                
                cmd.Parameters.Add("@Date",SqlDbType.Date).Value = pages.HSQE.datePicked; 
                cmd.Parameters.Add("@Site_id", SqlDbType.Int).Value = pages.HSQE.siteIndex;
                cmd.Parameters.Add("@Work_Area", SqlDbType.NVarChar).Value = pages.HSQE.workArea;
                cmd.Parameters.Add("@Inspector_id", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@Interventions", SqlDbType.Int).Value = sumInterventionsHSQE2;
                cmd.Parameters.Add("@Outstanding", SqlDbType.Bit).Value = cbOutstanding.Checked;
                cmd.Parameters.Add("@PDF_file", SqlDbType.Int ).Value = inspectionId + 1;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        

        private void sumtotalInterventions()
        {
            sumInterventionsHSQE2 =Convert.ToInt32(upN16.Value + upN17.Value + upN18.Value + upN19.Value + upN20.Value + upN21.Value + upN22.Value + upN23.Value + upN24.Value);
            sumInterventionsHSQE2 = sumInterventionsHSQE2 + pages.HSQE.sumInterventionsHSQE;
        }

        private void upN17_ValueChanged_1(object sender, EventArgs e)
        {
            sumtotalInterventions();
            MessageBox.Show("You have not entered any interventions yet");
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN16_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            MessageBox.Show("You have not entered any interventions yet");
        }

        private void upN18_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
        }

        private void upN19_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
        }

        private void upN20_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
        }

        private void upN21_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
        }

        private void upN22_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
        }

        private void upN23_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
        }

        private void upN24_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
        }
    }
}
