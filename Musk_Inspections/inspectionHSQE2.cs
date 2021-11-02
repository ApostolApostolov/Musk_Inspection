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
        public inspectionHSQE2()
        {
            InitializeComponent();
            //removes the arrows
            nudInterventions.Controls.RemoveAt(0);
        }
    }
}
