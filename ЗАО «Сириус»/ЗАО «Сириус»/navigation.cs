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
    public partial class navigation : Form
    {
        SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = УП01_ИСПП_5_Демешко_ЕО; Integrated Security=True");

        public navigation()
        {
            InitializeComponent();
            sqlConnect.Open();
        }

        //private const string ConnectionString = ("Data Source=sql;Initial Catalog=УП01_ИСПП_5_Демешко_ЕО;Integrated Security=True");
        //private SqlConnection connection; // Подключение к базе данных
        private SqlDataAdapter dataAdapter; // Адаптер данных
        //private DataTable dataTable; // Таблица данных
        private void navigation_Load(object sender, EventArgs e)
        {


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
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //panel2 Visible ?
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

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == помещенияBindingSource)
            {
                room room = new room();
                room.ShowDialog();
                помещенияBindingSource.DataSource = GetDataFromDatabase("SELECT * FROM Помещения");
            }
            if (dataGridView1.DataSource == риелторыBindingSource)
            {
                rieltor_zapolneniye rieltor = new rieltor_zapolneniye();
                rieltor.ShowDialog();
                риелторыBindingSource.DataSource = GetDataFromDatabase("SELECT * FROM Риелторы");
            }
            if (dataGridView1.DataSource == арендаторыBindingSource)
            {
                arendatori arendatori = new arendatori();
                arendatori.ShowDialog();
            }
            if (dataGridView1.DataSource == осмотрПомещенийBindingSource)
            {
                osmotr osmotr = new osmotr();
                osmotr.ShowDialog();
            }
            if (dataGridView1.DataSource == договорыBindingSource)
            {
                dogovori dogovori = new dogovori();
                dogovori.ShowDialog();
                договорыBindingSource.DataSource = GetDataFromDatabase("SELECT * FROM Договоры");
            }
        }
        private DataTable GetDataFromDatabase(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog=УП01_ИСПП_5_Демешко_ЕО;" +
                    "Integrated Security=True"))
                {
                    sqlConnect.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConnect);
                    da.Fill(dt);
                    sqlConnect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return dt;
        }

        //private void toolStripButton2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string query = "SELECT * FROM Помещения";
        //        помещенияBindingSource.DataSource = GetDataFromDatabase(query);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navigation_Click(object sender, EventArgs e)
        {
            
        }

        private void navigation_Activated(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

