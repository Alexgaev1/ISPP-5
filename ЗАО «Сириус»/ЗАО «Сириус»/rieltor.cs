using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗАО__Сириус_
{
    public partial class rieltor : Form
    {
        SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security=True");
        public rieltor()
        {
            InitializeComponent();
            sqlConnect.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
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

        private void rieltor_Load(object sender, EventArgs e)
        {

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
    }
}
