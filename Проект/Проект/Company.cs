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

namespace Проект
{
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности". При необходимости она может быть перемещена или удалена.
            this.удостверение_личностиTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры". При необходимости она может быть перемещена или удалена.
            this.командирыTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Рота". При необходимости она может быть перемещена или удалена.
            this.ротаTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Рота);

        }
        public void searchInDataGridView(string k)
        {
            /*Метод для поиска данных на datagridView*/

            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (dataGridView2.Rows[j].Cells[0].Value.ToString().Contains(k))
                {
                    dataGridView2.Rows[j].Selected = true;
                    dataGridView2.CurrentCell = dataGridView2[0, j];
                    break;
                }  
            }
            for (int j = 0; j < dataGridView3.RowCount; j++)
            {
                if (dataGridView3.Rows[j].Cells[0].Value.ToString().Contains(labelPass2.Text))
                {
                    dataGridView3.Rows[j].Selected = true;
                    dataGridView3.CurrentCell = dataGridView3[0, j];
                    break;
                }
            }
            for (int j = 0; j < dataGridView4.RowCount; j++)
            {
                if (dataGridView4.Rows[j].Cells[0].Value.ToString().Contains(labelSoldier2.Text))
                {
                    dataGridView4.Rows[j].Selected = true;
                    dataGridView4.CurrentCell = dataGridView4[0, j];
                    break;
                }  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Вызов метода для поиска данных

            searchInDataGridView(textBoxCom.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Вызов метода для поиска данных

            searchInDataGridView(textBoxCom2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //переход на следущую строку в datagridView

            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView1.CurrentCell = dataGridView1[0, 0]; }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //переход на предыдущую строку в datagridView

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
            //Добавление нового пользователя через запрос SQl

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Рота(Код_командира,Название_роты,Код_Зам_командира) VALUES('{textBoxCom.Text}','{textBoxName.Text}','{textBoxCom2.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);

            //Перерисовка таблицы в datagridview

            ротаTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Рота);
            MessageBox.Show("Успешно добавлен");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Удаление пользователя 
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) 
            { 
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1.Rows[j].Cells[0].Value.ToString().Contains(label6.Text))
                    {
                        dataGridView1.Rows[j].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[0, j];
                        dataGridView1.Rows.RemoveAt(j);
                        break;
                    }
                }
            }   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Переход на форму звода

            this.Hide();
            Platoon platoon = new Platoon();
            platoon.Show();
        }
        int k = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            //открытие формы и появление таблицы

            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(573, 13);
                this.Width = 1016;
                buttonOpen.Text = "Закрыть";
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(12, 12);
                this.Width = 458;
                buttonOpen.Text = "Открыть";
                k = 0;
            }
        }
        int l=0;
        public void Com(int i) 
        {
             l = i;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //Вернуться на форму Батальона или Командира
            if (l == 1)
            {
                this.Hide();
                Commander commander = new Commander();
                commander.Show();
            }
            else 
            {
                this.Hide();
                Battalion battalion = new Battalion();
                battalion.Show(); 
            }
            
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            //Поиск по таблице

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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Обновление данных
            ротаTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            dataGridView1.CurrentCell = dataGridView1[0, 0];
        }
    }
}
