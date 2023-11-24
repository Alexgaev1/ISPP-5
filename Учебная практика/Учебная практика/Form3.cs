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

namespace Учебная_практика
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            DataTable dta = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter($"select * from Users", sqlConnect);
            daa.Fill(dta);
            string n = dta.Rows[dta.Rows.Count - 1]["Id"].ToString();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Users (Id,Login,Password,Name,LastName,FrithName) VALUES ('{int.Parse(n) + 1}','{textBox1.Text}','{textBox2.Text}','{textBox4.Text}','{textBox3.Text}','{textBox5.Text}');", sqlConnect);
            da.Fill(dt);
            MessageBox.Show($"{textBox3.Text} {textBox4.Text} {textBox5.Text}, вы были зарегистрированы на логину: {textBox1.Text}");
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП__ПМ01_Попов_СЕ_Приемная_комиссия_университетаDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.уП__ПМ01_Попов_СЕ_Приемная_комиссия_университетаDataSet.Users);

        }
    }
}
