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

namespace Отдел_кадров_университета
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Поля не должны быть пустыми.");
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection("Data Source = ANTON_SERVER\\SQLEXPRESS; Initial Catalog = УП01_ИСПП_5_Гаевский_АА; Integrated Security = True");
                sqlConnect.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int flag = -1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((dt.Rows[i]["ПраваДоступа"].ToString() == "Администратор") && (dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                        flag = 0;

                    if ((dt.Rows[i]["ПраваДоступа"].ToString() == "Начальник") && (dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                    {
                        flag = 1;
                    }
                    if ((dt.Rows[i]["ПраваДоступа"].ToString() == "Рекрутер") && (dt.Rows[i]["Логин"].ToString() == textBox1.Text) && (dt.Rows[i]["Пароль"].ToString() == textBox2.Text))
                    {
                        flag = 2;
                    }
                }
                if (flag != -1)
                {
                    if (flag == 0)
                    {
                        Hide();
                        Administrator UserForm1 = new Administrator();
                        UserForm1.Show();
                    }
                    if (flag == 1)
                    {
                        Hide();
                        Chief UserForm1 = new Chief();
                        UserForm1.Show();
                    }
                    if (flag == 2)
                    {
                        Hide();
                        Recruter UserForm1 = new Recruter();
                        UserForm1.Show();
                    }

                }
                else
                    MessageBox.Show("Неправильный логин или пароль.");
            }
        }
    }
}
