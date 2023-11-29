using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Продавец : Form
    {
        public Продавец()
        {
            InitializeComponent();
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }
        public void Tub(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] so = new SqlDataAdapter[7];
            so[0] = new SqlDataAdapter("select * from Продажи", sqlConnect);
            so[1] = new SqlDataAdapter("select * from Покупатели", sqlConnect);
            so[2] = new SqlDataAdapter("select * from Оптовые_покупатели", sqlConnect);
            so[3] = new SqlDataAdapter("select * from Продавцы", sqlConnect);
            so[4] = new SqlDataAdapter("select * from Сорта_растений", sqlConnect);
            so[5] = new SqlDataAdapter("select * from Новые_сорта_растений", sqlConnect);
            so[6] = new SqlDataAdapter("select * from Упаковки_семян", sqlConnect);
            DataSet ps = new DataSet();
            so[i].Fill(ps);
            Поле_для_таблиц_DataGridView1.DataSource = ps.Tables[0];
        }
        int t;

        private void Продавец_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян". При необходимости она может быть перемещена или удалена.
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений". При необходимости она может быть перемещена или удалена.
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Продавцы". При необходимости она может быть перемещена или удалена.
            this.продавцыTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Продавцы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели". При необходимости она может быть перемещена или удалена.
            this.оптовые_покупателиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений". При необходимости она может быть перемещена или удалена.
            this.новые_сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений);

        }


        private void обновить_Click(object sender, EventArgs e)
        {
            switch (t)
            {
                case 0:
                    продажиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продажи);
                    продажиTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Продажи); break;

                case 1:
                    покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Покупатели);
                    покупателиTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Покупатели); break;

                case 2:
                    оптовые_покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели);
                    оптовые_покупателиTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели); break;

                case 3:
                    продавцыTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продавцы);
                    продавцыTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Продавцы); break;

                case 4:
                    сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);
                    сорта_растенийTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений); break;

                case 5:
                    новые_сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений);
                    новые_сорта_растенийTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений); break;

                case 6:
                    упаковки_семянTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
                    упаковки_семянTableAdapter.Fill(уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян); break;
            }
        }

        private void вернуться_Click(object sender, EventArgs e)
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void Таблица_Продажи_Click(object sender, EventArgs e)
        {
            Tub(0);
            t = 0;
            Поле_для_таблиц_DataGridView1.ReadOnly = false;
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Покупатели_Click(object sender, EventArgs e)
        {
            Tub(1);
            t = 1;
            Поле_для_таблиц_DataGridView1.ReadOnly = false;
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Оптовые_покупатели_Click(object sender, EventArgs e)
        {
            Tub(2);
            t = 2;
            Поле_для_таблиц_DataGridView1.ReadOnly = false;
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Продавцы_Click(object sender, EventArgs e)
        {
            Tub(3);
            t = 3;
            Поле_для_таблиц_DataGridView1.ReadOnly = true;
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Сорта_растений_Click(object sender, EventArgs e)
        {
            Tub(4);
            t = 4;
            Поле_для_таблиц_DataGridView1.ReadOnly = true;
            Фотография_представителя_PictureBox2.Visible = true;
            Поле_для_таблиц_DataGridView1.Size = new Size(598, 301);
        }

        private void Таблица_Новые_сорта_растений_Click(object sender, EventArgs e)
        {
            Tub(5);
            t = 5;
            Поле_для_таблиц_DataGridView1.ReadOnly = true;
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Таблица_Упаковки_семян_Click(object sender, EventArgs e)
        {
            Tub(6);
            t = 6;
            Поле_для_таблиц_DataGridView1.ReadOnly = true;
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Поисковая_строка_TextChanged(object sender, EventArgs e)
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
        Point Mouse;
        private void Продавец_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Продавец_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = new Point(e.X, e.Y);
        }

        private void выйти_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string pic;
        private void Поле_для_таблиц_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pic = Поле_для_таблиц_DataGridView1.Rows[Поле_для_таблиц_DataGridView1.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
                Фотография_представителя_PictureBox2.Image = Image.FromFile(pic);
            }
            catch { }
        }
    }
}
