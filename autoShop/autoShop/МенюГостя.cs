using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoShop
{
    public partial class МенюГостя : Form
    {
        public МенюГостя()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 logForm = new Form2();
            logForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказы orders = new Заказы();
            orders.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ДобавлениеКлиента client = new ДобавлениеКлиента();
            client.Show();
            this.Close();
        }
    }
}
