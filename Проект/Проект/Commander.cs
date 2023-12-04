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
    public partial class Commander : Form
    {
        public Commander()
        {
            InitializeComponent();
        }
    
        private void Commander_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности". При необходимости она может быть перемещена или удалена.
            this.удостверение_личностиTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры". При необходимости она может быть перемещена или удалена.
            this.командирыTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры);
            dataGridView1.AllowUserToAddRows = false;
            pictureBoxPhoto.Image = Image.FromFile(label9.Text);
        }
        public void searchInDataGridView()
        {
            /*Метод для поиска данных на datagridView*/

            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (dataGridView2.Rows[j].Cells[0].Value.ToString().Contains(textBoxPass.Text))
                {
                    dataGridView2.Rows[j].Selected = true;
                    dataGridView2.CurrentCell = dataGridView2[0, j];
                    break;
                }    
            }
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (dataGridView3.Rows[j].Cells[0].Value.ToString().Contains(label5.Text))
                {
                    dataGridView3.Rows[j].Selected = true;
                    dataGridView3.CurrentCell = dataGridView3[0, j];
                    break;
                }
            }
            
            //Появление фото из таблицы

            pictureBoxPhoto.Image = Image.FromFile(label9.Text);
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //Вызов метода для поиска данных

            searchInDataGridView();

            //Обновление Данных в таблице

            командирыTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
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

            //Вызов метода для поиска данных

            searchInDataGridView();

           
        }
        
        private void buttonPrev_Click(object sender, EventArgs e)
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
            //Вызов метода для поиска данных
            searchInDataGridView();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //Удаление пользователя 
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) 
            { 
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1.Rows[j].Cells[0].Value.ToString().Contains(label4.Text))
                    {
                        dataGridView1.Rows[j].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[0, j];
                        dataGridView1.Rows.RemoveAt(j);
                        break;
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Добавление нового пользователя через запрос SQl

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO   Командиры(Код_удовстверения) VALUES({textBoxPass.Text});", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Перерисовка таблицы в datagridview
            командирыTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры);
            //Уведомление пользователя о выполнении команды
            MessageBox.Show("Успешно добавлен");
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            //Открытие формы удостверение

            Passport passport = new Passport();
            passport.Show();
        }

        private void buttonBat_Click(object sender, EventArgs e)
        {
            //открытие формы Батальон

            Battalion battalion = new Battalion();
            battalion.Show();
            this.Hide();
        }
        int k=0; 
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //открытие формы и появление таблицы

            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(278, 13);
                this.Width = 656;
                buttonOpen.Text = "Закрыть";
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(12, 12);
                this.Width = 383;
                buttonOpen.Text = "Открыть";
                k = 0;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //Вернуться на форму авторизации

            Auth auth = new Auth();
            auth.Show();
            this.Hide();
        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            //Выбор и переход по другим формам
            switch (comboBoxTable.Text)
            {
                case "Батальон":
                    Battalion battalion = new Battalion();
                    battalion.Show();
                    this.Hide();
                    break;
                case "Рота":
                    Company company = new Company();
                    company.Show();
                    company.Com(1);
                    this.Hide();
                    break;
                case "Взвод":
                    Platoon platoon = new Platoon();
                    platoon.Show();
                    platoon.Com(1);
                    this.Hide();
                    break;
                case "Отделение":
                    Department department = new Department();
                    department.Show();
                    department.Com(1);
                    this.Hide();
                    break;
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Обновление таблицы 
            командирыTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            //Возвращение к 1 строке
            dataGridView1.CurrentCell = dataGridView1[0, 0];
        }
    }
}
