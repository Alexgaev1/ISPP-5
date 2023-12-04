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

namespace Практика_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog =уП_ПМ01_ИСПП_5_Буйлов_МА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Пользователи",sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean flag = false;
           
            
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) &&
               (dt.Rows[i]["Пароль"].ToString() == textBox2.Text)) {flag = true;k = i; }
                    
            if (flag == true)
            {switch (dt.Rows[k]["Права_Доступа"].ToString()) 
                {
                 case "Админ":this.Hide();
                 Form2 UsrFrm = new Form2();
                 UsrFrm.Show(); break;
                 default: MessageBox.Show("Неверный пароль или логин!"); break;

                 case "Квартиросъемщик":
                 this.Hide();
                 Form3 form3 = new Form3();
                 form3.Show(); break;
                   
                 case "Инспектор":
                 this.Hide();
                 Form4 form4 = new Form4();
                 form4.Show(); break;



                }            
            }else MessageBox.Show("Неверный пароль или логин!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 check = new Form5();
            check.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
