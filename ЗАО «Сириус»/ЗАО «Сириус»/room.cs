using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗАО__Сириус_
{
    public partial class room : Form
    {

        public room()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int value;
            //if (int.TryParse(textbox.Text, out value))
            //{
            //    if (value > 255)
            //        textbox.Text = "255";
            //    else if (value < 0)
            //        textbox.Text = "0";
            //}
        }
        private const string ConnectionString = ("Data Source = sql; Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "")
            {
                label8.Visible = true;//появляется надпись "Вы ничего не ввели"
                textBox2.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            string floor = textBox1.Text;
            decimal square = decimal.Parse(textBox2.Text);
            string otdelka = textBox3.Text;
            string phone = maskedTextBox1.Text;
            if ( textBox2.Text != "" && textBox3.Text != "")
            {
                string insertQuery = "insert into Помещения ( Этаж, Площадь, Отделка,Телефон)" + 
                $"VALUES ( @floor, @square, @otdelka,@phone)";
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@floor", floor);
                            command.Parameters.AddWithValue("@square", square);
                            command.Parameters.AddWithValue("@otdelka", otdelka);
                            command.Parameters.AddWithValue("@phone", phone);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Данные сохранены");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Обязательные поля не заполнены");
            }

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void room_Load(object sender, EventArgs e)
        {

        }
    }
}
