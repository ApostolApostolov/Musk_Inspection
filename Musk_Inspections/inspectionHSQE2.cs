using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        public static int inspectionId;
        public inspectionHSQE2()
        {
            InitializeComponent();
            //removes the arrows
            totalInterventions.Controls.RemoveAt(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total1 = InsepctionHSQE2Interventions();
            SumInterventions = total1 + inspectionHSQE.sumInterventions;
            if (SumInterventions == 0)
            {
                MessageBox.Show("You have not entered any interventions yet");
                return;
            }


            string filePath = Dashboard.Directories.dirPDFfile;
            filePath = Path.Combine(filePath, "test.pdf");
            SaveFile(filePath);
            intoDatabase();

            MessageBox.Show("A Great Success");

            

        }


        private void SaveFile(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);
                string extn = fi.Extension;
                string name = fi.Name;
                string query = "INSERT INTO pdf_files(FileName,Data,Extension)VALUES(@name,@data,@extn)";

                using (SqlConnection cn = GetConnection())
                {

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@extn", SqlDbType.Char).Value = extn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private int InsepctionHSQE2Interventions()
        {
            int total = Convert.ToInt32(upN16.Value + upN17.Value + upN18.Value + upN19.Value + upN20.Value + upN21.Value + upN22.Value + upN23.Value + upN24.Value);
            return total;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(Properties.Settings.Default.DB_MUSK);
        }

        private void intoDatabase()
        {
            using (SqlConnection cn = GetConnection())
            {
                cn.Open();
                string query = "SELECT IDENT_CURRENT('Inspection')";
                SqlCommand cmd = new SqlCommand(query, cn);
                inspectionId = Convert.ToInt32(cmd.ExecuteScalar());

            }
            using (SqlConnection cn = GetConnection())
            {
                //query da vzeme id-to and segashnata inspeciq
               
                string query = "INSERT INTO Inspection(inspectionDate,Site_id,Work_Area,Inspector_id,Interventions,Outstanding,PDF_file) " +
                    "VALUES(@Date,@Site_id,@Work_Area,@Inspector_id,@Interventions,@Outstanding,@PDF_file )";
                SqlCommand cmd = new SqlCommand(query, cn);

                /* remove if above works
                cmd.CommandText = "SELECT IDENT_CURRENT('Inspection')";
                int inspectionId = Convert.ToInt32(cmd.ExecuteScalar());
                //SqlCommand cmd = new SqlCommand("sp_insert", cn);
                */
                
                cmd.Parameters.Add("@Date",SqlDbType.Date).Value = inspectionHSQE.datePicked; //inspectionHSQE.datePicked
                cmd.Parameters.Add("@Site_id", SqlDbType.Int).Value =inspectionHSQE.siteIndex;
                cmd.Parameters.Add("@Work_Area", SqlDbType.NVarChar).Value = inspectionHSQE.workArea;
                cmd.Parameters.Add("@Inspector_id", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@Interventions", SqlDbType.Int).Value =  SumInterventions;
                cmd.Parameters.Add("@Outstanding", SqlDbType.Bit).Value = cbOutstanding.Checked;
                cmd.Parameters.Add("@PDF_file", SqlDbType.Int ).Value = inspectionId + 2;
                //cmd.Parameters.AddWithValue("@Date",SqlDbType.)
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
