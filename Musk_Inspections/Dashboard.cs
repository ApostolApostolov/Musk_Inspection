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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnOpenCreateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_report_page Cr = new Create_report_page();
            Cr.ShowDialog();
            this.Close();
        }
    }
}
