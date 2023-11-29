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
using System.IO;
using System.Drawing.Imaging;

namespace УП_МДК_01_01
{
    public partial class Form2 : Form
    {
        static public string loginActive;
        static public string whois;
        public Form2()
        {
            InitializeComponent();
        }
        int popitki = 6;
        private void label5_Click(object sender, EventArgs e)
        {
            
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar -= e.KeyChar;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.KeyChar -= e.KeyChar;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 UsrFrm = new Form3();
            UsrFrm.Show();
            Form3 form3 = new Form3();
            form3.load();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                Authorization.Authorization1(textBox1.Text, textBox2.Text);
                switch(Authorization.Права_доступа)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует", "Проверьте данные и попоробуйте снова", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case "Администратор":
                        {
                            loginActive = textBox1.Text;
                            whois = "Администратор";
                            Authorization.Права_доступа = textBox1.Text;

                                string Права_доступа = Authorization.AuthorizationName(textBox1.Text);
                            Authorization.Права_доступа = Права_доступа;
                            MessageBox.Show(Права_доступа + ", вы зашли в меню","Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form5 form5 = new Form5();
                            form5.Show();
                            break;
                        }
                    case "Клиент":
                        {
                            loginActive = textBox1.Text;
                            whois = "Клиент";
                            Authorization.Права_доступа = textBox1.Text;

                            string Права_доступа = Authorization.AuthorizationName(textBox1.Text);
                            Authorization.Права_доступа = Права_доступа;
                            MessageBox.Show(Права_доступа + ", вы зашли в меню", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form10  form10  = new Form10 ();
                            form10.Show();
                            break;
                        }
                    case "Агент":
                        {
                            loginActive = textBox1.Text;
                            whois = "Агент";
                            Authorization.Права_доступа = textBox1.Text;

                            string Права_доступа = Authorization.AuthorizationName(textBox1.Text);
                            Authorization.Права_доступа = Права_доступа;
                            MessageBox.Show(Права_доступа + ", вы зашли в меню", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form11  form11  = new Form11 ();
                            form11.Show();
                            break;
                        }
                    case "Оператор":
                        {
                            loginActive = textBox1.Text;
                            whois = "Оператор";
                            Authorization.Права_доступа = textBox1.Text;

                            string Права_доступа = Authorization.AuthorizationName(textBox1.Text);
                            Authorization.Права_доступа = Права_доступа;
                            MessageBox.Show(Права_доступа + ", вы зашли в меню", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form12 form12 = new Form12();
                            form12.Show();
                            break;
                        }
                    case "Гость":
                        {
                            loginActive = textBox1.Text;
                            whois = "Гость";
                            Authorization.Права_доступа = textBox1.Text;

                            string Права_доступа = Authorization.AuthorizationName(textBox1.Text);
                            Authorization.Права_доступа = Права_доступа;
                            MessageBox.Show(Права_доступа + ", вы зашли в меню", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Form13 form13 = new Form13();
                            form13.Show();
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля", "Заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DBConnection.ConnectionDB();
        }
    }
}
