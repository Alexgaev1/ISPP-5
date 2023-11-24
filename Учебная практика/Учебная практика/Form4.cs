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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string name, last, first;

        private void Form4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            if (checkBox1.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter($"select Name as [Имя], LastName as [Фамилия] ,FirthName as [Отчество],Date as [Дата регистрации],Faculty as [Факультет], Speciality as [Специальность],Result as [Балл при поступлении],Talk as [Рекомендации], Type as [Основа, на которой зачислен] from ((Enrollee join EGE on Enrollee.Enrolle=EGE.Enrolle) join Commission on EGE.EGE = Commission.EGE) join Enrollment on Commission.PersonID = Enrollment.PersonId where Name Like'{name}' and LastName Like'{last}' and FirthName Like '{first}'", sqlConnect);
                da.Fill(dt);
            }
            if (checkBox1.Checked == false)
            {
                SqlDataAdapter da = new SqlDataAdapter($"select Name as [Имя], LastName as [Фамилия] ,FirthName as [Отчество],Date as [Дата регистрации],Faculty as [Факультет], Speciality as [Специальность],Result as [Балл при поступлении],Talk as [Рекомендации], Type as [Основа, на которой зачислен] from ((Enrollee join EGE on Enrollee.Enrolle=EGE.Enrolle) join Commission on EGE.EGE = Commission.EGE) join Enrollment on Commission.PersonID = Enrollment.PersonId", sqlConnect);
                da.Fill(dt);
            }
            dataGridView1.DataSource = dt.Tables[0];

        }

        public void st(string a, string b, string c)
        {

            name = a;
            last = b;
            first = c;
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"select Name as [Имя], LastName as [Фамилия] ,FirthName as [Отчество],Date as [Дата регистрации],Faculty as [Факультет], Speciality as [Специальность],Result as [Балл при поступлении],Talk as [Рекомендации], Type as [Основа, на которой зачислен] from ((Enrollee join EGE on Enrollee.Enrolle=EGE.Enrolle) join Commission on EGE.EGE = Commission.EGE) join Enrollment on Commission.PersonID = Enrollment.PersonId", sqlConnect);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

    }
}
