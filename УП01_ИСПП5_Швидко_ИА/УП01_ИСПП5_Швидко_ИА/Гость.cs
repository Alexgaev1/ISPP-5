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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Гость : Form
    {
        public Гость()
        {
            InitializeComponent();
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        public void Tob(int i)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] so = new SqlDataAdapter[2];
            so[0] = new SqlDataAdapter("select Название_растения, Название_сорта, Год_выведения, Адаптация, Морозоустойчивость, Способ_посадки, Фотография_представителя_сорта, Срок_созревания_в_днях, Примечание, Наличие_в_текущее_время from Сорта_растений", sqlConnect);
            so[1] = new SqlDataAdapter("select Срок_годности, Одобрено_инспекцией, Вид_упаковки, Количество_в_упаковке, Цена, Дата_расфасовки, Вес_семян_в_упаковке, Код_сорта_растения from Упаковки_семян", sqlConnect);
            DataSet ps = new DataSet();
            so[i].Fill(ps);
            Поле_для_таблиц_DataGridView1.DataSource = ps.Tables[0];
        }
        private void Гость_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян". При необходимости она может быть перемещена или удалена.
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений". При необходимости она может быть перемещена или удалена.
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян". При необходимости она может быть перемещена или удалена.

        }

        private void вернуться_Click(object sender, EventArgs e)
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void выйти_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Таблица_Сорта_растений_Click(object sender, EventArgs e)
        {
            Tob(0);
            Фотография_представителя_PictureBox2.Visible = true;
            Поле_для_таблиц_DataGridView1.Size = new Size(598, 301);
        }

        private void Таблица_Упаковки_семян_Click(object sender, EventArgs e)
        {
            Tob(1);
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Поисковая_строка_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Поле_для_таблиц_DataGridView1.RowCount; i++)
            {
                Поле_для_таблиц_DataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < Поле_для_таблиц_DataGridView1.ColumnCount; j++)
                    if (Поле_для_таблиц_DataGridView1.Rows[i].Cells[j].Value != null)
                        if (Поле_для_таблиц_DataGridView1.Rows[i].Cells[j].Value.ToString().Contains(Строка_поиска_TextBox1.Text))
                        {
                            Поле_для_таблиц_DataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        Point Mouse;
        private void Гость_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Гость_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = new Point(e.X, e.Y);
        }
        string pic;
        private void Поле_для_таблиц_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pic = Поле_для_таблиц_DataGridView1.Rows[Поле_для_таблиц_DataGridView1.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                Фотография_представителя_PictureBox2.Image = Image.FromFile(pic);
            }
            catch { }
        }
    }
}
