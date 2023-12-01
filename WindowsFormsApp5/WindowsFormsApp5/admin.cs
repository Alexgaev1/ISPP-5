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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        string a;

        public void ii(string b)
        {
            a = b;
            i1();
        }
        public void i1()
        {
            if (a == "Сотрудник")
            {
                Text = "Панель Сотрудника";
                button1.Visible = false;
                button2.Location = new Point (12,23);
                button3.Location = new Point(12, 73);
                button4.Location = new Point(12, 121);

            }
            if (a == "Админ")
            {
                Text = "Панель Администратора";
                button1.Visible = true;

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "б_АЮ_Учебная_ПрактикаDataSet.Users". При необходимости она может быть перемещена или удалена.
            //this.usersTableAdapter.Fill(this.б_АЮ_Учебная_ПрактикаDataSet.Users);
            

            }

            private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users AdmFrm = new Users();
            AdmFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            buildings AdmFr = new buildings();
            AdmFr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            entrance AdmFr = new entrance();
            AdmFr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms AdmFr = new Rooms();
            AdmFr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Record AdmFr = new Record();
            AdmFr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            decoration AdmFr = new decoration();
            AdmFr.Show();
        }
    }
}
