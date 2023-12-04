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

namespace Практика_sql
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Electricity_tariff". При необходимости она может быть перемещена или удалена.
            this.electricity_tariffTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Electricity_tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Indicators". При необходимости она может быть перемещена или удалена.
            this.indicatorsTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Indicators);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Pay". При необходимости она может быть перемещена или удалена.
            this.payTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Pay);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Counter". При необходимости она может быть перемещена или удалена.
            this.counterTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Counter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Building". При необходимости она может быть перемещена или удалена.
            this.buildingTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Building);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Apartments". При необходимости она может быть перемещена или удалена.
            this.apartmentsTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Apartments);

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();

        }

        private void tenatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        private void tabPage1_Click_1(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView1.CurrentCell = dataGridView1[0, 0]; }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = dataGridView2.RowCount;
            int index = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows[index].Selected = true;
            if (index != 0)
            {
                dataGridView2.CurrentCell = dataGridView2[0, index - 1];
            }
            else
            {
                dataGridView2.Rows[index].Selected = true;
                dataGridView2.CurrentCell = dataGridView2[0, i - 1];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = dataGridView2.RowCount;
            int index = dataGridView2.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView2.CurrentCell = dataGridView2[0, 0]; }
            else
            {
                dataGridView2.Rows[index].Selected = true;
                dataGridView2.CurrentCell = dataGridView2[0, index + 1];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = dataGridView3.RowCount;
            int index = dataGridView3.CurrentRow.Index;
            dataGridView3.Rows[index].Selected = true;
            if (index != 0)
            {
                dataGridView3.CurrentCell = dataGridView3[0, index - 1];
            }
            else
            {
                dataGridView3.Rows[index].Selected = true;
                dataGridView3.CurrentCell = dataGridView3[0, i - 1];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i = dataGridView3.RowCount;
            int index = dataGridView3.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView3.CurrentCell = dataGridView3[0, 0]; }
            else
            {
                dataGridView3.Rows[index].Selected = true;
                dataGridView3.CurrentCell = dataGridView3[0, index + 1];
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int i = dataGridView6.RowCount;
            int index = dataGridView6.CurrentRow.Index;
            dataGridView6.Rows[index].Selected = true;
            if (index != 0)
            {
                dataGridView6.CurrentCell = dataGridView6[0, index - 1];
            }
            else
            {
                dataGridView6.Rows[index].Selected = true;
                dataGridView6.CurrentCell = dataGridView6[0, i - 1];
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int i = dataGridView6.RowCount;
            int index = dataGridView6.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView6.CurrentCell = dataGridView6[0, 0]; }
            else
            {
                dataGridView6.Rows[index].Selected = true;
                dataGridView6.CurrentCell = dataGridView6[0, index + 1];
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int i = dataGridView5.RowCount;
            int index = dataGridView5.CurrentRow.Index;
            dataGridView5.Rows[index].Selected = true;
            if (index != 0)
            {
                dataGridView5.CurrentCell = dataGridView5[0, index - 1];
            }
            else
            {
                dataGridView5.Rows[index].Selected = true;
                dataGridView5.CurrentCell = dataGridView5[0, i - 1];
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int i = dataGridView5.RowCount;
            int index = dataGridView5.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView5.CurrentCell = dataGridView5[0, 0]; }
            else
            {
                dataGridView5.Rows[index].Selected = true;
                dataGridView5.CurrentCell = dataGridView5[0, index + 1];
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i = dataGridView4.RowCount;
            int index = dataGridView4.CurrentRow.Index;
            dataGridView4.Rows[index].Selected = true;
            if (index != 0)
            {
                dataGridView4.CurrentCell = dataGridView4[0, index - 1];
            }
            else
            {
                dataGridView4.Rows[index].Selected = true;
                dataGridView4.CurrentCell = dataGridView4[0, i - 1];
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int i = dataGridView4.RowCount;
            int index = dataGridView4.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView4.CurrentCell = dataGridView4[0, 0]; }
            else
            {
                dataGridView4.Rows[index].Selected = true;
                dataGridView4.CurrentCell = dataGridView4[0, index + 1];
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 check = new Form1();
            check.Show();
            Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            apartmentsTableAdapter.Update(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buildingTableAdapter.Update(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            counterTableAdapter.Fill(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Counter);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            payTableAdapter.Fill(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Pay);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            electricity_tariffTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Electricity_tariff);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            indicatorsTableAdapter.Fill(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Indicators);
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            //Добавление нового пользователя через запрос SQl

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Буйлов_МА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Apartments(Flat,FlatType,People,EStove,Building_number,Lastname,ForstName,Patronymic,Passport) VALUES('{textBox1.Text}','{textBox4.Text}','{textBox2.Text}','{textBox9.Text}','{textBox17.Text}','{textBox3.Text}','{textBox11.Text}','{textBox10.Text}','{textBox8.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);


            //Перерисовка таблицы в datagridview

            apartmentsTableAdapter.Fill(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Apartments);
            MessageBox.Show("Успешно добавлен");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //Удаление пользователя
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1.Rows[j].Cells[0].Value.ToString().Contains(label2.Text))
                    {
                        dataGridView1.Rows[j].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[0, j];
                        dataGridView1.Rows.RemoveAt(j);
                        break;
                    }
                }
            }
           
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //Добавление нового пользователя через запрос SQl

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Буйлов_МА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Building (Address,District,Material,Doorway,Flats,Floor,Owner) VALUES('{textBox16.Text}','{textBox13.Text}','{textBox14.Text}','{textBox15.Text}','{textBox7.Text}','{textBox5.Text}','{textBox6.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);


            //Перерисовка таблицы в datagridview

            buildingTableAdapter.Fill(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Building);
            MessageBox.Show("Успешно добавлен");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //Удаление пользователя
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {
                    if (dataGridView2.Rows[j].Cells[0].Value.ToString().Contains(label23.Text))
                    {
                        dataGridView2.Rows[j].Selected = true;
                        dataGridView2.CurrentCell = dataGridView2[0, j];
                        dataGridView2.Rows.RemoveAt(j);
                        break;
                    }
                }
            }
          
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //Добавление нового пользователя через запрос SQl

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Буйлов_МА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Counter (Type,Factor,Flat) VALUES('{textBox23.Text}','{textBox21.Text}','{textBox12.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);


            //Перерисовка таблицы в datagridview

            counterTableAdapter.Fill(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Counter);
            MessageBox.Show("Успешно добавлен");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //Удаление пользователя
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                for (int j = 0; j < dataGridView3.RowCount; j++)
                {
                    if (dataGridView3.Rows[j].Cells[0].Value.ToString().Contains(label32.Text))
                    {
                        dataGridView3.Rows[j].Selected = true;
                        dataGridView3.CurrentCell = dataGridView3[0, j];
                        dataGridView3.Rows.RemoveAt(j);
                        break;
                    }
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //Добавление нового пользователя через запрос SQl

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Буйлов_МА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Electricity_tariff (Month,Price_per_month) VALUES('{textBox20.Text}','{textBox19.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);


            //Перерисовка таблицы в datagridview

            electricity_tariffTableAdapter.Fill(уП_ПМ01_ИСПП_5_Буйлов_МАDataSet.Electricity_tariff);
            MessageBox.Show("Успешно добавлен");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //Удаление пользователя
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                for (int j = 0; j < dataGridView6.RowCount; j++)
                {
                    if (dataGridView6.Rows[j].Cells[0].Value.ToString().Contains(label25.Text))
                    {
                        dataGridView6.Rows[j].Selected = true;
                        dataGridView6.CurrentCell = dataGridView6[0, j];
                        dataGridView6.Rows.RemoveAt(j);
                        break;
                    }
                }
            }
        }
    }
}
