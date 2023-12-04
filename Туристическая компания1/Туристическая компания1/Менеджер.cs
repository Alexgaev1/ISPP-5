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

namespace Туристическая_компания1
{
    public partial class Менеджер : Form
    {
        public Менеджер()
        {
            InitializeComponent();
        }
        string r;
        public void ii(string b)
        {
            r = b;
            i1();
        }
        public void i1()
        {
            if (r == "Менеджер")
            {
                Text = "Менеджер";
            }
        }
        public void Tub(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Шипицына_ОИ; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] so = new SqlDataAdapter[7];
            so[0] = new SqlDataAdapter("select * from Констракты", sqlConnect);
            so[1] = new SqlDataAdapter("select * from Клиенты", sqlConnect);
            so[2] = new SqlDataAdapter("select * from Документы", sqlConnect);
            so[3] = new SqlDataAdapter("select * from Маршруты", sqlConnect);
            so[4] = new SqlDataAdapter("select * from [Пункты маршрута]", sqlConnect);
            so[5] = new SqlDataAdapter("select * from Гостиница", sqlConnect);
            so[6] = new SqlDataAdapter("select * from Экскурсии", sqlConnect);
            DataSet ps = new DataSet();
            so[i].Fill(ps);
            dataGridView1.DataSource = ps.Tables[0];
        }
        public Boolean a = false;
        public Boolean b = false;
        int t;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }
        private void Менеджер_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии". При необходимости она может быть перемещена или удалена.
            this.экскурсииTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Экскурсии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута". При необходимости она может быть перемещена или удалена.
            this.пункты_маршрутаTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Пункты_маршрута);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Контракты". При необходимости она может быть перемещена или удалена.
            this.контрактыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Контракты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Документы". При необходимости она может быть перемещена или удалена.
            this.документыTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Документы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница". При необходимости она может быть перемещена или удалена.
            this.гостиницаTableAdapter.Fill(this.уП01_ИСПП5_Шипицына_ОИDataSet.Гостиница);

        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Tub(0);
            t = 0;
            a = true;
            dataGridView1.ReadOnly = false;
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Tub(1);
            t = 1;
            a = true;
            dataGridView1.ReadOnly = false;
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Tub(2);
            t = 2;
            a = true;
            dataGridView1.ReadOnly = false;
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Tub(3);
            t = 3;
            a = true;
            dataGridView1.ReadOnly = false;
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Tub(4);
            t = 4;
            a = true;
            dataGridView1.ReadOnly = false;
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Tub(5);
            t = 5;
            a = true;
            dataGridView1.ReadOnly = false;
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Tub(6);
            t = 6;
            a = true;
            dataGridView1.ReadOnly = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
