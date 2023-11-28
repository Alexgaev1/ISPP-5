using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace УП_МДК_01_01
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet2.План_квартир". При необходимости она может быть перемещена или удалена.
            this.план_квартирTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet2.План_квартир);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet2.Квартиры". При необходимости она может быть перемещена или удалена.
            this.квартирыTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet2.Квартиры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Договоры". При необходимости она может быть перемещена или удалена.
            this.договорыTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Договоры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Дома". При необходимости она может быть перемещена или удалена.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                квартирыTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet2.Квартиры);
            план_квартирTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet2.План_квартир);
        }
        string a;
        public void st(string s)
        {
            a = s;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.Show();
            form5.ii(a);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            квартирыTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet2.Квартиры);
            план_квартирTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet2.План_квартир);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            квартирыBindingSource.CancelEdit();
            домаBindingSource.CancelEdit();
        }
        private string con = @"Data Source=sql;Initial Catalog = уП01_ИСПП5_Работягова_АА; Integrated Security = True";
        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureSet.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        class ImageUploader
        {
            private readonly string _connectionString;

            public ImageUploader(string connectionString)
            {
                _connectionString = connectionString;
            }

            public void Upload(PictureBox pictureBox)
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [План квартир] ([План квартиры]) VALUES (@План_квартиры)";

                    var image = new Bitmap(pictureBox.Image);
                    using (var memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        memoryStream.Position = 0;

                        var sqlParameter = new SqlParameter("@План_квартиры", SqlDbType.VarBinary, (int)memoryStream.Length)
                        {
                            Value = memoryStream.ToArray()
                        };
                        command.Parameters.Add(sqlParameter);
                    }
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        class ImageRetriever
        {
            private readonly string _connectionString;

            public ImageRetriever(string connectionString)
            {
                _connectionString = connectionString;
            }

            public void Retrieve(PictureBox pictureBox, int id)
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT image FROM myTable WHERE id = @Код плана квартиры";
                    command.Parameters.AddWithValue("@Код плана квартиры", id);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var imageData = (byte[])reader["image"];
                            using (var memoryStream = new MemoryStream(imageData))
                            {
                                pictureBox.Image = Image.FromStream(memoryStream);
                            }
                        }
                    }
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            var uploader = new ImageUploader(con);
            uploader.Upload(pictureSet);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var retriever = new ImageRetriever(con);
            retriever.Retrieve(pictureView, id);
        }

        private void pictureSet_Click(object sender, EventArgs e)
        {
            pictureSet.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pictureView_Click(object sender, EventArgs e)
        {
            pictureView.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
