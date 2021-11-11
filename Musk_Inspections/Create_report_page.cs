using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Musk_Inspections
{
    public partial class Create_report_page : Form
    {
        public Create_report_page()
        {
            InitializeComponent();
        }
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
            inspectionHSQE HSQE = new inspectionHSQE() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pForms.Controls.Add(HSQE);
            HSQE.Show();
           

        }

        private void pForms_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                this.FindAndReplace(wordApp, "<name>", textBox1.Text);
                this.FindAndReplace(wordApp, "<workArea>", textBox2.Text);
                this.FindAndReplace(wordApp, "<site>", textBox3.Text);
                this.FindAndReplace(wordApp, "<jobDescription>", textBox4.Text);
                this.FindAndReplace(wordApp, "<type>", textBox5.Text);
                this.FindAndReplace(wordApp, "<feedback>", textBox6.Text);               
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
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

        private void button3_Click(object sender, EventArgs e)
        {
            CreateWordDocument(@"C:\Developement\Musk_Inspection\Temp.docx", @"C:\Developement\Musk_Inspection\MuskReport.docx");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateWordDocument(@"C:\Developement\Musk_Inspection\Temp.docx", @"C:\Developement\Musk_Inspection\MuskReport.pdf");
        }
    }
}
