﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Проект
{
    public partial class Commander : Form
    {
        public Commander()
        {
            InitializeComponent();
        }

        private void Commander_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие". При необходимости она может быть перемещена или удалена.
            this.военнослужащиеTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Военнослужащие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности". При необходимости она может быть перемещена или удалена.
            this.удостверение_личностиTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Удостверение_личности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры". При необходимости она может быть перемещена или удалена.
            this.командирыTableAdapter.Fill(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры);

        }
        public void searchInDataGridView()
        {
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                dataGridView2.Rows[j].Selected = false;
                if (dataGridView2.Rows[j].Cells[0].Value != null)
                {
                    if (dataGridView2.Rows[j].Cells[0].Value.ToString().Contains(textBox1.Text))
                    {

                        dataGridView2.Rows[j].Selected = true;
                        dataGridView2.CurrentCell = dataGridView2[0, j];
                        break;
                    }
                }
            }
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                dataGridView3.Rows[j].Selected = false;
                if (dataGridView3.Rows[j].Cells[0].Value != null)
                {
                    if (dataGridView3.Rows[j].Cells[0].Value.ToString().Contains(label5.Text))
                    {

                        dataGridView3.Rows[j].Selected = true;
                        dataGridView3.CurrentCell = dataGridView3[0, j];
                        break;
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchInDataGridView();
            командирыTableAdapter.Update(уП_ПМ01_ИСПП_5_Степурин_НСDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            if ((i - 1) <= index) { dataGridView1.CurrentCell = dataGridView1[0, 0]; }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, index + 1];
            }
            searchInDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.RowCount;
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[index].Selected = true;
            if (index != 0)
            {
                dataGridView1.CurrentCell = dataGridView1[0, index - 1];
            }
            else
            {
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, i - 1];
            }
            searchInDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"DELETE FROM  Командиры  WHERE Код_Командира = {label4.Text}; ", sqlConnect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            командирыTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП_ПМ01_ИСПП_5_Степурин_НС; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter da = new SqlDataAdapter($"INSERT   INTO   Командиры(Код_удовстверения) VALUES({textBox1.Text});", sqlConnect); ;
            DataTable dt = new DataTable();
            da.Fill(dt);
            командирыTableAdapter.Fill(уП_ПМ01_ИСПП_5_Степурин_НСDataSet.Командиры);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Passport passport = new Passport();
            passport.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Battalion battalion = new Battalion();
            battalion.Show();
            this.Hide();
        }
        int k=0; 
        private void button8_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                dataGridView1.Visible = true;
                panel1.Location = new Point(278, 13);
                this.Width = 622;

                k = 1;
            }
            else
            {
                dataGridView1.Visible = false;
                panel1.Location = new Point(12, 12);
                this.Width = 350;

                k = 0;
            }
        }
    }
}
