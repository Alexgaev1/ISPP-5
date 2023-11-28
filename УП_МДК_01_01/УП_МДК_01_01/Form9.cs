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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet1.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet1.Пользователи);

        }
        string a;
        public void st(string s)
        {
            a = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            пользователиTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet1.Пользователи);
        }
    }
}
