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
        }

        private void openFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            inspectionHSQE HSQE = new inspectionHSQE();
            HSQE.ShowDialog();
            this.Close();
        }
    }
}
