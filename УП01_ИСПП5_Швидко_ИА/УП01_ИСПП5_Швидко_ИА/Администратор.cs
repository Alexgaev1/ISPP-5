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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Администратор : Form
    {
        public Администратор()
        {
            InitializeComponent();
            Фотография_представителя_PictureBox2.Visible = false;
            Найти_фото_roundBtn2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        public void tab(int i)             //Добавляет таблицы
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();

            switch (i)
            {
                case 0: Поле_для_таблиц_DataGridView1.DataSource = продажиBindingSource; break;
                case 1: Поле_для_таблиц_DataGridView1.DataSource = покупателиBindingSource; break;
                case 2: Поле_для_таблиц_DataGridView1.DataSource = оптовыепокупателиBindingSource; break;
                case 3: Поле_для_таблиц_DataGridView1.DataSource = продавцыBindingSource; break;
                case 4: Поле_для_таблиц_DataGridView1.DataSource = сортарастенийBindingSource; break;
                case 5: Поле_для_таблиц_DataGridView1.DataSource = новыесортарастенийBindingSource; break;
                case 6: Поле_для_таблиц_DataGridView1.DataSource = упаковкисемянBindingSource; break;
                case 7: Поле_для_таблиц_DataGridView1.DataSource = пользователиBindingSource; break;
            }
        }
        int c;
        private void вернуться_Click(object sender, EventArgs e)        //Переходит на форму 'Авторизация'
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void обновить_Click(object sender, EventArgs e)        //Обновляет и сохраняет изменениям в таблицах
        {
            switch (c)
            {
                case 0: продажиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продажи);
                        продажиTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Продажи); break;

                case 1: покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Покупатели); 
                        покупателиTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Покупатели); break;

                case 2: оптовые_покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели); 
                        оптовые_покупателиTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели); break;

                case 3: продавцыTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продавцы); 
                        продавцыTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Продавцы); break;

                case 4: сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений); 
                        сорта_растенийTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений); break;

                case 5: новые_сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений); 
                        новые_сорта_растенийTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений); break;

                case 6: упаковки_семянTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян); 
                        упаковки_семянTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян); break;

                case 7: пользователиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Пользователи); 
                        пользователиTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Пользователи); break;
            }
        }

        private void выйти_Click(object sender, EventArgs e)                    //Прекращает работу программы
        {
            Application.Exit();
        }

        private void Таблица_Продажи_Click(object sender, EventArgs e)                   //Открывает таблицу 'Продажи'
        {
            tab(0);
            c = 0;
            Фотография_представителя_PictureBox2.Visible = false;
            Найти_фото_roundBtn2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Покупатели_Click(object sender, EventArgs e)                   //Открывает таблицу 'Покупатели'
        {
            tab(1);
            c = 1;
            Фотография_представителя_PictureBox2.Visible = false;
            Найти_фото_roundBtn2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Оптовые_покупатели_Click(object sender, EventArgs e)                   //Открывает таблицу 'Оптовые покупатели'
        {
            tab(2);
            c = 2;
            Фотография_представителя_PictureBox2.Visible = false;
            Найти_фото_roundBtn2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Продавцы_Click(object sender, EventArgs e)                   //Открывает таблицу 'Продавцы'
        {
            tab(3);
            c = 3;
            Фотография_представителя_PictureBox2.Visible = false;
            Найти_фото_roundBtn2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Сорта_растений_Click(object sender, EventArgs e)                   //Открывает таблицу 'Сорта растени'
        {
            tab(4);
            c = 4;
            Фотография_представителя_PictureBox2.Visible = true;
            Найти_фото_roundBtn2.Visible = true;
            Поле_для_таблиц_DataGridView1.Size = new Size(598, 301);
        }

        private void Таблица_Новые_сорта_растений_Click(object sender, EventArgs e)                   //Открывает таблицу 'Новые сорта растений'
        {
            tab(5);
            c = 5;
            Фотография_представителя_PictureBox2.Visible = false;
            Найти_фото_roundBtn2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Упаковки_семян_Click(object sender, EventArgs e)                   //Открывает таблицу 'Упаковки семян'
        {
            tab(6);
            c = 6;
            Фотография_представителя_PictureBox2.Visible = false;
            Найти_фото_roundBtn2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Пользователи_Click(object sender, EventArgs e)                   //Открывает таблицу 'Пользователи'
        {
            tab(7);
            c = 7;
            Фотография_представителя_PictureBox2.Visible = false;
            Найти_фото_roundBtn2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Поисковая_строка_TextChanged(object sender, EventArgs e)               //Выделение строки, которая подходит под введённые данные в поисковую строку
        {
            for (int i = 0; i < Поле_для_таблиц_DataGridView1.RowCount; i++)
            {
                Поле_для_таблиц_DataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < Поле_для_таблиц_DataGridView1.ColumnCount; j++)
                    if (Поле_для_таблиц_DataGridView1.Rows[i].Cells[j].Value != null)
                        if (Поле_для_таблиц_DataGridView1.Rows[i].Cells[j].Value.ToString().Contains(Строка_поиска_TextBox1.Text))
                        {
                            Поле_для_таблиц_DataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        string pic;
        private void Найти_фото_Click(object sender, EventArgs e)            //Открытие окна, для поиска и добавление фотографий
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source = sql; Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == DialogResult.OK)
            {
                Фотография_представителя_PictureBox2.ImageLocation = load.FileName;
                SqlDataAdapter a = new SqlDataAdapter($"Update Сорта_растений set Фотография = '{load.FileName}' where Код_сорта_растения = '{Поле_для_таблиц_DataGridView1.Rows[Поле_для_таблиц_DataGridView1.SelectedCells[0].RowIndex].Cells[0].Value}'", sqlConnect);
                DataSet dt = new DataSet();
                a.Fill(dt);
            }
        }
        private void Поле_для_таблиц_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)       //Изменение фотографий при нажатие на разные строки
        {
            try
            {
                pic = Поле_для_таблиц_DataGridView1.Rows[Поле_для_таблиц_DataGridView1.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
                Фотография_представителя_PictureBox2.Image = Image.FromFile(pic);
            }
            catch { }
        }
        Point Mouse;

        private void Администратор_MouseMove(object sender, MouseEventArgs e)        //Перемещает форму при удержании мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Администратор_MouseDown(object sender, MouseEventArgs e)        //Перемещает форму при удержании мыши
        {
            Mouse = new Point(e.X, e.Y);
        }

        private void Администратор_Load(object sender, EventArgs e)        //Загрузка данных в таблицы
        {
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            this.продажиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продажи);
            this.продавцыTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продавцы);
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Пользователи);
            this.покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Покупатели);
            this.оптовые_покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели);
            this.новые_сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений);
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);
        }
    }
}
