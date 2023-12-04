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
using Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters;
using System.Reflection.Emit;

namespace Проект
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
    
        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности". При необходимости она может быть перемещена или удалена.
            this.удостверение_личностиTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Отделение". При необходимости она может быть перемещена или удалена.
            this.отделениеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Отделение);

        }

        private void buttonNext_Click(object sender, EventArgs e)
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

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            //переход на следущую строку в datagridView

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Добавление нового пользователя через запрос SQl

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Отделение(Код_удостверения,Код_взвода) VALUES('{textBoxPass.Text}','{textBoxPlat.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);

            //Перерисовка таблицы в datagridview

            отделениеTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Отделение);
            MessageBox.Show("Успешно добавлен");
        }

        private void buttonDel_Click(object sender, EventArgs e)
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
                if (dataGridView3.Rows[j].Cells[0].Value.ToString().Contains(labelSoldier2.Text))
                {
                    dataGridView3.Rows[j].Selected = true;
                    dataGridView3.CurrentCell = dataGridView3[0, j];
                    break;
                }
            }
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //Вызов метода для поиска данных
            searchInDataGridView(textBoxPass.Text);
        }
        int k = 0;
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //открытие формы и появление таблицы

            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(389, 13);
                this.Width = 712;
                buttonOpen.Text = "Закрыть";
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(12, 12);
                this.Width = 354;
                buttonOpen.Text = "Закрыть";
                k = 0;
            }
        }

        int l = 0;
        public void Com(int i)
        {
            l = i;
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //Вернуться на форму Взвод или Командира
            if (l==1) 
            {
                Commander commander = new Commander();
                commander.Show();
                this.Hide();
            } 
            else 
            {
                this.Hide();
            Platoon platoon = new Platoon();
            platoon.Show(); 
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
            /*Обновление таблицы данных*/
            
            отделениеTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            dataGridView1.CurrentCell = dataGridView1[0, 0];
        }

        private void buttonPassport_Click(object sender, EventArgs e)
        {
            //Переход на форму паспорт
            Passport passport = new Passport();
            passport.Show();
        }
    }
}
