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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pravo = "", name = "", lastname = "", firthname = "";
        public string Namee()
        {
            return name;
        }
        public string Last()
        {
            return lastname;
        }
        public string Firth()
        {
            return firthname;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Users", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean log = false, password = false;
           
            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["Login"].ToString() == textBox1.Text)
                {
                    if (dt.Rows[i]["Password"].ToString() == textBox2.Text)
                    {
                        password = true;
                        pravo = dt.Rows[i]["Pravo"].ToString();
                        name = dt.Rows[i]["Name"].ToString();
                        lastname = dt.Rows[i]["LastName"].ToString();
                        firthname = dt.Rows[i]["FrithName"].ToString();

                    }
                    log = true;
                }
            if ((password == true) && (log == true))
            {
                if ((pravo == "admin")||(pravo == "oper"))
                {
                    Form2 form = new Form2();
                    form.pravoo(pravo);
                    form.Show();
                    Hide();
                }
                else
                {
                    Form4 form = new Form4();
                    form.Show();
                    Hide();
                    form.st(name, lastname, firthname);
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            Hide();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
