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
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                dataGridView2.Rows[j].Selected = false;
                if (dataGridView2.Rows[j].Cells[0].Value != null)
                {
                    if (dataGridView2.Rows[j].Cells[0].Value.ToString().Contains(k))
                    {

                        dataGridView2.Rows[j].Selected = true;
                        dataGridView2.CurrentCell = dataGridView2[0, j];
                        break;
                    }
                }
            }
            for (int j = 0; j < dataGridView3.RowCount; j++)
            {
                dataGridView3.Rows[j].Selected = false;
                if (dataGridView3.Rows[j].Cells[0].Value != null)
                {
                    if (dataGridView3.Rows[j].Cells[0].Value.ToString().Contains(labelPass2.Text))
                    {

                        dataGridView3.Rows[j].Selected = true;
                        dataGridView3.CurrentCell = dataGridView3[0, j];
                        break;
                    }
                }
            }
            for (int j = 0; j < dataGridView4.RowCount; j++)
            {
                dataGridView4.Rows[j].Selected = false;
                if (dataGridView4.Rows[j].Cells[0].Value != null)
                {
                    if (dataGridView4.Rows[j].Cells[0].Value.ToString().Contains(labelSold2.Text))
                    {

                        dataGridView4.Rows[j].Selected = true;
                        dataGridView4.CurrentCell = dataGridView4[0, j];
                        break;
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchInDataGridView(textBoxCom.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchInDataGridView(textBoxCom2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
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
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO Взвод(Код_роты,Код_командира,Название,Код_Зам_командира) VALUES('{textBoxComp.Text}','{textBoxCom.Text}','{textBoxName.Text}','{textBoxCom2.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            взводTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Взвод);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"DELETE FROM  Взвод WHERE Код_взвода = {labelPlat2.Text}; ", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            взводTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Взвод);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            this.Hide();
            department.Show();
        }
        int k = 0;
        private void button8_Click(object sender, EventArgs e)
        {
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Company company = new Company();
            company.Show();
        }
    }
}
