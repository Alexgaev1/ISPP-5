using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_sql
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Electricity_tariff". При необходимости она может быть перемещена или удалена.
            this.electricity_tariffTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Electricity_tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Indicators". При необходимости она может быть перемещена или удалена.
            this.indicatorsTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Indicators);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Pay". При необходимости она может быть перемещена или удалена.
            this.payTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Pay);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Counter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Apartments". При необходимости она может быть перемещена или удалена.
            this.apartmentsTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Apartments);


        }



        private void button1_Click_1(object sender, EventArgs e)
        {
      

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
            searchInDataGridView(Flat.Text);


        }
        public void searchInDataGridView(string k)
        {
            /*Метод для поиска данных на datagridView*/

            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                dataGridView2.Rows[j].Selected = false;
                if (dataGridView2.Rows[j].Cells[3].Value != null)
                {
                    if (dataGridView2.Rows[j].Cells[3].Value.ToString().Contains(k))
                    {

                        dataGridView2.Rows[j].Selected = true;
                        dataGridView2.CurrentCell = dataGridView2[3, j];
                        break;
                    }
                }   
            }
            for (int j = 0; j < dataGridView3.RowCount; j++)
            {
               
                    if (dataGridView3.Rows[j].Cells[1].Value.ToString().Contains(counter.Text))
                    {

                        dataGridView3.Rows[j].Selected = true;
                        dataGridView3.CurrentCell = dataGridView3[1, j];
                        break;
                    }
                
            }

            for (int j = 0; j < dataGridView4.RowCount; j++)
            {
                dataGridView4.Rows[j].Selected = false;
                if (dataGridView4.Rows[j].Cells[0].Value != null)
                {
                    if (dataGridView4.Rows[j].Cells[0].Value.ToString().Contains(indi.Text))
                    {

                        dataGridView4.Rows[j].Selected = true;
                        dataGridView4.CurrentCell = dataGridView4[0, j];
                        break;
                    }
                }
            }

            for (int j = 0; j < dataGridView5.RowCount; j++)
            {
                dataGridView5.Rows[j].Selected = false;
                if (dataGridView4.Rows[j].Cells[0].Value != null)
                {
                    if (dataGridView5.Rows[j].Cells[0].Value.ToString().Contains(label14.Text))
                    {

                        dataGridView5.Rows[j].Selected = true;
                        dataGridView5.CurrentCell = dataGridView5[0, j];
                        break;
                    }
                }
            }

        }
            private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView1.CurrentCell = dataGridView1[0, 0]; }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1];
            }
            searchInDataGridView(Flat.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        int k;
        private void button3_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                dataGridView1.Visible = true;
                
                this.Width = 1000;
                button3.Text = "Закрыть";
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                
                this.Width = 320;
                button3.Text = "Открыть";
                k = 0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

       

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Flat_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
