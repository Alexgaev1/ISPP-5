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
    public partial class Avtorization : Form
    {
        public Avtorization(){InitializeComponent();}
        //Назначение переменных отвечающих за ФИО и право доступа
        string pravo = "", name = "", lastname = "", firthname = "";
        //При нажатии на кнопку "Вход"
        private void Sing_Click(object sender, EventArgs e)
        {
            //Подключение к базе данных
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            //Просмотр таблицы Users
            SqlDataAdapter da = new SqlDataAdapter("select * from Users", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Проверка на наличие логина и пароля в базе
            Boolean log = false, password = false;
           //Просмотр всех строк таблицы
            for (int i = 0; i < dt.Rows.Count; i++)
                //Нахождение совпадающего с написанным пароля логина
                if (dt.Rows[i]["Login"].ToString() == Login.Text)
                {
                    //Нахождение совпадающего с написанным пароля
                    if (dt.Rows[i]["Password"].ToString() == Password.Text)
                    {
                        //Пароль найден, для переменной
                        password = true;
                        //Назначение переменных в случае совпадения логина и пароля с введенными строками
                        pravo = dt.Rows[i]["Pravo"].ToString();
                        name = dt.Rows[i]["Name"].ToString();
                        lastname = dt.Rows[i]["LastName"].ToString();
                        firthname = dt.Rows[i]["FrithName"].ToString();

                    }
                    //Логин найден, для переменной
                    log = true;
                }
            //Если пароль и логин найдены и вход возможен
            if ((password == true) && (log == true))
            {
                //Если права равны "Администратор", "Оператор", "Сотрудник"
                if ((pravo == "admin")||(pravo == "oper")||(pravo == "personal"))
                {
                    //Переход к форме редактирования форм
                    Tables form = new Tables();
                    form.pravoo(pravo);
                    form.Show();
                    Hide();
                }
                //Если иной результат
                else
                {
                    //Переход на форму для гостя
                    AbityrientForm form = new AbityrientForm();
                    form.Show();
                    Hide();
                    form.st(name, lastname, firthname);
                }
            }
            else
            {
                MessageBox.Show("Логин/пароль введен неверно");
            }
        }
        //При нажатии на кнопку "Регистрация"
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            //Переход на форму "Регистрация"
            RegistrationForm form = new RegistrationForm();
            form.Show();
            Hide();
        }
        //При нажатии на флажок
        private void PasswordVisible_MouseClick(object sender, MouseEventArgs e)
        {
            //Если флажок стоит
            if (PasswordVisible.Checked == true)
            {
                //Кружочки вместо пароля выключено
                Password.UseSystemPasswordChar = false;
            }
            //Если флажок не стоит
            else
            {
                //Кружочки вместо пароля включено
                Password.UseSystemPasswordChar = true;
            }
        }
        //При нажатии на кнопку "Выход"
        private void ExitButton_Click(object sender, EventArgs e){Application.Exit();}
    }
}
