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
        inspectionHSQE HSQE = new inspectionHSQE() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        inspectionHSQE2 HSQE2 = new inspectionHSQE2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        public Create_report_page()
        {
            InitializeComponent();
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
            this.pForms.Controls.Add(HSQE);
            this.pForms.Controls.Add(HSQE2);
            HSQE.Show();
        }

        private void pForms_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HSQE.Hide();
            HSQE2.TopLevel = false;
            HSQE2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HSQE2.Hide();
            HSQE.Show();
        }
    }
}
