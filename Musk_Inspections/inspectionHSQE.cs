using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Data.SqlClient;

namespace Musk_Inspections
{
    public partial class inspectionHSQE : Form
    {
        public string workArea;
        public int sumInterventionsHSQE = 0;
        public int siteIndex;
        public string datePicked = null;
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

        public inspectionHSQE()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            getSites();
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

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            siteIndex = cb1.SelectedIndex;
            datePicked = dateTimePicker1.Value.ToString("dd-MM-yyyy");
          
        }
       
 
        private void getSites()
        {
            using (SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.DB_MUSK))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select SiteName From Sites", sqlcon);
                SqlDataReader Sdr = cmd.ExecuteReader();
                while (Sdr.Read())
                {
                    for (int i = 0; i < Sdr.FieldCount; i++)
                    {
                        cb1.Items.Add(Sdr.GetString(i));

                    }
                }
                Sdr.Close();
                sqlcon.Close();

            }
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(Properties.Settings.Default.DB_MUSK);
        }


 

        public void InspectionHSQEIntevention()
        {
             int total = Convert.ToInt32(upN1.Value + upN2.Value + upN3.Value +upN4.Value +upN5.Value + upN6.Value + upN7.Value + upN8.Value + upN9.Value + upN10.Value +
                upN10.Value + upN11.Value + upN12.Value + upN13.Value + upN14.Value + upN15.Value);
            sumInterventionsHSQE = total;
        }
        
        
      
        
        private void upN1_ValueChanged_1(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
            
        }

        private void upN2_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
           
        }

        private void upN3_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }
        private void upN4_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void upN5_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void upN6_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void upN7_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void upN8_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void upN9_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void upN10_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void upN11_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void upN12_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }
        private void upN13_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }
        private void upN14_ValueChanged(object sender, EventArgs e)
        {
            InspectionHSQEIntevention();
        }

        private void workBox_TextChanged(object sender, EventArgs e)
        {
            workArea = workBox.Text;
        }
    }
}
