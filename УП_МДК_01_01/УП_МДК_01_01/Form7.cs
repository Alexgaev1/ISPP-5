using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП_МДК_01_01
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Договоры". При необходимости она может быть перемещена или удалена.
            this.договорыTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Договоры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Дома". При необходимости она может быть перемещена или удалена.
            this.домаTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Дома);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Квартиры". При необходимости она может быть перемещена или удалена.
            this.квартирыTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Квартиры);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            домаTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Дома);
                квартирыTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Квартиры);
        }
        string a;
        public void st(string s)
        {
            a = s;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.Show();
            form5.ii(a);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            домаTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Дома);
            квартирыTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Квартиры);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            квартирыBindingSource.CancelEdit();
            домаBindingSource.CancelEdit();
        }
    }
}
