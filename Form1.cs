using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Image_Database
{
    public partial class Form1 : Form
    {
        private readonly string constr = "";//@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\AppDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            constr = ConfigurationManager.ConnectionStrings["AppDBConStr"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set AutoGenerateColumns False.
            dataGridView1.AutoGenerateColumns = false;

            //Set Columns Count.
            dataGridView1.ColumnCount = 2;

            //Add Columns.
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].HeaderText = "Image Id";
            dataGridView1.Columns[0].DataPropertyName = "Id";

            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[1].DataPropertyName = "Name";

            //Add a Image Column to the DataGridView at the third position.
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                Name = "Data",
                DataPropertyName = "Data",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Stretch
            };
            dataGridView1.Columns.Insert(2, imageColumn);
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.Columns[2].Width = 100;

            //Bind DataGridView.
            this.BindDataGridView();
        }

        private void BindDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblFiles", conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Bitmaps|*.bmp|PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|TIFF files|*.tif|Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    byte[] bytes = File.ReadAllBytes(fileName);
                    string contentType = "";
                    //Set the contenttype based on File Extension

                    switch (Path.GetExtension(fileName))
                    {
                        case ".jpg":
                            contentType = "image/jpeg";
                            break;
                        case ".png":
                            contentType = "image/png";
                            break;
                        case ".gif":
                            contentType = "image/gif";
                            break;
                        case ".bmp":
                            contentType = "image/bmp";
                            break;
                    }

                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        string sql = "INSERT INTO tblFiles VALUES(@Name, @ContentType, @Data)";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", Path.GetFileName(fileName));
                            cmd.Parameters.AddWithValue("@ContentType", contentType);
                            cmd.Parameters.AddWithValue("@Data", bytes);
                            conn.Open();
                            int result = cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                    this.BindDataGridView();

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


