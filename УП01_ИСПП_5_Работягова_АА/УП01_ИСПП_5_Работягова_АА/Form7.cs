using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using УП01_ИСПП_5_Работягова_АА.УП01_ИСПП5_Работягова_ААDataSetTableAdapters;

namespace УП01_ИСПП_5_Работягова_АА
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Квартиры". При необходимости она может быть перемещена или удалена.
            this.квартирыTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Квартиры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Дома". При необходимости она может быть перемещена или удалена.
            this.домаTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Дома);

        }
        string a;
        public void st(string s)
        {
            a = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            домаTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Дома);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.Show();
            form5.ii(a);
        }
        private string con = @"Data Source=sql;Initial Catalog = уП01_ИСПП5_Работягова_АА; Integrated Security = True";
        
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
                    command.CommandText = "INSERT INTO myTable (image) VALUES (@Фотографии здания)";

                    var image = new Bitmap(pictureBox.Image);
                    using (var memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        memoryStream.Position = 0;

                        var sqlParameter = new SqlParameter("@Фотографии здания", SqlDbType.VarBinary, (int)memoryStream.Length)
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
                    command.CommandText = "SELECT image FROM myTable WHERE id = @Код дома";
                    command.Parameters.AddWithValue("@Код дома", id);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var imageData = (byte[])reader["Фотографии здания"];
                            using (var memoryStream = new MemoryStream(imageData))
                            {
                                pictureBox.Image = Image.FromStream(memoryStream);
                            }
                        }
                    }
                }
            }
        }

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
    }
}
