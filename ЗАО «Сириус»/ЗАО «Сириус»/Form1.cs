using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Timers;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗАО__Сириус_
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security = True");//подключение к SQL БД
        public Form1()
        {
            InitializeComponent();
            sqlConnect.Open();
        }
        private static int counter = 5;//кол-во попыток
        //public string login;
        int sec = 30;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Visible = true;//появляется надпись "Вы ничего не ввели"
                textBox1.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (textBox2.Text == "")
            {
                label2.Visible = true;
                textBox2.BackColor = Color.LightCoral;
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean flag = false;
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) &&
                    (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))//проверка на корректные значения в полях Логин и Пароль
                {
                    string роль = dt.Rows[i]["Права доступа"].ToString();
                    switch (роль)
                    {
                        case "Администратор":
                            this.Hide();
                            admin Admin = new admin();
                            Admin.Show();
                            break;
                        case "Риелтор":
                            this.Hide();
                            rieltor rieltor = new rieltor();
                            rieltor.Show();
                            break;
                        case "Гость":
                            this.Hide();
                            guest guest = new guest();
                            guest.Show();
                            break;
                        case "Директор":
                            this.Hide();
                            director director = new director();
                            director.Show();
                            break;
                        case "Сотрудник":
                            this.Hide();
                            navigation sotrudnik = new navigation();
                            sotrudnik.Show();
                            break;
                    }
                    flag = true;
                    break;
                }
            for (int i = 0; i < dt.Rows.Count; i++)
                if (flag == false)
                {
                    if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) &&
                        (dt.Rows[i]["Пароль"].ToString() != textBox2.Text))//проверка неправильного ввода пароля 
                    {
                        MessageBox.Show("Введен неверный пароль");
                    }
                }

            if (flag == false)
            {
                counter--;
                label3.Text = "Осталось попыток: " + counter.ToString();
                if (counter == 0)//кол-во попыток=0, в этом цикле пограмма автоматически закроется 
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    MessageBox.Show("Попытки входа закончились, подождите 30 секунд");
                    timer1.Start();
                }
            }
        }
        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            this.Text = "Регистрация";
            this.Width = 285;
            this.Height = 470;
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            this.Text = "Авторизация";
            this.Width = 270;
            this.Height = 350;
        }
        private const string ConnectionString = ("Data Source = sql; Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security = True");
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                label6.Visible = true;//появляется надпись "Вы ничего не ввели"
                textBox3.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (textBox4.Text == "")
            {
                label5.Visible = true;//появляется надпись "Вы ничего не ввели"
                textBox4.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (textBox6.Text == "")
            {
                label4.Visible = true;//появляется надпись "Вы ничего не ввели"
                textBox6.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (textBox7.Text == "")
            {
                label7.Visible = true;
                textBox7.BackColor = Color.LightCoral;
            }
            if (textBox8.Text == "")
            {
                label8.Visible = true;
                textBox8.BackColor = Color.LightCoral;
            }
            string fam = textBox6.Text;
            string imya = textBox7.Text;
            string otch = textBox6.Text;
            string login = textBox6.Text;
            string parol = textBox7.Text;
            if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (textBox7.Text == textBox8.Text)
                {
                    string insertQuery = "insert into Пользователи (Фамилия, Имя, Отчество, Логин,Пароль)" +
                        $"VALUES ('{fam}','{imya}', '{otch}', '{login}', '{parol}')";
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    MessageBox.Show("Вы зарегистрированы");
                    panel2.Visible = true;
                    panel3.Visible = false;
                    this.Text = "Авторизация";
                    this.Width = 250;
                    this.Height = 350;
                }
                else
                {
                    label10.Visible = true;//пароли не совпадают
                    textBox8.BackColor = Color.LightCoral;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)//если нажатая клавиша "Space" то
                e.KeyChar = '\0';//ничего не вводится (нулевой символ)
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)//если нажатая клавиша "Space" то
                e.KeyChar = '\0';//ничего не вводится (нулевой символ)
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)//если нажатая клавиша "Space" то
                e.KeyChar = '\0';//ничего не вводится (нулевой символ)
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)//если нажатая клавиша "Space" то
                e.KeyChar = '\0';//ничего не вводится (нулевой символ)
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)//если нажатая клавиша "Space" то
                e.KeyChar = '\0';//ничего не вводится (нулевой символ)
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)//если нажатая клавиша "Space" то
                e.KeyChar = '\0';//ничего не вводится (нулевой символ)
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)//если нажатая клавиша "Space" то
                e.KeyChar = '\0';//ничего не вводится (нулевой символ)
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)//если нажатая клавиша "Space" то
                e.KeyChar = '\0';//ничего не вводится (нулевой символ)
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox3.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            label5.Visible = false;
            textBox4.BackColor = Color.White;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            label4.Visible = false;
            textBox6.BackColor = Color.White;
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox7.BackColor = Color.White;
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            label8.Visible = false;
            textBox8.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.BackColor = Color.White;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //    label3.Text = sec--.ToString();
            //    if (sec < 0)
            //        timer1.Stop();
            //    textBox1.Enabled = true;
            //    textBox2.Enabled = true;
            //    label3.Text = "";
            //}
        }
    }
    
}
