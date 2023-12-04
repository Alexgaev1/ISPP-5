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
    public partial class Platoon : Form
    {
        public Platoon()
        {
            InitializeComponent();
        }
    

        private void Platoon_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности". При необходимости она может быть перемещена или удалена.
            this.удостверение_личностиTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры". При необходимости она может быть перемещена или удалена.
            this.командирыTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Взвод". При необходимости она может быть перемещена или удалена.
            this.взводTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Взвод);
            
            
        }
        public void searchInDataGridView(string k)
        {
            //Метод для поиска в datagridview

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
                if (dataGridView4.Rows[j].Cells[0].Value.ToString().Contains(labelSold2.Text))
                {
                    dataGridView4.Rows[j].Selected = true;
                    dataGridView4.CurrentCell = dataGridView4[0, j];
                    break;
                    
                }
            }
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            //Вызов метода для поиска
            searchInDataGridView(textBoxCom.Text);
        }

        private void buttonCheck2_Click(object sender, EventArgs e)
        {
            //Вызов метода для поиска
            searchInDataGridView(textBoxCom2.Text);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //Переход на следующую строку
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
            /*переход на прошлую строку*/
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
            //Добавление новой строки в базу данных
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Взвод(Код_роты,Код_командира,Название,Код_Зам_командира) VALUES('{textBoxComp.Text}','{textBoxCom.Text}','{textBoxName.Text}','{textBoxCom2.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            взводTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Взвод);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //Удаление пользователя 
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) 
            {
            for (int j = 0; j < dataGridView1.RowCount; j++)
              {
                if (dataGridView1.Rows[j].Cells[0].Value.ToString().Contains(labelPlat2.Text))
                 {

                    dataGridView1.Rows[j].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, j];
                    dataGridView1.Rows.RemoveAt(j);
                    break;
                    }
               }
            }        
        }

        private void buttonDepart_Click(object sender, EventArgs e)
        {
            //    Переход на форму отделения
            Department department = new Department();
            this.Hide();
            department.Show();
        }
        int k = 0;
        private void buttonOpen_Click(object sender, EventArgs e)
        { /*Открыть или закрыть на форме таблицу*/
            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(584, 2);
                this.Width = 950;
                buttonOpen.Text = "Закрыть";
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(2, 2);
                this.Width =370;
                buttonOpen.Text = "Открыть";
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
            /*переход на форму командира или Роты*/
            if (l == 1)
            {
                Commander commander = new Commander();
                commander.Show();
                this.Hide();
            }
            else 
            {
                this.Hide();
                Company company = new Company();
                company.Show();
            }    
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {/* поиск по таблице*/
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
            /*Обновление таблицы*/
            взводTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            dataGridView1.CurrentCell = dataGridView1[0, 0];
        }
    }
}
