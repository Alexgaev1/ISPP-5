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
    public partial class Admin : Form
    {
        int k = 0;
        public Admin()
        {
            InitializeComponent();
        }
    
        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности". При необходимости она может быть перемещена или удалена.
            this.удостверение_личностиTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Рота". При необходимости она может быть перемещена или удалена.
            this.ротаTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Рота);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Отделение". При необходимости она может быть перемещена или удалена.
            this.отделениеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Отделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры". При необходимости она может быть перемещена или удалена.
            this.командирыTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Взвод". При необходимости она может быть перемещена или удалена.
            this.взводTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Взвод);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Батальон". При необходимости она может быть перемещена или удалена.
            this.батальонTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Батальон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Auth". При необходимости она может быть перемещена или удалена.
            this.authTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Auth);

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            //Переход на следущую строку в datagridview

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

            //Вывод права доступа в комбобокс

            comboBoxRule.Text = label4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
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
            //Вывод права доступа в комбобокс
            comboBoxRule.Text = label4.Text;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Добавление нового пользователя через запрос SQl

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Auth([Password],[Rule]) VALUES('{textBoxPass.Text}','{comboBoxRule.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Успешно добавлен");
            //Перерисовка таблицы в datagridview

            authTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Auth);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //Удаление пользователя через SQl запрос
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) 
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"DELETE FROM  Auth WHERE Login = {textBoxLog.Text}; ", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            }
                

            //Перерисовка таблицы в datagridview

            authTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Auth);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //Возвражение к окну авторизации

            this.Hide();
            Auth auth = new Auth();
            auth.Show();
            authTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            authTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Auth);
        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Заполнение данными из комбобокса в Таблицу

            label4.Text = comboBoxRule.Text;

            //Обновление таблиц
            authTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            военнослужащиеTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            командирыTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            взводTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            батальонTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            ротаTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            отделениеTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            удостверение_личностиTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
           

        }
       
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //открытие формы и появление таблицы

            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(383, 11);
                this.Width = 733;
                buttonOpen.Text = "Закрыть";
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(11, 11);
                this.Width = 354;
                buttonOpen.Text = "Открыть";
                k = 0;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //Переход на выбранную таблицу в комбобоксе

            switch (comboBoxChange.Text)
            {
                case "Солдаты":
                    dataGridView1.DataSource = военнослужащиеBindingSource;
                    textBoxPass.Visible = false;
                    textBoxLog.Visible = false;
                    Login.Visible = false;
                    PasswordLab.Visible = false;
                    RuleLab.Visible = false;
                    label4.Visible = false;
                    comboBoxRule.Visible = false;
                    break;
                case "Паспорт":
                    dataGridView1.DataSource = удостверениеличностиBindingSource;
                    textBoxPass.Visible = false;
                    textBoxLog.Visible = false;
                    Login.Visible = false;
                    PasswordLab.Visible = false;
                    RuleLab.Visible = false;
                    label4.Visible = false;
                    comboBoxRule.Visible = false;
                    break;
                case "Командиры":
                    dataGridView1.DataSource = командирыBindingSource;
                    textBoxPass.Visible = false;
                    textBoxLog.Visible = false;
                    Login.Visible = false;
                    PasswordLab.Visible = false;
                    RuleLab.Visible = false;
                    label4.Visible = false;
                    comboBoxRule.Visible = false;
                    break;
                case "Батальон":
                    dataGridView1.DataSource = батальонBindingSource;
                    textBoxPass.Visible = false;
                    textBoxLog.Visible = false;
                    Login.Visible = false;
                    PasswordLab.Visible = false;
                    RuleLab.Visible = false;
                    label4.Visible = false;
                    comboBoxRule.Visible = false;
                    break;
                case "Рота":
                    dataGridView1.DataSource = ротаBindingSource;
                    textBoxPass.Visible = false;
                    textBoxLog.Visible = false;
                    Login.Visible = false;
                    PasswordLab.Visible = false;
                    RuleLab.Visible = false;
                    label4.Visible = false;
                    comboBoxRule.Visible = false;
                    break;
                case "Взвод":
                    dataGridView1.DataSource = взводBindingSource;
                    textBoxPass.Visible = false;
                    textBoxLog.Visible = false;
                    Login.Visible = false;
                    PasswordLab.Visible = false;
                    RuleLab.Visible = false;
                    label4.Visible = false;
                    comboBoxRule.Visible = false;
                    break;
                case "Отделение":
                    dataGridView1.DataSource = отделениеBindingSource;
                    textBoxPass.Visible = false;
                    textBoxLog.Visible = false;
                    Login.Visible = false;
                    PasswordLab.Visible = false;
                    RuleLab.Visible = false;
                    label4.Visible = false;
                    comboBoxRule.Visible = false;
                    break;
                case "Авторизация":
                    textBoxPass.Visible = true;
                    textBoxLog.Visible = true;
                    Login.Visible = true;
                    PasswordLab.Visible = true;
                    comboBoxRule.Visible = true;
                    RuleLab.Visible = true;
                    label4.Visible = true;

                    dataGridView1.DataSource = authBindingSource;
                    break;
            }

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            //Поиск по Таблице 
            

            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                dataGridView1.Rows[j].Selected = false;
                if (dataGridView1.Rows[j].Cells[0].Value != null)
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
}
