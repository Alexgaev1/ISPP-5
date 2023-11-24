using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private int loginAttempts = 5;
        bool hidden = true;
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text;


            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Не введён логин или пароль");
                return;
            }

            if (loginAttempts <= 0)
            {
                MessageBox.Show("Превышено количество попыток входа. Обратитесь к администратору.");
                this.Close();
                return;
            }

            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");

            try
            {
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Users where Login = @login", sqlConnect);
                da.SelectCommand.Parameters.AddWithValue("@login", login);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Пользователь с таким логином не существует.");
                    loginAttempts--;
                }
                else
                {
                    string dbPassword = dt.Rows[0]["Password"].ToString();
                    string role = dt.Rows[0]["Access"].ToString();
                    if (password == dbPassword)
                    {
                        switch (role)
                        {
                            case "admin":
                                MessageBox.Show("Произведён вход как администратор");
                                break;
                            case "user":
                                MessageBox.Show("Произведён вход как пользователь");
                                break;
                            case "guest":
                                МенюГостя gstForm = new МенюГостя();
                                gstForm.Show();
                                this.Hide();
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Неверный Пароль.");
                        loginAttempts--;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Опибка при входе: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hidden == false)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Downloads\\Учебная практика\\autoShop\\autoShop\\images\\glazik.png");
                textBox2.PasswordChar = '*';
                hidden = true;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\admin\\Downloads\\Учебная практика\\autoShop\\autoShop\\images\\glazik_zakryt.png");
                textBox2.PasswordChar = '\0';
                hidden = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Регистрация regForm = new Регистрация();
            regForm.Show();
            this.Hide();
        }
    }
}
