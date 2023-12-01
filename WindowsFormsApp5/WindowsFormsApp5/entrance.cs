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

namespace WindowsFormsApp5
{
    public partial class entrance : Form
    {
        public entrance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                if ((textBox1.Text == "") && (textBox2.Text == ""))
                {
                    MessageBox.Show("Заполните все поля!!!");
                }
                else
                {
                    if ((textBox1.Text == "") && (textBox2.Text == ""))
                    {
                        MessageBox.Show("Введите Логин и Пароль!!!");
                    }
                    else
                    {
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Введите Логин!!!");
                        }
                        else
                        {
                            if (textBox2.Text == "")
                            {
                                MessageBox.Show("Введите Пароль!!!");
                            }
                        }
                    }

                }
            }
            else
            {
                Boolean flag = false;
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = Б_АЮ_Учебная_Практика; Integrated Security = True");
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Users", sqlConnect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((dt.Rows[i]["login"].ToString() == textBox1.Text) &&
                    (dt.Rows[i]["parol"].ToString() == textBox2.Text))
                    {
                        string роль = dt.Rows[i]["reverh"].ToString();

                        switch (роль)
                        {
                            case "Админ":
                                this.Hide();
                                admin AdmFrm = new admin();
                                AdmFrm.Show();
                                break;

                            case "Сотрудник":
                                this.Hide();
                                admin AdmFr = new admin();
                                AdmFr.Show();
                                AdmFr.ii("Сотрудник");
                                break;

                            default:

                                MessageBox.Show("Неправильный логин или пароль.");
                                break;
                        }
                       
                        break;
                    }
                }
            }
        }

        private void entrance_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            checkBox1.Text = "Показать пороль";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Скрыть пороль";
               
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                checkBox1.Text = "Показать пороль";
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
