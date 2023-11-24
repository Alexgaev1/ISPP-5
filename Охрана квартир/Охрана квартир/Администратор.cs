using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Охрана_квартир
{
    public partial class Администратор : Form
    {
        public Администратор()
        {
            InitializeComponent();
        }
         
        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet.Settlement". При необходимости она может быть перемещена или удалена.
            this.settlementTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet.Settlement);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet.Prolonging". При необходимости она может быть перемещена или удалена.
            this.prolongingTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet.Prolonging);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet.House". При необходимости она может быть перемещена или удалена.
            this.houseTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet.House);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet._Flat_House". При необходимости она может быть перемещена или удалена.
            this.flat_HouseTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet._Flat_House);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet.Flat". При необходимости она может быть перемещена или удалена.
            this.flatTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet.Flat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet.Contract);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet.Client);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet.User);
            ToolTip tt = new ToolTip();
            tt.SetToolTip(textBox1, "Введите значение, которое хотите найти в таблице") ;
            //dataGridView1.AllowUserToAddRows = false;
        }
        public int i;
        public void table (int i)
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП_ПМ_01_Неверов_ДС; Integrated Security = True"))
            {
                switch (i)
                {
                    case 0:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 1:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 2:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 3:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 4:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 5:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 6:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 7:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 8:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 9:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 10:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 11:
                        dataGridView1.DataSource = userBindingSource;
                        break;
                    case 12:
                        dataGridView1.DataSource = userBindingSource;
                        break;

                }
            }

        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Авторизация ав = new Авторизация();
            Hide();
            ав.Show();
        }

        private void выйтиИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if (index>=(i-1))
            {
               dataGridView1.CurrentCell = dataGridView1[0, 0];
            }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1];
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 0;
            table(i);
        }

        private void формаГостяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Регистрация us = new Регистрация();
            us.Show();
        }

        private void формаКомандираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Командир com = new Командир();
            com.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void houseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flatHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settlementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prolongingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void captureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void compensationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
