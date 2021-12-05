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
    public partial class inspectionHSQE2 : Form
    {
        public static int Interventions;
        public static int SumInterventions;
        public inspectionHSQE2()
        {
            InitializeComponent();
            //removes the arrows
            totalInterventions.Controls.RemoveAt(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total1 = InsepctionHSQE2Interventions();
            inspectionHSQE test = new inspectionHSQE();
           // int total2 = inspectionHSQE.InspectionHSQEIntevention();
          //  Interventions = total1 + total2;
            MessageBox.Show(Interventions.ToString());
            
        }
        private int InsepctionHSQE2Interventions()
        {
            int total = Convert.ToInt32(upN16.Value + upN17.Value + upN18.Value + upN19.Value + upN20.Value + upN21.Value + upN22.Value + upN23.Value + upN24.Value);
            if (total == 0)
            {
                MessageBox.Show("You have not entered anything please do before submiting");
                return -1;
            }
            return total;
        }
    }
}
