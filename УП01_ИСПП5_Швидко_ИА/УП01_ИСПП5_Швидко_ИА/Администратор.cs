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

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Администратор : Form
    {
        public Администратор()
        {
            InitializeComponent();
        }
        public void tab(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            switch (i)
            {
                case 0: dataGridView1.DataSource = продажиBindingSource; break;
                case 1: dataGridView1.DataSource = покупателиBindingSource; break;
                case 2: dataGridView1.DataSource = оптовыепокупателиBindingSource; break;
                case 3: dataGridView1.DataSource = продавцыBindingSource; break;
                case 4: dataGridView1.DataSource = сортарастенийBindingSource; break;
                case 5: dataGridView1.DataSource = новыесортарастенийBindingSource; break;
                case 6: dataGridView1.DataSource = упаковкисемянBindingSource; break;
                case 7: dataGridView1.DataSource = пользователиBindingSource; break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet1.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet1.Пользователи);
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

        int c;
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case 0: продажиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продажи); break;

                case 1: покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Покупатели); break;

                case 2: оптовые_покупателиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Оптовые_покупатели); break;

                case 3: продавцыTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Продавцы); break;

                case 4: сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений); break;

                case 5: новые_сорта_растенийTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Новые_сорта_растений); break;

                case 6: упаковки_семянTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян); break;

                case 7: пользователиTableAdapter.Update(уП01_ИСПП5_Швидко_ИАDataSet1.Пользователи); break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            tab(0);
            c = 0;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tab(1);
            c = 1;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            tab(2);
            c = 2;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            tab(3);
            c = 3;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            tab(4);
            c = 4;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            tab(5);
            c = 5;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            tab(6);
            c = 6;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            tab(7);
            c = 7;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
