﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП01_ИСПП_5_Работягова_АА
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Клиенты);

        }
        string a;
        public void st(string s)
        {
            a = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            клиентыTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Клиенты);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form5 = new Form5();
            form5.Show();
            form5.ii(a);
        }
    }
}
