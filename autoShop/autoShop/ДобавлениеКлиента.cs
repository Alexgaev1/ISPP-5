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

namespace autoShop
{
    public partial class ДобавлениеКлиента : Form
    {
        public ДобавлениеКлиента()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string patronimic = textBox3.Text.Trim();
            string phone = textBox4.Text.Trim();
            string sign = comboBox1.SelectedItem.ToString();
            string bank = textBox5.Text.Trim();
            string account = textBox6.Text.Trim();

            SqlConnection sqlConnect = new SqlConnection("Data Source=localhost;Initial Catalog = autoShop; Integrated Security = True");

            using (SqlCommand cmd = new SqlCommand("Insert Into Клиент(LastName, Name, Patronimic, Phone, Sign, Bank, Account) Values (@lastName, @name, @patronimic, @phone, @sign, @bank, @account)", sqlConnect))
            {
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@patronimic", patronimic);
                cmd.Parameters.AddWithValue("@phone", phone);
                if(sign == "Физическое лицо")
                {
                    cmd.Parameters.AddWithValue("@sign", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@sign", 2);
                }
                cmd.Parameters.AddWithValue("@bank", bank);
                cmd.Parameters.AddWithValue("@account", account);

                try
                {
                    sqlConnect.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Регистрация успешно завершена
                        MessageBox.Show("Данные успешно введены");
                    }
                    else
                    {
                        // Вставка не удалась, обработайте это по необходимости
                        MessageBox.Show("Ошибка при регистрации. Пожалуйста, попробуйте снова.");
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при выполнении SQL-запроса
                    MessageBox.Show("Ошибка при регистрации: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            МенюГостя gstForm = new МенюГостя();
            gstForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
