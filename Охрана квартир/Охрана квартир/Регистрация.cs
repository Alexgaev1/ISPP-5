using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Охрана_квартир
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }


        private void Регистрация_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void Регистрация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ_01_Неверов_ДСDataSet2.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.уП_ПМ_01_Неверов_ДСDataSet2.Client);
            label16.Text = "Введите свои персональные данные";
            this.Size = new Size(325, 375);
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pictureBox1, "Нажмите, чтобы закрыть приложение");
            tt.SetToolTip(pictureBox2, "Нажмите, чтобы вернуться к форме авторизации");
        }
        
        int n;
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП_ПМ_01_Неверов_ДС; Integrated Security = True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from [User]", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Boolean логин = true;
                n = dataGridView1.RowCount;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Логин"].ToString() == textBox7.Text)
                    {
                        логин = false;
                    }
                }
                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "" || textBox7.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Введите все данные!");
                }
                else
                {
                    if (логин == false)
                    {
                        MessageBox.Show("Пользователь уже существует!!!");
                    }
                    else
                    {
                        SqlDataAdapter info1 = new SqlDataAdapter($"INSERT INTO [Client] (Registr,SecondName,FirstName,ThirdName,Address,Phone)VALUES('{n}','{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{maskedTextBox1.Text}');", sqlConnect);
                        SqlDataAdapter info2 = new SqlDataAdapter($"INSERT INTO [User] (Registr,Логин,Пароль)VALUES('{n}','{textBox7.Text}','{textBox6.Text}');", sqlConnect);
                        DataTable dt1 = new DataTable();
                        DataTable dt2 = new DataTable();
                        info1.Fill(dt1);
                        info2.Fill(dt2);
                    }
                    MessageBox.Show($"Пользователь {textBox2.Text} {textBox1.Text} {textBox3.Text} был зарегестрирован.\nСейчас вас перекинет на форму авторизации, где вам необходимо ввести логин и пароль, который вы вводили.");
                    Авторизация fd = new Авторизация();
                    Hide();
                    fd.Show();
                }
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Авторизация fd = new Авторизация();
            Hide();
            fd.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                maskedTextBox1.Focus();
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox7.Focus();
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
