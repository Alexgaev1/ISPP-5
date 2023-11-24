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

namespace ЗАО__Сириус_
{
    public partial class dogovori : Form
    {
        SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security=True");
        public dogovori()
        {
            InitializeComponent();
            sqlConnect.Open();
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlDataAdapter da = new SqlDataAdapter("select * from Помещения", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox5.DataSource = dt;
            comboBox5.DisplayMember = "Номер помещения";
            comboBox5.ValueMember = "Номер помещения";

            SqlDataAdapter dad = new SqlDataAdapter("select * from Арендаторы", sqlConnect);
            DataTable dtt = new DataTable();
            dad.Fill(dtt);
            comboBox4.DataSource = dtt;
            comboBox4.DisplayMember = "Идентификатор арендатора";
            comboBox4.ValueMember = "Идентификатор арендатора";

            SqlDataAdapter dada = new SqlDataAdapter("select * from Риелторы", sqlConnect);
            DataTable dttt = new DataTable();
            dada.Fill(dttt);
            comboBox3.DataSource = dttt;
            comboBox3.DisplayMember = "Идентификатор риелтора";
            comboBox3.ValueMember = "Идентификатор риелтора";
            sqlConnect.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private const string ConnectionString = ("Data Source = sql; Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "")
            {
                label12.Visible = true;//появляется надпись "Вы ничего не ввели"
                comboBox5.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (comboBox4.Text == "")
            {
                label13.Visible = true;//появляется надпись "Вы ничего не ввели"
                comboBox4.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (comboBox3.Text == "")
            {
                label14.Visible = true;//появляется надпись "Вы ничего не ввели"
                comboBox3.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (textBox4.Text == "")
            {
                label19.Visible = true;//появляется надпись "Вы ничего не ввели"
                textBox4.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (comboBox1.Text == "")
            {
                label15.Visible = true;//появляется надпись "Вы ничего не ввели"
                comboBox1.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (dateTimePicker1.Text == "")
            {
                label8.Visible = true;//появляется надпись "Вы ничего не ввели"
                dateTimePicker1.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (dateTimePicker2.Text == "")
            {
                label8.Visible = true;//появляется надпись "Вы ничего не ввели"
                dateTimePicker2.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            if (comboBox2.Text == "")
            {
                label8.Visible = true;//появляется надпись "Вы ничего не ввели"
                comboBox2.BackColor = Color.LightCoral;//текстовое поле выделяется красным цветом
            }
            string number = comboBox5.Text;
            string arendator = comboBox4.Text;
            string rieltor = comboBox3.Text;
            string status = comboBox1.Text;
            string databegin = dateTimePicker1.Value.ToString();
            string dataend = dateTimePicker2.Value.ToString();
            string periodich = comboBox2.Text;
            string sum = textBox4.Text;
            string cel = textBox5.Text;
            string shtraf = textBox6.Text;
            string prim = textBox7.Text;
            if (comboBox5.Text != "" && comboBox4.Text != "" && comboBox3.Text != "" &&
                comboBox1.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" &&
                comboBox2.Text != "" && textBox4.Text != "")
            {
                string insertQuery = "insert into Договоры ( [Номер помещения], [Идентификатор арендатора]" +
                    ", [Идентификатор риелтора], Статус,[Дата начала], [Дата окончания], [Периодичность оплаты]" +
                    ", [Сумма оплаты], [Цель аренды], [Штраф за нарушение], Примечания)" +
                    $"VALUES (@number, @arendator, @rieltor,@status, @databegin,@dataend, " +
                    $"@periodich, @sum, @cel, @shtraf, @prim)";
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@number", number);
                            command.Parameters.AddWithValue("@arendator", arendator);
                            command.Parameters.AddWithValue("@rieltor", rieltor);
                            command.Parameters.AddWithValue("@status", status);
                            command.Parameters.AddWithValue("@databegin", databegin);
                            command.Parameters.AddWithValue("@dataend", dataend);
                            command.Parameters.AddWithValue("@periodich", periodich);
                            command.Parameters.AddWithValue("@sum", sum);
                            command.Parameters.AddWithValue("@cel", cel);
                            command.Parameters.AddWithValue("@shtraf", shtraf);
                            command.Parameters.AddWithValue("@prim", prim);
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

        private void dogovori_Load(object sender, EventArgs e)
        {
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Помещения", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            помещенияBindingSource.DataSource = dt;
            dataGridView1.DataSource = помещенияBindingSource;
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Арендаторы", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            арендаторыBindingSource.DataSource = dt;
            dataGridView1.DataSource = арендаторыBindingSource;
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Риелторы", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            риелторыBindingSource.DataSource = dt;
            dataGridView1.DataSource = риелторыBindingSource;
        }
    }
}
