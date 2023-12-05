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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm(){InitializeComponent();}
        //При нажатии на кнопку регистрации
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            //Подключение к базе данных
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Users (Login,Password,Name,LastName,FrithName) VALUES ('{Login.Text}','{Password.Text}','{NameText.Text}','{LastName.Text}','{FirdName.Text}');", sqlConnect);
                da.Fill(dt);
            }
            catch{}
            MessageBox.Show($"{LastName.Text} {NameText.Text} {FirdName.Text}, вы были зарегистрированы на логину: {Login.Text}");
            //Переход на форму авторизации
            Avtorization form = new Avtorization();
            form.Show();
            Hide();
        }
        //При нажатии на кнопку "отмена"
        private void Cancel_Click(object sender, EventArgs e)
        {
            //Переход на форму авторизации
            Avtorization form = new Avtorization();
            form.Show();
            Hide();
        }
        //При загрузке формы
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП__ПМ01_Попов_СЕ_Приемная_комиссия_университетаDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.уП__ПМ01_Попов_СЕ_Приемная_комиссия_университетаDataSet.Users);
        }
    }
}
