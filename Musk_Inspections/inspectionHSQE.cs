using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;

namespace Musk_Inspections
{
    public partial class inspectionHSQE : Form
    {

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
                this.FindAndReplace(wordApp, "<site>", siteBox.Text);
                this.FindAndReplace(wordApp, "<workArea>", workBox.Text);
                this.FindAndReplace(wordApp, "<supervisorName>", supervisorBox.Text);
                this.FindAndReplace(wordApp, "<jobDescription>", jobBox.Text);
                this.FindAndReplace(wordApp, "<type>", typeBox.Text);
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                this.FindAndReplace(wordApp, "<upP1>", upP1.Text);
                this.FindAndReplace(wordApp, "<upN1>", upN1.Text);
                this.FindAndReplace(wordApp, "<comments1>", comments2.Text);
                this.FindAndReplace(wordApp, "<upP2>", upP2.Text);
                this.FindAndReplace(wordApp, "<upN2>", upN2.Text);
                this.FindAndReplace(wordApp, "<comments2>", comments2.Text);
                this.FindAndReplace(wordApp, "<upP3>", upP3.Text);
                this.FindAndReplace(wordApp, "<upN3>", upN3.Text);
                this.FindAndReplace(wordApp, "<comments3>", comments3.Text);
                this.FindAndReplace(wordApp, "<upP4>", upP4.Text);
                this.FindAndReplace(wordApp, "<upN4>", upN4.Text);
                this.FindAndReplace(wordApp, "<comments4>", comments4.Text);
                this.FindAndReplace(wordApp, "<upP5>", upP5.Text);
                this.FindAndReplace(wordApp, "<upN5>", upN5.Text);
                this.FindAndReplace(wordApp, "<comments5>", comments5.Text);
                this.FindAndReplace(wordApp, "<upP6>", upP6.Text);
                this.FindAndReplace(wordApp, "<upN6>", upN6.Text);
                this.FindAndReplace(wordApp, "<comments6>", comments6.Text);
                this.FindAndReplace(wordApp, "<upP7>", upP7.Text);
                this.FindAndReplace(wordApp, "<upN7>", upN7.Text);
                this.FindAndReplace(wordApp, "<comments7>", comments7.Text);
                this.FindAndReplace(wordApp, "<upP8>", upP8.Text);
                this.FindAndReplace(wordApp, "<upN8>", upN8.Text);
                this.FindAndReplace(wordApp, "<comments8>", comments8.Text);
                this.FindAndReplace(wordApp, "<upP9>", upP9.Text);
                this.FindAndReplace(wordApp, "<upN9>", upN9.Text);
                this.FindAndReplace(wordApp, "<comments9>", comments9.Text);
                this.FindAndReplace(wordApp, "<upP10>", upP10.Text);
                this.FindAndReplace(wordApp, "<upN10>", upN10.Text);
                this.FindAndReplace(wordApp, "<comments10>", comments10.Text);
                this.FindAndReplace(wordApp, "<upP11>", upP11.Text);
                this.FindAndReplace(wordApp, "<upN11>", upN11.Text);
                this.FindAndReplace(wordApp, "<comments11>", comments11.Text);
                this.FindAndReplace(wordApp, "<upP12>", upP12.Text);
                this.FindAndReplace(wordApp, "<upN12>", upN12.Text);
                this.FindAndReplace(wordApp, "<comments12>", comments12.Text);
                this.FindAndReplace(wordApp, "<upP13>", upP13.Text);
                this.FindAndReplace(wordApp, "<upN13>", upN13.Text);
                this.FindAndReplace(wordApp, "<comments13>", comments13.Text);
                this.FindAndReplace(wordApp, "<upP14>", upP14.Text);
                this.FindAndReplace(wordApp, "<upN14>", upN14.Text);
                this.FindAndReplace(wordApp, "<comments14>", comments14.Text);
                this.FindAndReplace(wordApp, "<upP15>", upP15.Text);
                this.FindAndReplace(wordApp, "<upN15>", upN15.Text);
                this.FindAndReplace(wordApp, "<comments15>", comments15.Text);


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
            CreateWordDocument(@"C:\Users\Rui\source\repos\ApostolApostolov\Musk_Inspection\Temp.docx", @"C:\Users\Rui\source\repos\ApostolApostolov\Musk_Inspection\MuskReport.docx");
        }
        public inspectionHSQE()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        
    }
}
