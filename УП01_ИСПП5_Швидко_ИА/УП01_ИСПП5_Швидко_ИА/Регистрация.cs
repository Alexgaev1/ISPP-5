using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Кнопка_подтверждения_Click(object sender, EventArgs e)        //Переходит на форму 'Авторизация'
        {
            if ((Логин_textBox5.Text == "") || (Пароль_textBox4.Text == "") || (Почта_textBox2.Text == ""))
            {
                MessageBox.Show("Не все данные заполнены!", "Ошибка");
            }
            else
            {
                using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True"))
                {
                    SqlDataAdapter info = new SqlDataAdapter($"INSERT INTO Пользователи (Логин,Пароль,Почта) VALUES('{Логин_textBox5.Text}','{Пароль_textBox4.Text}','{Почта_textBox2.Text}');", sqlConnect);
                    DataTable tt = new DataTable();
                    info.Fill(tt);
                }

                MessageBox.Show("Вы зарегестрированы как 'Покупатель'", "Уведомление");

                Авторизация AvtFrm = new Авторизация();
                AvtFrm.Show();
                this.Hide();
            }
        }

        private void Пароль_KeyPress(object sender, KeyPressEventArgs e)             //Проверяет на отсутствие букв
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы", "Ошибка");
            }
        }

        private void Вернуться_Click(object sender, EventArgs e)        //Переходит на форму 'Авторизация'
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void выйти_Click(object sender, EventArgs e)                   //Прекращает работу программы
        {
            Application.Exit();
        }
        Point Mouse;
        private void Регистрация_MouseMove(object sender, MouseEventArgs e)        //Перемещает форму при удержании мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Регистрация_MouseDown(object sender, MouseEventArgs e)        //Перемещает форму при удержании мыши
        {
            Mouse = new Point(e.X, e.Y);
        }
    }
}
