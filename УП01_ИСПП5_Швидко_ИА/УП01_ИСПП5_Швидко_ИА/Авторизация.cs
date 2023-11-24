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

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Авторизация : Form
    {
        public int ogr = 5;
        public Авторизация()
        {
            InitializeComponent();
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка");
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int flag = -1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((dt.Rows[i]["Права_доступа"].ToString() == "Администратор") && (dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                        flag = 0;
                    if ((dt.Rows[i]["Права_доступа"].ToString() == "Продавец") && (dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                    {
                        flag = 1;
                    }
                    if ((dt.Rows[i]["Права_доступа"].ToString() == "Покупатель") && (dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                    {
                        flag = 2;
                    }
                }
                if ((flag == 2) || (flag == 1) || (flag == 0))
                {
                    if (flag == 0)
                    {
                        this.Hide();
                        Администратор UsrFrm = new Администратор();
                        UsrFrm.Show();
                    }
                    if (flag == 1)
                    {
                        this.Hide();
                        Продавец UsrFrm5 = new Продавец();
                        UsrFrm5.Show();
                    }
                    if (flag == 2)
                    {
                        this.Hide();
                        Покупатель UsrFrm6 = new Покупатель();
                        UsrFrm6.Show();
                    }
                }
                else
                    MessageBox.Show("Пересоздайте пользователя! Такого пользователя не существует.");
            }
        }
        private void roundBtn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Регистрация UsrFrm4 = new Регистрация();
            UsrFrm4.Show();
        }


        private void roundBtn4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Гость UsrFrm3 = new Гость();
            UsrFrm3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int a = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            a++;
            if (a==1)
            {
                textBox2.PasswordChar = '\0';
            }
            if (a==2)
            {
                textBox2.PasswordChar = '*';
                a = 0;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы");
            }
        }
    }
}
