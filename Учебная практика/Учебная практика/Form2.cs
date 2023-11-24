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
    public partial class Form2 : Form
    {
        string[] t = new string[15];
        
        string pr;
        bool pr1 = false, pr2 = false, error=false, nulll = false;
        int tabell = 0, prost = 0, tabl = 0;
        public Form2() {InitializeComponent();}
        public void pravoo(string a){pr = a;}
        public void textbox(int a, int b)
        {
            switch (a)
            {
                case 0:
                    switch (b)
                    {
                        case 0:
                            
                            t[0] = textBox1.Text;
                            t[1] = textBox2.Text;
                            t[2] = textBox3.Text;
                            t[3] = dateTimePicker1.Value.ToString();
                            t[4] = textBox5.Text;

                            break;
                        case 1:
                           
                            t[5] = textBox1.Text;
                            t[6] = dateTimePicker1.Value.ToString();
                            t[7] = textBox3.Text;
                            t[8] = textBox4.Text;
                            t[9] = textBox5.Text;
                            break;
                        case 2:
                            t[10] = textBox1.Text;
                            t[11] = dateTimePicker1.Value.ToString();
                            t[14] = textBox5.Text;
                           
                            break;
                    }
                    break;
                case 1:
                    switch (b)
                    {
                        case 0:
                            t[0] = textBox1.Text;
                            t[1] = textBox2.Text;
                            t[2] = textBox3.Text;
                            t[3] = textBox4.Text;
                            break;
                    }
                    break;
                case 2:
                    switch (b)
                    {
                        case 0:
                            t[0] = textBox1.Text;
                            t[1] = textBox2.Text;
                            t[2] = textBox3.Text;
                            t[3] = textBox4.Text;
                            t[4] = textBox5.Text;
                            break;
                    }
                    break;
                case 3:
                    switch (b)
                    {
                        case 0:
                            t[0] = textBox1.Text;
                            t[1] = textBox2.Text;
                            t[2] = textBox3.Text;
                            t[3] = textBox4.Text;
                            t[4] = textBox5.Text;
                            break;
                        case 1:
                            t[5] = textBox1.Text;
                            t[6] = textBox2.Text;
                            t[7] = textBox3.Text;
                            break;
                    }
                    break;
                case 4:
                    switch (b)
                    {
                        case 0:
                            t[0] = textBox1.Text;
                            t[1] = textBox2.Text;
                            t[2] = textBox3.Text;
                            break;
                    }
                    break;
            }
        }
        public void kryt(int a, int b)
        {
            pr1 = false; pr2 = false;
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            tabl = a;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button7.Visible = false;
            comboBox1.Visible = false;
            maskedTextBox1.Visible = false;
            dateTimePicker1.Visible = false;
            maskedTextBox2.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            if (pictureBox1.Image != null)
            {
                Size = new Size(854, 446);
                pictureBox1.Visible = true;
                label6.Visible = true;
            }
            else
            {
                Size = new Size(625, 446);
                pictureBox1.Visible = false;
                label6.Visible = false;
            }
            switch (a)
            {
                case 0:
                    switch (b)
                    {
                        case 0:
                            label1.Text = "Имя";
                            label2.Text = "Фамилия";
                            label3.Text = "Отчество";
                            label4.Text = "Дата регистрации";
                            label5.Text = "Адрес";
                            textBox1.Text = t[0];
                            textBox2.Text = t[1];
                            textBox3.Text = t[2];
                            textBox4.Text = t[3];
                            dateTimePicker1.Value = DateTime.Parse(t[3]);
                            dateTimePicker1.Visible = true;
                            dateTimePicker1.Location = new Point(374, 233);
                            textBox5.Text = t[4];
                            break;
                        case 1:
                            da = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
                            da.Fill(dt);
                            label1.Text = "Номер паспорта";
                            label2.Text = "Когда выдан паспорт";
                            label3.Text = "Кем выдан паспорт";
                            label4.Text = "Номер аттестата";
                            label5.Text = "Средний балл аттестата";
                            textBox1.Text = t[5];
                            textBox2.Text = t[6];
                            textBox3.Text = t[7];
                            textBox4.Text = t[8];
                            textBox5.Text = t[9];
                            maskedTextBox2.Text = t[5];
                            maskedTextBox2.Visible = true;
                            maskedTextBox2.Location = new Point(12, 233);
                            dateTimePicker1.Visible = true;
                            dateTimePicker1.Location = new Point(132, 233);
                            dateTimePicker1.Value = Convert.ToDateTime(t[6]);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (dt.Rows[i]["Номер паспорта"].ToString() == t[5])
                                {
                                    pr1 = true;
                                }
                                if (dt.Rows[i]["Номер аттестата"].ToString() == t[8])
                                {
                                    pr2 = true;
                                }
                            }
                            if ((pr1 == true) && (pr2 == true))
                            {
                                MessageBox.Show("Номер паспорта и Номер аттестата уже существуют в таблице!");
                            }
                            else
                            {
                                if (pr1 == true)
                                {
                                    MessageBox.Show("Номер паспорта уже существуют в таблице!");
                                }
                                if (pr2 == true)
                                {
                                    MessageBox.Show("Номер аттестата уже существуют в таблице!");
                                }
                            }
                            break;
                        case 2:
                            da = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
                            da.Fill(dt);
                            label1.Text = "Номер телефона";
                            label2.Text = "Дата рождения";
                            label3.Text = "Есть возможность оплачивать?";
                            label4.Text = "Фото абитуриента";
                            label5.Text = "Номер абитуриента";
                            textBox1.Text = t[10];
                            textBox2.Text = t[11];
                            textBox3.Text = t[12];
                            textBox4.Text = t[13];
                            textBox5.Text = t[14];
                            maskedTextBox1.Location = new Point(12, 233);
                            maskedTextBox1.Text = t[10];
                            maskedTextBox1.Visible = true;
                            dateTimePicker1.Visible = true;
                            dateTimePicker1.Location = new Point(132, 233);
                            dateTimePicker1.Value = Convert.ToDateTime(t[11]);
                            comboBox1.Visible = true;
                            comboBox1.Location = new Point(252, 233);
                            if (t[12] == "0")
                            {
                                comboBox1.SelectedValue = "Да";
                            }
                            if (t[12] == "1")
                            {
                                comboBox1.SelectedValue = "Нет";
                            }
                            else
                            {
                                if (t[12] != "0")
                                {
                                    comboBox1.Text = "Выберите";
                                }
                            }
                            button7.Visible = true;
                            button7.Location = new Point(374, 233);
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (dt.Rows[i]["Номер абитуриента"].ToString() == t[14])
                                {
                                    pr1 = true;
                                }
                            }
                            if (pr1 == true)
                            {
                                MessageBox.Show("Номер абитуриента уже существуют в таблице!");
                            }

                            break;
                        default:
                            if (b>2)
                            {
                                prost = 0;
                            }
                            if (b < 0)
                            {
                                prost = 2;
                            }
                            kryt(a, prost);
                            break;
                    }
                    break;
                case 1:
                    switch (b)
                    {
                        case 0:
                            label1.Text = "Номер аттестата ЕГЭ";
                            label2.Text = "Номер абитуриента";
                            label3.Text = "Предметы сдачи";
                            label4.Text = "Общий балл за ЕГЭ";
                            label5.Text = "";
                            textBox1.Text = t[0];
                            textBox2.Text = t[1];
                            textBox3.Text = t[2];
                            textBox4.Text = t[3];
                            button1.Enabled = false;
                            button2.Enabled = false;
                            textBox5.Visible = false;
                            break;
                        default:
                            if (b != 0)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            button1.Enabled = false;
                            button2.Enabled = false;
                            break;
                    }
                    break;
                case 2:
                    switch (b)
                    {
                        case 0:
                            label1.Text = "Номер контракта";
                            label2.Text = "Условия договора";
                            label3.Text = "Адрес предприятия";
                            label4.Text = "Телефон предприятия";
                            label5.Text = "Платят?";
                            maskedTextBox1.Visible = true;
                            maskedTextBox1.Location = new Point(711, 348);
                            maskedTextBox1.Text = t[3];
                            comboBox1.Location = new Point(495, 233);
                            comboBox1.Visible = true;
                            maskedTextBox1.Text = t[4];
                            textBox1.Text = t[0];
                            textBox2.Text = t[1];
                            textBox3.Text = t[2];
                            textBox4.Text = t[3];
                            textBox5.Text = t[4];
                            button1.Enabled = false;
                            button2.Enabled = false;
                            break;
                        default:
                            if (b != 0)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            button1.Enabled = false;
                            button2.Enabled = false;
                            break;
                    }
                    break;
                case 3:
                    switch (b)
                    {
                        case 0:
                            label1.Text = "Номер регистрации абитуриента";
                            label2.Text = "Номер аттестата ЕГЭ";
                            label3.Text = "Факультет";
                            label4.Text = "Специальность";
                            label5.Text = "Фамилия принявшего документы";
                            textBox1.Text = t[0];
                            textBox2.Text = t[1];
                            textBox3.Text = t[2];
                            textBox4.Text = t[3];
                            textBox5.Text = t[4];
                            break;
                        case 1:
                            label1.Text = "Рекомендация для собеседования";
                            label2.Text = "Номер контракта";
                            label3.Text = "Набрано баллов при поступлении";
                            label4.Text = "";
                            label5.Text = "";
                            textBox1.Text = t[5];
                            textBox2.Text = t[6];
                            textBox3.Text = t[7];
                            textBox4.Visible = false;
                            textBox5.Visible = false;
                            break;
                        default:
                            if (b < 0)
                            {
                                prost = 1;
                                kryt(a, prost);
                            }
                            if (b > 1)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            break;
                    }
                    break;
                case 4:
                    switch (b)
                    {
                        case 0:
                            label1.Text = "Номер после зачисления";
                            label2.Text = "Номер регистрации абитуриента";
                            label3.Text = "Основа, на которой зачислен";
                            label4.Text = "";
                            label5.Text = "";
                            textBox1.Text = t[0];
                            textBox2.Text = t[1];
                            textBox3.Text = t[2];
                            textBox4.Visible = false;
                            textBox5.Visible = false;
                            button1.Enabled = false;
                            button2.Enabled = false;
                            break;
                        default:
                            if (b != 0)
                            {
                                prost = 0;
                                kryt(a, prost);
                            }
                            button1.Enabled = false;
                            button2.Enabled = false;
                            break;
                    }
                    break;
            }
        }
        public void table(int a)
        {
            if (a == 0)
            {
                t[3] = DateTime.Now.ToString();
                t[6] = DateTime.Now.ToString();
                t[11] = DateTime.Now.ToString();
            }
            if (a == 1)
            {
                t[3] = "";
                t[6] = "";
                t[11] = "";
            }
            if (a == 2)
            {
                t[3] = "";
                t[6] = "";
                t[11] = "";
            }
            if (a == 3)
            {
                t[3] = "";
                t[6] = "";
                t[11] = "";
            }
            if (a == 4)
            {
                t[3] = "";
                t[6] = "";
                t[11] = "";
            }
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter[] da = new SqlDataAdapter[5];
            da[0] = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
            da[1] = new SqlDataAdapter("select EGE.EGE as [Номер аттестата ЕГЭ], Enrollee.Enrolle as [Номер абитуриента], Lessons as [Предметы которые сдавались], Score as [Общий балл за ЕГЭ] from (Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat) join EGE on Enrollee.Enrolle = EGE.Enrolle", sqlConnect);
            da[2] = new SqlDataAdapter("select ContractID as [Номер контракта], ContractAbout as [Условия договора], ContAdress as [Адрес предприятия], ContPhone as [Телефон предприятия], Payment as [Платят?] from Contract", sqlConnect);
            da[3] = new SqlDataAdapter("select PersonID as [Номер регистрации абитуриента], EGE as [Номер аттестата ЕГЭ], Faculty as [Факультет], Speciality as [Специальность], Registrar as [Фамилия принявшего документы], Talk as [Рекомендация для собеседования], ContractID as [Номер контракта], Result as [Набрано баллов при поступлении] from Commission", sqlConnect);
            da[4] = new SqlDataAdapter("select YesID as [Номер после зачисления], PersonID as [Номер регистрации абитуриента], Type as [Основа, на которой зачислен] from Enrollment", sqlConnect);
            da[a].Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            tabell = a;
            kryt(a,0);
        }
        private void toolStripLabel1_Click(object sender, EventArgs e){table(0);}
        private void button3_Click(object sender, EventArgs e){textbox(tabl, prost);}
        private void button1_Click(object sender, EventArgs e)
        {
            nulll = false;
            textbox(tabell, prost);
            kryt(tabell, prost);
            if ((pr1==false)&&(pr2==false))
            {
                var textboxx = new TextBox[]
          {
                textBox1,textBox2,textBox3,textBox4,textBox5
          };
                for (int i = 0; i < textboxx.Length; i++)
                {
                    if (textboxx[i].Text == "")
                    {
                        nulll = true;
                    }
                }
                if (nulll == true)
                {
                    MessageBox.Show("Введите все данные!");
                }
                else
                {
                    prost--;
                    kryt(tabell, prost);
                }
            }
        }
        private void toolStripLabel2_Click(object sender, EventArgs e){table(1);}
        private void toolStripLabel3_Click(object sender, EventArgs e){table(2);}
        private void toolStripLabel4_Click(object sender, EventArgs e){table(3);}
        private void Form2_Load(object sender, EventArgs e)
        {
            t[12] = "";
            comboBox1.Text = "Выберите";
            table(0);
            kryt(0, 0);
            if (pr == "admin")
            {
                toolStripLabel8.Visible = true;
            }
            else
            {
                toolStripLabel8.Visible = false;
            }
        }
        private void button5_Click(object sender, EventArgs e){Application.Exit();}
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }
        private void toolStripLabel5_Click(object sender, EventArgs e){table(4);}
        public void del()
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
            sqlConnect.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            switch (tabl)
            {
                case 0:
                    try
                    {
                        da = new SqlDataAdapter($"Delete from Enrollee where Enrolle = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value}", sqlConnect);
                        da.Fill(dt);
                        da = new SqlDataAdapter($"Delete from Passport where Passport = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value}", sqlConnect);
                        da.Fill(dt);
                        da = new SqlDataAdapter($"Delete from Attestat where Attestat = {dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[9].Value}", sqlConnect);
                        da.Fill(dt);
                        da = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt.Tables[0];
                    }
                    catch
                    {
                        MessageBox.Show("Попытка удаления несуществующего поля!");
                    }
                    break;
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            del();
        }
        string pic;

        private void button8_Click(object sender, EventArgs e)
        {
            switch (tabl)
            {
                case 0:
                    t[14] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    t[0] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    t[1] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                    t[2] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    t[3] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                    t[4] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    t[5] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                    t[6] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].Value.ToString();
                    t[7] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[8].Value.ToString();
                    t[8] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[9].Value.ToString();
                    t[9] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[10].Value.ToString();
                    t[10] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[11].Value.ToString();
                    t[11] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[12].Value.ToString();
                    t[12] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[13].Value.ToString();
                    t[13] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[14].Value.ToString();
                    prost = 0;
                    break;
            }
            button6.Text = "Изменить";
            kryt(tabl, 0);
            del();
        }
        public void ochishenie()
        {
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = "";
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabl)
            {
                case 0:
                    switch (prost)
                    {
                        case 2:
                            cif(sender, e);
                            break;
                        case 1:
                            cif(sender, e);
                            break;
                    }
                    break;
            }
        }
        public void cif(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar <= '9') && (e.KeyChar >= '0')) || (e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Back))
            {

            }
            else e.KeyChar -= e.KeyChar;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabl)
            {
                case 0:
                    switch (prost)
                    {
                        case 1:
                            cif(sender, e);
                            break;
                        
                    }
                    break;
                case 1:
                    switch (prost)
                    {
                        case 0:
                            cif(sender, e);
                            break;

                    }
                    break;
                case 2:
                    switch (prost)
                    {
                        case 0:
                            cif(sender, e);
                            break;

                    }
                    break;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabl)
            {
                case 0:
                    switch (prost)
                    {
                        case 1:
                            cif(sender, e);
                            break;
                    }
                    break;
                case 1:
                    switch (prost)
                    {
                        case 0:
                            cif(sender, e);
                            break;
                    }
                    break;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabl == 0)
            {
                textBox1.Text = maskedTextBox1.Text;
            }
            if (tabl == 2)
            {
                textBox4.Text = maskedTextBox1.Text;
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabl == 0)
            {
                textBox1.Text = maskedTextBox2.Text;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (tabl)
            {
                case 1:
                    switch (prost)
                    {
                        case 0:
                            cif(sender, e);
                            break;
                    }
                    break;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tabl == 0)
            {
                if (comboBox1.Text == "Да")
                {
                    t[12] = "1";
                }
                if (comboBox1.Text == "Нет")
                {
                    t[12] = "0";
                }
                if ((comboBox1.Text == "Выберите")&&((comboBox1.Text != "Нет") || (comboBox1.Text != "Да")))
                {
                    t[12] = "";
                }
                textBox3.Text = t[12];
            }
            if (tabl == 2)
            {
                if (comboBox1.Text == "Да")
                {
                    t[4] = "1";
                }
                if (comboBox1.Text == "Нет")
                {
                    t[4] = "0";
                }
                if ((comboBox1.Text == "Выберите") && ((comboBox1.Text != "Нет") || (comboBox1.Text != "Да")))
                {
                    t[4] = "";
                }
                textBox5.Text = t[4];
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
                textbox(tabell, prost);
                SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ ПМ01_Попов_СЕ_Приемная_комиссия_университета; Integrated Security = True");
                sqlConnect.Open();
                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                switch (tabl)
                {
                    case 0:
                        try
                        {
                            da = new SqlDataAdapter($"INSERT INTO Passport  VALUES ('{t[5]}','{t[6]}','{t[7]}');", sqlConnect);
                            da.Fill(dt);
                            da = new SqlDataAdapter($"INSERT INTO Attestat  VALUES ('{t[8]}','{t[9]}');", sqlConnect);
                            da.Fill(dt);
                            da = new SqlDataAdapter($"INSERT INTO Enrollee  VALUES ('{t[14]}','{t[0]}','{t[1]}','{t[2]}','{t[3]}','{t[4]}','{t[5]}','{t[8]}','{t[10]}','{t[11]}','{t[12]}','{t[13]}');", sqlConnect);
                            da.Fill(dt);
                            da = new SqlDataAdapter("select Enrollee.Enrolle as [Номер абитуриента] ,Name as [Имя], LastName as [Фамилия], FirthName as [Отчество], Date as [Дата регистрации], Adress as [Адрес], Enrollee.Passport as [Номер паспорта], PassportDate as [Когда выдан паспорт], Region as [Кем выдан паспорт], Enrollee.Attestat as [Номер аттестата], Middle as [Средний балл аттестата], Phone as [Номер телефона], Birth as [Дата рождения], Money as [Есть возможность оплачивать?], Picture as [Фото абитуриента] from Attestat join (Passport join Enrollee on Passport.Passport = Enrollee.Passport) on Attestat.Attestat = Enrollee.Attestat", sqlConnect);
                            da.Fill(dt);
                            dataGridView1.DataSource = dt.Tables[0];
                            ochishenie();
                            t[3] = DateTime.Now.ToString();
                            t[6] = DateTime.Now.ToString();
                            t[11] = DateTime.Now.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Введите данные ключевые данные без повтора! (Номер паспорта, Номер абитуриента, Номер аттестата)");
                        }

                        break;
                    case 1:
                    try
                    {
                        da = new SqlDataAdapter($"INSERT INTO EGE  VALUES ('{t[0]}','{t[1]}','{t[2]}','{t[3]}');", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Введите данные ключевые данные без повтора! (Номер аттестата ЕГЭ, Номер абитуриента)");
                    }
                    break;
                    case 2:
                    try
                    {
                        da = new SqlDataAdapter($"INSERT INTO Contract  VALUES ('{t[0]}','{t[1]}','{t[2]}','{t[3]}','{t[4]}','{t[5]}');", sqlConnect);
                        da.Fill(dt);
                    }
                    catch
                    {
                        MessageBox.Show("Введите данные ключевые данные без повтора! ()");
                    }
                    break;
                    case 3:

                        da = new SqlDataAdapter($"INSERT INTO Commission  VALUES ('{t[0]}','{t[1]}','{t[2]}','{t[3]}','{t[4]}','{t[5]}','{t[6]}','{t[7]}');", sqlConnect);
                        da.Fill(dt);
                        break;
                    case 4:

                        da = new SqlDataAdapter($"INSERT INTO Enrollment  VALUES ('{t[0]}','{t[1]}','{t[2]}');", sqlConnect);
                        da.Fill(dt);
                        break;
                }
            if (button6.Text == "Изменить")
            {
                button6.Text = "Создать запись";
            }
                prost = 0;
                kryt(tabl, 0);
           
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabl == 0)
            {
                try
                {
                    pic = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[14].Value.ToString();
                    pictureBox1.Image = Image.FromFile(pic);
                    if (pictureBox1.Image != null)
                    {
                        Size = new Size(854, 446);
                        pictureBox1.Visible = true;
                        label6.Visible = true;
                    }

                }
                catch
                {
                    MessageBox.Show("Отсутствует изображение");
                }
            }
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tabl == 0)
                {
                    textBox4.Text = openFileDialog1.FileName;
                    t[13] = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            nulll = false;
            textbox(tabell, prost);
            kryt(tabell, prost);
            if ((pr1 == false) && (pr2 == false))
            {
                var textboxx = new TextBox[]
           {
                textBox1,textBox2,textBox3,textBox4,textBox5
           };
                for (int i = 0; i < textboxx.Length; i++)
                {
                    if (textboxx[i].Text == "")
                    {
                        nulll = true;
                    }
                }
                if (nulll == true)
                {
                    MessageBox.Show("Введите все данные!");
                }
                else
                {
                    prost++;
                    kryt(tabell, prost);
                }
            }

        }
    }
}
