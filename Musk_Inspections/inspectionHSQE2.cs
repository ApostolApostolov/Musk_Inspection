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

        private string ReturnChecked(CheckBox cb)
        {
            switch (cb.Checked)
            {
                case true:
                    {
                        return "☑";
                    }
                default:
                case false:
                    {
                        return "☐";
                    }
            }
        }

        private void CopyTemp(object origin, object temp)
        {
            try { File.Copy(origin.ToString(), temp.ToString(), true); }
            catch (Exception e) { MessageBox.Show("Could not create Temp file. Please try again."); }
        }

        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            object tempTemplate = Path.GetTempPath() + "Temp.docx";

            if (!File.Exists(tempTemplate.ToString()))
                CopyTemp(filename, tempTemplate);

            if (File.Exists(tempTemplate.ToString()))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref tempTemplate, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace

                // Page 1
                inspectionHSQE hsqe = pages.HSQE;
                this.FindAndReplace(wordApp, "<site>", hsqe.cb1.Text);
                this.FindAndReplace(wordApp, "<workArea>", hsqe.workBox.Text);
                this.FindAndReplace(wordApp, "<supervisorName>", hsqe.supervisorBox.Text);
                this.FindAndReplace(wordApp, "<jobDescription>", hsqe.jobBox.Text);
                this.FindAndReplace(wordApp, "<type>", hsqe.typeBox.Text);
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                this.FindAndReplace(wordApp, "<upP1>", hsqe.upP1.Text);
                this.FindAndReplace(wordApp, "<upN1>", hsqe.upN1.Text);
                this.FindAndReplace(wordApp, "<cb1>", ReturnChecked(hsqe.checkBox1));
                this.FindAndReplace(wordApp, "<comments1>", hsqe.comments2.Text);
                this.FindAndReplace(wordApp, "<upP2>", hsqe.upP2.Text);
                this.FindAndReplace(wordApp, "<upN2>", hsqe.upN2.Text);
                this.FindAndReplace(wordApp, "<cb2>", ReturnChecked(hsqe.checkBox2));
                this.FindAndReplace(wordApp, "<comments2>", hsqe.comments2.Text);
                this.FindAndReplace(wordApp, "<upP3>", hsqe.upP3.Text);
                this.FindAndReplace(wordApp, "<upN3>", hsqe.upN3.Text);
                this.FindAndReplace(wordApp, "<cb3>", ReturnChecked(hsqe.checkBox3));
                this.FindAndReplace(wordApp, "<comments3>", hsqe.comments3.Text);
                this.FindAndReplace(wordApp, "<upP4>", hsqe.upP4.Text);
                this.FindAndReplace(wordApp, "<upN4>", hsqe.upN4.Text);
                this.FindAndReplace(wordApp, "<cb4>", ReturnChecked(hsqe.checkBox4));
                this.FindAndReplace(wordApp, "<comments4>", hsqe.comments4.Text);
                this.FindAndReplace(wordApp, "<upP5>", hsqe.upP5.Text);
                this.FindAndReplace(wordApp, "<upN5>", hsqe.upN5.Text);
                this.FindAndReplace(wordApp, "<cb5>", ReturnChecked(hsqe.checkBox5));
                this.FindAndReplace(wordApp, "<comments5>", hsqe.comments5.Text);
                this.FindAndReplace(wordApp, "<upP6>", hsqe.upP6.Text);
                this.FindAndReplace(wordApp, "<upN6>", hsqe.upN6.Text);
                this.FindAndReplace(wordApp, "<cb6>", ReturnChecked(hsqe.checkBox6));
                this.FindAndReplace(wordApp, "<comments6>", hsqe.comments6.Text);
                this.FindAndReplace(wordApp, "<upP7>", hsqe.upP7.Text);
                this.FindAndReplace(wordApp, "<upN7>", hsqe.upN7.Text);
                this.FindAndReplace(wordApp, "<cb7>", ReturnChecked(hsqe.checkBox7));
                this.FindAndReplace(wordApp, "<comments7>", hsqe.comments7.Text);
                this.FindAndReplace(wordApp, "<upP8>", hsqe.upP8.Text);
                this.FindAndReplace(wordApp, "<upN8>", hsqe.upN8.Text);
                this.FindAndReplace(wordApp, "<cb8>", ReturnChecked(hsqe.checkBox8));
                this.FindAndReplace(wordApp, "<comments8>", hsqe.comments8.Text);
                this.FindAndReplace(wordApp, "<upP9>", hsqe.upP9.Text);
                this.FindAndReplace(wordApp, "<upN9>", hsqe.upN9.Text);
                this.FindAndReplace(wordApp, "<cb9>", ReturnChecked(hsqe.checkBox9));
                this.FindAndReplace(wordApp, "<comments9>", hsqe.comments9.Text);
                this.FindAndReplace(wordApp, "<upP10>", hsqe.upP10.Text);
                this.FindAndReplace(wordApp, "<upN10>", hsqe.upN10.Text);
                this.FindAndReplace(wordApp, "<cb10>", ReturnChecked(hsqe.checkBox10));
                this.FindAndReplace(wordApp, "<comments10>", hsqe.comments10.Text);
                this.FindAndReplace(wordApp, "<upP11>", hsqe.upP11.Text);
                this.FindAndReplace(wordApp, "<upN11>", hsqe.upN11.Text);
                this.FindAndReplace(wordApp, "<cb11>", ReturnChecked(hsqe.checkBox11));
                this.FindAndReplace(wordApp, "<comments11>", hsqe.comments11.Text);
                this.FindAndReplace(wordApp, "<upP12>", hsqe.upP12.Text);
                this.FindAndReplace(wordApp, "<upN12>", hsqe.upN12.Text);
                this.FindAndReplace(wordApp, "<cb12>", ReturnChecked(hsqe.checkBox12));
                this.FindAndReplace(wordApp, "<comments12>", hsqe.comments12.Text);
                this.FindAndReplace(wordApp, "<upP13>", hsqe.upP13.Text);
                this.FindAndReplace(wordApp, "<upN13>", hsqe.upN13.Text);
                this.FindAndReplace(wordApp, "<cb13>", ReturnChecked(hsqe.checkBox13));
                this.FindAndReplace(wordApp, "<comments13>", hsqe.comments13.Text);
                this.FindAndReplace(wordApp, "<upP14>", hsqe.upP14.Text);
                this.FindAndReplace(wordApp, "<upN14>", hsqe.upN14.Text);
                this.FindAndReplace(wordApp, "<cb14>", ReturnChecked(hsqe.checkBox14));
                this.FindAndReplace(wordApp, "<comments14>", hsqe.comments14.Text);
                this.FindAndReplace(wordApp, "<upP15>", hsqe.upP15.Text);
                this.FindAndReplace(wordApp, "<upN15>", hsqe.upN15.Text);
                this.FindAndReplace(wordApp, "<cb15>", ReturnChecked(hsqe.checkBox15));
                this.FindAndReplace(wordApp, "<comments15>", hsqe.comments15.Text);

                // Page 2 -- ALL FIELDS THERE BUT NUMBERS NOT CHANGED**
                this.FindAndReplace(wordApp, "<upP16>", upP16.Text);
                this.FindAndReplace(wordApp, "<upN16>", upN16.Text);
                this.FindAndReplace(wordApp, "<cb16>", ReturnChecked(checkBox16));
                this.FindAndReplace(wordApp, "<comments16>", comments16.Text);
                this.FindAndReplace(wordApp, "<upP17>", upP17.Text);
                this.FindAndReplace(wordApp, "<upN17>", upN17.Text);
                this.FindAndReplace(wordApp, "<cb17>", ReturnChecked(checkBox17));
                this.FindAndReplace(wordApp, "<comments17>", comments17.Text);
                this.FindAndReplace(wordApp, "<upP18>", upP18.Text);
                this.FindAndReplace(wordApp, "<upN18>", upN18.Text);
                this.FindAndReplace(wordApp, "<cb18>", ReturnChecked(checkBox18));
                this.FindAndReplace(wordApp, "<comments18>", comments18.Text);
                this.FindAndReplace(wordApp, "<upP19>", upP19.Text);
                this.FindAndReplace(wordApp, "<upN19>", upN19.Text);
                this.FindAndReplace(wordApp, "<cb19>", ReturnChecked(checkBox19));
                this.FindAndReplace(wordApp, "<comments19>", comments19.Text);
                this.FindAndReplace(wordApp, "<upP20>", upP20.Text);
                this.FindAndReplace(wordApp, "<upN20>", upN20.Text);
                this.FindAndReplace(wordApp, "<cb20>", ReturnChecked(checkBox20));
                this.FindAndReplace(wordApp, "<comments20>", comments20.Text);
                this.FindAndReplace(wordApp, "<upP21>", upP21.Text);
                this.FindAndReplace(wordApp, "<upN21>", upN21.Text);
                this.FindAndReplace(wordApp, "<cb21>", ReturnChecked(checkBox21));
                this.FindAndReplace(wordApp, "<comments21>", comments21.Text);
                this.FindAndReplace(wordApp, "<upP22>", upP22.Text);
                this.FindAndReplace(wordApp, "<upN22>", upN22.Text);
                this.FindAndReplace(wordApp, "<cb22>", ReturnChecked(checkBox22));
                this.FindAndReplace(wordApp, "<comments22>", comments22.Text);
                this.FindAndReplace(wordApp, "<upP23>", upP23.Text);
                this.FindAndReplace(wordApp, "<upN23>", upN23.Text);
                this.FindAndReplace(wordApp, "<cb23>", ReturnChecked(checkBox23));
                this.FindAndReplace(wordApp, "<comments23>", comments23.Text);
                this.FindAndReplace(wordApp, "<upP24>", upP24.Text);
                this.FindAndReplace(wordApp, "<upN24>", upN24.Text);
                this.FindAndReplace(wordApp, "<cb24>", ReturnChecked(checkBox24));
                this.FindAndReplace(wordApp, "<comments24>", comments24.Text);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            try
            {
                myWordDoc.SaveAs2(ref SaveAs, Word.WdSaveFormat.wdFormatPDF, ref missing, ref missing,
                               ref missing, ref missing, ref missing,
                               ref missing, ref missing, ref missing,
                               ref missing, ref missing, ref missing,
                               ref missing, ref missing, ref missing);

                myWordDoc.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Your version of Microsoft Word or Interop.Word.nupkg may be out of date.\nPlease verify versions and try again.");
            }
            finally
            {
                wordApp.Quit();
                MessageBox.Show("File Created!");
            }
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            sumtotalInterventions();
            if (sumInterventionsHSQE2 == 0)
            {
                MessageBox.Show("You have not entered any interventions yet");
                return;
            }
            if(CheckBegginingTextBoxFilledUp() == true)
            {
                return;
            }

             //gets the template
            string fpMain = Dashboard.Directories.mainDirectory;
            string filePathWord = Path.Combine(fpMain, "Temp.docx");

            //create the path for the new file
            string fpPDF = Dashboard.Directories.dirPDFfile;
            string newPDFFilePath = Path.Combine(fpPDF, inspectionId + ".pdf");

            //gets the pdf file to put it into the database
            //no pdf file created yet
            string filePath = Dashboard.Directories.dirPDFfile;
            filePath = Path.Combine(filePath, "test.pdf");
            //filePath = Path.Combine(filePath, inspectionId + ".pdf");
            //when we create pdf file

            CreateWordDocument(filePathWord, newPDFFilePath);

            SaveFileIntoDatabase(filePath);
            inspectionIntoDatabase();

            MessageBox.Show("A Great Success");
        }

        private Boolean CheckBegginingTextBoxFilledUp()
        {
            if (pages.HSQE.workArea == null)
            {
                 MessageBox.Show("Please add a work area");
                return true;               
            }
            else if (pages.HSQE.supervisorBox == null)
            {
                MessageBox.Show("Please add a supervisor");
                return true;
            }
            else if (pages.HSQE.jobBox == null)
            {
                MessageBox.Show("Please add a job desription");
                return true;
            }
            else if (pages.HSQE.typeBox == null)
            {
                MessageBox.Show("Please add a type of job ");
                return true;
            }
           
            else
            {
                return false;
            }

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
                cmd.Parameters.Add("@Inspector_id", SqlDbType.Int).Value = LoginPage.userid.currentInspectorId;
                cmd.Parameters.Add("@Interventions", SqlDbType.Int).Value = sumInterventionsHSQE2;
                cmd.Parameters.Add("@Outstanding", SqlDbType.Bit).Value = cbOutstanding.Checked;
                cmd.Parameters.Add("@PDF_file", SqlDbType.Int ).Value = inspectionId + 1;

                cn.Open();
                try { cmd.ExecuteNonQuery(); }
                catch (Exception e) {};
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
       
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN16_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN18_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN19_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN20_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN21_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN22_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN23_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }

        private void upN24_ValueChanged(object sender, EventArgs e)
        {
            sumtotalInterventions();
            totalInterventions.Text = sumInterventionsHSQE2.ToString();
        }
    }
}
