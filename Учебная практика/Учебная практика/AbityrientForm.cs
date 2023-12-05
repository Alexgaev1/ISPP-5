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
    public partial class AbityrientForm : Form
    {
        string name, last, first;//Переменные отвечающие за Фамилию, Имя, Отчество
        public AbityrientForm(){InitializeComponent();}
        //При нажатии на кнопку "Выход"
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Переход на форму авторизации
            Avtorization form = new Avtorization();
            form.Show();
            Hide();
        }
        //При нажатии на флажок "Поиск по ФИО"
        private void FindForFIO_MouseClick(object sender, MouseEventArgs e)
        {
            //Подключение базы данных
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            //Если флажок стоит
            if (FindForFIO.Checked == true)
            {
                //Поиск по зарегистрированным ФИО
                SqlDataAdapter da = new SqlDataAdapter($"select Name as [Имя], LastName as [Фамилия] ,FirthName as [Отчество],Date as [Дата регистрации],Faculty as [Факультет], Speciality as [Специальность],Result as [Балл при поступлении],Talk as [Рекомендации], Type as [Основа, на которой зачислен] from ((Enrollee join EGE on Enrollee.Enrolle=EGE.Enrolle) join Commission on EGE.EGE = Commission.EGE) join Enrollment on Commission.PersonID = Enrollment.PersonId where Name Like'{name}' and LastName Like'{last}' and FirthName Like '{first}'", sqlConnect);
                da.Fill(dt);
            }
            //Если флажок не стоит
            if (FindForFIO.Checked == false)
            {
                //Обычный список прошедших
                SqlDataAdapter da = new SqlDataAdapter($"select Name as [Имя], LastName as [Фамилия] ,FirthName as [Отчество],Date as [Дата регистрации],Faculty as [Факультет], Speciality as [Специальность],Result as [Балл при поступлении],Talk as [Рекомендации], Type as [Основа, на которой зачислен] from ((Enrollee join EGE on Enrollee.Enrolle=EGE.Enrolle) join Commission on EGE.EGE = Commission.EGE) join Enrollment on Commission.PersonID = Enrollment.PersonId", sqlConnect);
                da.Fill(dt);
            }
            //Присваивание к объекту dataGridView
            dataGridView1.DataSource = dt.Tables[0];
        }
        //Метод для передачи ФИО из формы регистрации
        public void st(string a, string b, string c)
        {
            //Присваивание ФИО
            name = a;
            last = b;
            first = c;
            //Подключение к базе данных
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            //Вывод список прошедших
            SqlDataAdapter da = new SqlDataAdapter($"select Name as [Имя], LastName as [Фамилия] ,FirthName as [Отчество],Date as [Дата регистрации],Faculty as [Факультет], Speciality as [Специальность],Result as [Балл при поступлении],Talk as [Рекомендации], Type as [Основа, на которой зачислен] from ((Enrollee join EGE on Enrollee.Enrolle=EGE.Enrolle) join Commission on EGE.EGE = Commission.EGE) join Enrollment on Commission.PersonID = Enrollment.PersonId", sqlConnect);
            DataSet dt = new DataSet();
            da.Fill(dt);
            //Подключение списка к объекту dataGridView
            dataGridView1.DataSource = dt.Tables[0];
        }
    }
}
