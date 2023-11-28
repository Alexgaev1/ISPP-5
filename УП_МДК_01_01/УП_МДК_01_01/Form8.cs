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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet2.Дома". При необходимости она может быть перемещена или удалена.
            this.домаTableAdapter1.Fill(this.уП01_ИСПП5_Работягова_ААDataSet2.Дома);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet2.Фотографии_домов". При необходимости она может быть перемещена или удалена.
            this.фотографии_домовTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet2.Фотографии_домов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet1.Дома". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet1.Пользователи". При необходимости она может быть перемещена или удалена.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            домаTableAdapter1.Update(уП01_ИСПП5_Работягова_ААDataSet2.Дома);
            фотографии_домовTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet2.Фотографии_домов);
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

        private void pictureView_Click(object sender, EventArgs e)
        {
            
        }
    }
}
