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
    public partial class director : Form
    {
        SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security=True");
        public director()
        {
            InitializeComponent();
            sqlConnect.Open();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Помещения", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (panel2.Visible == false)
                panel2.Visible = true;
            помещенияBindingSource.DataSource = dt;
            bindingNavigator1.BindingSource = помещенияBindingSource;
            dataGridView1.DataSource = помещенияBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Риелторы", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (panel2.Visible == false)
                panel2.Visible = true;

            риелторыBindingSource.DataSource = dt;
            bindingNavigator1.BindingSource = риелторыBindingSource;
            dataGridView1.DataSource = риелторыBindingSource;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Арендаторы", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (panel2.Visible == false)
                panel2.Visible = true;

            арендаторыBindingSource.DataSource = dt;
            bindingNavigator1.BindingSource = арендаторыBindingSource;
            dataGridView1.DataSource = арендаторыBindingSource;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from [Осмотр помещений]", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (panel2.Visible == false)
                panel2.Visible = true;

            осмотрПомещенийBindingSource.DataSource = dt;
            bindingNavigator1.BindingSource = осмотрПомещенийBindingSource;
            dataGridView1.DataSource = осмотрПомещенийBindingSource;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Договоры", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (panel2.Visible == false)
                panel2.Visible = true;

            договорыBindingSource.DataSource = dt;
            bindingNavigator1.BindingSource = договорыBindingSource;
            dataGridView1.DataSource = договорыBindingSource;
        }

        private void director_Load(object sender, EventArgs e)
        {
           
        }
    }
}
