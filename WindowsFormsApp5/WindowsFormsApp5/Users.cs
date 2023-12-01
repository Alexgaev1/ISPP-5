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

namespace WindowsFormsApp5
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "б_АЮ_Учебная_ПрактикаDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter1.Fill(this.б_АЮ_Учебная_ПрактикаDataSet1.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "б_АЮ_Учебная_ПрактикаDataSet.Users". При необходимости она может быть перемещена или удалена.
            //this.usersTableAdapter.Fill(this.б_АЮ_Учебная_ПрактикаDataSet.Users);
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter  da = new SqlDataAdapter("select login as [логин], parol as [пароль], reverh as [Права доступа] from Users", sqlConnect);
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            DataTable dta = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Users", sqlConnect);
            daa.Fill(dta);
            string n = dta.Rows[dta.Rows.Count - 1]["id"].ToString();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Users (login,parol,reverh) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}');", sqlConnect);
            da.Fill(dt);
            //dataGridView2.DataSource = dt.Tables[0];
            usersTableAdapter.Update(б_АЮ_Учебная_ПрактикаDataSet.Users);
            MessageBox.Show($"Регистрация пользователя с логином {textBox1.Text} выполнена.\n");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Users where login like '{textBox4.Text}%' ", sqlConnect);
            daa.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
                sqlConnect.Open();
                DataSet dt = new DataSet();
                SqlDataAdapter daa = new SqlDataAdapter($"select * from Users where login like '{textBox4.Text}%' ", sqlConnect);
                daa.Fill(dt);
                dataGridView1.DataSource = dt.Tables[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin AdmFr = new admin();
            AdmFr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
