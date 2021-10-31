using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Musk_Inspections
{
    public partial class inspectionHSQE : Form
        
    {
        //inspectionHSQE2 inspectionHSQE2;
        public inspectionHSQE()
        {
           
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            

        }
        public bool IsFormOpen(Type formtype)
        {
            //checks if the form is open
            foreach (Form form in Application.OpenForms)
                if (form.GetType().Name == form.Name)
                    return true;
            return false;
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

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(inspectionHSQE2)))
            {
                System.Windows.Forms.MessageBox.Show("My message here");
              // this.Hide();
                //HSQE2.ShowDialog();
            }
            else
            {
              //  this.Hide();
               // HSQE2.Show();

            }
           



        }
    }
}
