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
    public partial class guest : Form
    {
        SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security=True");
        public guest()
        {
            InitializeComponent();
            sqlConnect.Open();
        }

        private void guest_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
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
    }
}
