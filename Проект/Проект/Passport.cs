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
    public partial class Passport : Form
    {
        public Passport()
        {
            InitializeComponent();
        }

        private void Passport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности". При необходимости она может быть перемещена или удалена.
            this.удостверение_личностиTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
            dataGridView1.AllowUserToAddRows = false;

        }




        private void button1_Click(object sender, EventArgs e)
        {
            
             label13.Text=comboBoxTypServ.Text;
             label14.Text=comboBoxTitle.Text;



        }
        public void searchInDataGridView()
        {
           for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                dataGridView2.Rows[j].Selected = false;
                if (dataGridView2.Rows[j].Cells[0].Value != null)
                {
                    if (dataGridView2.Rows[j].Cells[0].Value.ToString().Contains(textBoxSoldier.Text))
                    { 

                        dataGridView2.Rows[j].Selected = true;
                        dataGridView2.CurrentCell = dataGridView2[0, j];
                        break;
                    }
                }
            } 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            удостверение_личностиTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            this.Hide();
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
            searchInDataGridView();
            comboBoxTypServ.Text = label13.Text;
            comboBoxTitle.Text = label14.Text;
        }

        private void button4_Click(object sender, EventArgs e)
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
            searchInDataGridView();
            comboBoxTypServ.Text = label13.Text;
            comboBoxTitle.Text = label14.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"DELETE FROM  Удостверение_личности  WHERE Код_Удовстверения = {labelPass2.Text}; ", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            удостверение_личностиTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO   Удостверение_личности(Должность,Звание_военнослужащего,Вид_службы) VALUES('{textBoxPost.Text} ','{comboBoxTitle.Text }','{ comboBoxTypServ.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            удостверение_личностиTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Commander commander = new Commander();
            commander.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        int k = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(910, 13);
                this.Width = 1390;
                buttonOpen.Text = "Закрыть";
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(13, 13);
                this.Width = 483;
                buttonOpen.Text = "Открыть";
                k = 0;
            }
        }
    }
}
