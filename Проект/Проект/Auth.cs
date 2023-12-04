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
        int j = 0;
        public Auth()
        {
            InitializeComponent();
        }
    
        
        private void buttonLogin_Click(object sender, EventArgs e)
        { 

            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();

            
            SqlDataAdapter da = new SqlDataAdapter("select * from Auth", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Boolean flag=false;

            //Проверка созданных пользователей

            for (int i = 0; i < dt.Rows.Count; i++)
                if ((dt.Rows[i]["login"].ToString() == textBoxLog.Text) && (dt.Rows[i]["password"].ToString() == textBoxPass.Text)) { j = i;flag = true; }
                    
            //Разграничение прав доступа

            if (flag == true)
                    switch (dt.Rows[j]["Rule"].ToString())
                    {
                        case "Администратор":
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                            break;
                        case "Начальник":
                            Commander commander = new Commander();
                            commander.Show();
                            this.Hide();
                            break;
                        case "Рекрутер":
                            Soldier soldier = new Soldier();
                            soldier.Show();
                            this.Hide();
                            break;
                    }
            else MessageBox.Show("ТЕБЕ ТУТ НЕ МЕСТО");  
              
        }

       

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        Boolean flag = false;
        private void buttonVisPass_Click(object sender, EventArgs e)
        {
            //показать или сокрыть видимость пароля
            
            if (flag == false) 
            {
                textBoxPass.PasswordChar ='\0';
                flag = true;

            }
            else if (flag==true) 
            {
                textBoxPass.PasswordChar = '*';
                flag = false;

            }     
        }
    }
}
