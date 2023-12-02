using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Проект
{
    public partial class Soldier : Form
    {
        public Soldier()
        {
            InitializeComponent();
        }

        private void soldier_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        { /*обновление данных в таблице*/
            военнослужащиеTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            dataGridView1.CurrentCell = dataGridView1[0, 0];
        }

        private void button2_Click(object sender, EventArgs e)
        { /*открытие формы паспорт*/
            Passport passport = new Passport();
            passport.Show();
            военнослужащиеTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            /*Переход на форму авторизации*/
            Auth auth = new Auth();
            auth.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        { 
            /*Переход на следующую строку */
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView1.CurrentCell = dataGridView1[0, 0]; }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1];
            }
            pictureBoxPhoto.Image = Image.FromFile(label9.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //переход на предыдущую строку
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[index].Selected = true;
            if (index != 0)
            {
                dataGridView1.CurrentCell = dataGridView1[0, index - 1];
            }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, i - 1];
            }
            pictureBoxPhoto.Image = Image.FromFile(label9.Text);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //Добавление новой строки
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO   Военнослужащие(Фамилия,Имя,Отчество,Адрес_Проживания,картинка) VALUES('{textBoxFam.Text} ','{textBoxName.Text}','{textBoxName2.Text}','{textBoxAddress.Text}','{label9.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            военнослужащиеTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            //Уведомление о выполнении
            MessageBox.Show("Успешно добавлен");
        }



        private void button7_Click(object sender, EventArgs e)
        { 
            /*Удаление пользователя с возможность отмены и предупреждения*/
            DialogResult result= MessageBox.Show("Выберите один из вариантов","Сообщение",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) 
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter($"DELETE FROM  Военнослужащие  WHERE Код_военнослужащего = {labelSold2.Text}; ", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt); 
            }
            
            военнослужащиеTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
        }
        int k;
        private void button8_Click(object sender, EventArgs e)
        {
            /*открытие и закрытие таблиц*/
            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(890, 0);
                this.Width = 1233;
                buttonOpen.Text = "Закрыть";
                buttonPrev.Location = new Point(569, 409);
                buttonOpen.Location = new Point(684, 409);
                buttonNext.Location = new Point(842, 409);
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(15, 15);
                buttonPrev.Location = new Point(10, 495);
                buttonOpen.Location = new Point(123, 495);
                buttonNext.Location = new Point(283, 495);
                this.Width = 360;
                buttonOpen.Text = "Открыть";
                k = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
            /*Добавление картинки к пользователю*/
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"\\apetfs\ИСПП-5\Степурин_НС\Практика 3 курс\Проект\Новая папка";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    pictureBoxPhoto.Image = Image.FromFile(filePath);
                    label9.Text = filePath;
                }
            }


        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                if (dataGridView1.Rows[j].Cells[0].Value.ToString().Contains(textBoxSearch.Text))
                {
                    dataGridView1.Rows[j].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, j];
                    break;
                   
                }
            }
        }
    }
}
