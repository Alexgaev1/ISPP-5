﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using УП01_ИСПП_5_Работягова_АА.УП01_ИСПП5_Работягова_ААDataSetTableAdapters;

namespace УП01_ИСПП_5_Работягова_АА
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Работягова_ААDataSet.Агенты". При необходимости она может быть перемещена или удалена.
            this.агентыTableAdapter.Fill(this.уП01_ИСПП5_Работягова_ААDataSet.Агенты);

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
            агентыTableAdapter.Update(уП01_ИСПП5_Работягова_ААDataSet.Агенты);
        
        }
    }
}
