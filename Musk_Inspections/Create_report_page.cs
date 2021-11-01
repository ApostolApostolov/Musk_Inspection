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
    public partial class Create_report_page : Form
    {
        public Create_report_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.ShowDialog();
            this.Close();
            //this is a text
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            inspectionHSQE HSQE = new inspectionHSQE() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pForms.Controls.Add(HSQE);
            HSQE.Show();
            //HSQE.ShowDialog();
            //this.Close();

        }
    }
}
