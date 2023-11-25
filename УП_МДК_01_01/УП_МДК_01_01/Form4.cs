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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Продление". При необходимости она может быть перемещена или удалена.
            this.продлениеTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Продление);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Договоры". При необходимости она может быть перемещена или удалена.
            this.договорыTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Договоры);

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

        private void button1_Click(object sender, EventArgs e)
        {
            продлениеTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Продление);
            договорыTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Договоры);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            продлениеTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Продление);
            договорыTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Договоры);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
           fKПродлениеДоговорыBindingSource.CancelEdit();
            договорыBindingSource.CancelEdit();
        }
    }
}
