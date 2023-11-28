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
    public partial class Soldier : Form
    {
        public Soldier()
        {
            InitializeComponent();
        }

        private void soldier_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            dataGridView1.AllowUserToAddRows = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            военнослужащиеTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passport passport = new Passport();
            passport.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button4_Click(object sender, EventArgs e)
        { int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if ((i-1) <= index) { dataGridView1.CurrentCell = dataGridView1[0, 0]; }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1]; 
            } 
        }

        private void button5_Click(object sender, EventArgs e)
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
                dataGridView1.CurrentCell = dataGridView1[0, i-1];
            }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {


            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO   Военнослужащие(Фамилия,Имя,Отчество) VALUES('{textBox1.Text} ','{textBox2.Text }','{ textBox3.Text}');", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            военнослужащиеTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
        }


        
        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"DELETE FROM  Военнослужащие  WHERE Код_военнослужащего = {label8.Text}; ", sqlConnect); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            военнослужащиеTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int k;
        private void button8_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(890, 0);      
                this.Width = 1233;
               
                button5.Location = new Point(569, 409);
                button8.Location = new Point(684, 419);
                button4.Location = new Point(842, 409);
                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(15, 15);
                button5.Location = new Point(15, 467);
                button8.Location = new Point(128, 477);
                button4.Location = new Point(286, 467);  
                this.Width = 360;
               
                k = 0;
            }
        }
    }
}
