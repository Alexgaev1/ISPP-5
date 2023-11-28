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

namespace Проект
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        int j = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Auth", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean flag=false;
            
            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i]["login"].ToString() == textBox1.Text) && (dt.Rows[i]["password"].ToString() == textBox2.Text)) { j = i;flag = true; }
                    

            if (flag == true)
                    switch (dt.Rows[j]["Rule"].ToString())
                    {
                        case "Админ":
                            Commander commander = new Commander();
                            commander.Show();
                            this.Hide();
                            break;
                        case "нач":
                            Passport passport = new Passport();
                            passport.Show();
                            this.Hide();
                            break;
                        case "ку":
                            Soldier soldier = new Soldier();
                            soldier.Show();
                            this.Hide();
                            break;
                    }
            else MessageBox.Show("ТЕБЕ ТУТ НЕ МЕСТО");  
           
                    
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Auth". При необходимости она может быть перемещена или удалена.
            this.authTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Auth);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
