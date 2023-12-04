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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog =уП_ПМ01_ИСПП_5_Буйлов_МА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT INTO Пользователи(Логин, Пароль,Права_Доступа)VALUES('{textBox1.Text}','{textBox2.Text}','Квартиросъемщик')", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean flag = false;
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i]["Логин"].ToString() == textBox1.Text) &&
               (dt.Rows[i]["Пароль"].ToString() == textBox2.Text)) { flag = true; k = i; }

            if (flag == true)
            {
                switch (dt.Rows[k]["Логин, Пароль"].ToString())
                {
                    case "Квартиросъемщик":
                    default: MessageBox.Show("Пользователь уже существует!"); break;
                }
            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
            Form1 check = new Form1();
            check.Show();
            Hide();
            }
    }
}
