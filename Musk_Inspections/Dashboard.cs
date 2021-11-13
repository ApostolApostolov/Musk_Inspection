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
            // YeeYee
            InitializeComponent();
            //correct format for picking a date
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private void btnOpenCreateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_report_page Cr = new Create_report_page();
            Cr.ShowDialog();
            this.Close();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musk_DBDataSet.Inspectors' table. You can move, or remove it, as needed.
            this.inspectorsTableAdapter.Fill(this.musk_DBDataSet.Inspectors);
            // TODO: This line of code loads data into the 'musk_DBDataSet.Inspections' table. You can move, or remove it, as needed.
            this.inspectionsTableAdapter.Fill(this.musk_DBDataSet.Inspections);

        }
    }
}
