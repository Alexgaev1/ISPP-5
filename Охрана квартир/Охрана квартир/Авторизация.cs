using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Охрана_квартир
{
    public partial class Авторизация : Form
    {
        public int ogr = 5;
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Введите и Логин и Пароль", "Ошибка");
            }
            else if (ogr == 0)
            {
                MessageBox.Show("Количество ваших попыток было исчерпанно\nОбратитись к администратору и закройте форму авторизации");
                button1.Visible = false;
                button3.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                pictureBox1.Visible = false;
            }
            else
            {
                using (SqlConnection sqlConnect = new SqlConnection("Data Source=LAPTOP-QNPA1CAR\\SQLEXPRESS;Initial Catalog = Неверов_ОК; Integrated Security = True"))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from [Use]", sqlConnect);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Boolean логин = false;
                    Boolean пароль = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                        {
                            логин = true; пароль = true; textBox3.Text = dt.Rows[i]["Права доступа"].ToString();
                        }
                        if ((dt.Rows[i]["Логин"].ToString() != textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                        {
                            логин = false; пароль = true;
                        }
                        if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() != textBox2.Text))
                        {
                            логин = true; пароль = false;
                        }
                    }
                    if (логин == true && пароль == true)
                    {
                        if (textBox3.Text == "КП")
                        {
                            this.Hide();
                            Оператор f4 = new Оператор();
                            f4.Show();
                        }
                        if (textBox3.Text == "Командир")
                        {
                            Командир f4 = new Командир();
                            this.Hide();
                            f4.Show();
                        }
                        if (textBox3.Text == "Администратор")
                        {
                            this.Hide();
                            Администратор f5 = new Администратор();
                            f5.Show();
                            f5.Text = "Форма Администратора";
                        }
                        if (textBox3.Text == "Оператор")
                        {
                            this.Hide();
                            Администратор f5 = new Администратор();
                            f5.Show();
                            f5.Text = "Форма Оператора";
                        }
                    }
                    else if (логин == false || пароль == false)
                    {
                        MessageBox.Show("Неправельные Логин или Пароль, попробуйте введите еще раз");
                        ogr = ogr - 1;
                        label1.Text = $"Для входа осталось попыток: {ogr}";
                    }
                }
            }
        }
        int click = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            click += 1;
            if (click==1)
            {
                pictureBox1.ImageLocation = $"//apetfs/ИСПП-5/Неверов_ДС/УП ПМ 01/Охрана квартир/Охрана квартир/5618419.png";
                textBox2.PasswordChar = '\0';
            }
            else if (click == 2)
            {
                pictureBox1.ImageLocation = $"//apetfs/ИСПП-5/Неверов_ДС/УП ПМ 01/Охрана квартир/Охрана квартир/free-icon-visibility-button-60809.png";
                textBox2.PasswordChar = '*';
                click = 0;
            }
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
                button1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Регистрация а1 = new Регистрация();
            Hide();
            а1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(button3, "Нажмите, чтобы оформить документ и зарегестрироваться");
            tt.SetToolTip(pictureBox1, "Нажмите, чтобы просмотреть пароль");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
