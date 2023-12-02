using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП01_ИСПП5_Швидко_ИА
{
    public partial class Покупатель : Form
    {
        public Покупатель()
        {
            InitializeComponent();
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }
        public void Tob(int i)             //Добавляет таблицы
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=sql;Initial Catalog = уП01_ИСПП5_Швидко_ИА; Integrated Security = True");
            sqlConnect.Open();
            SqlDataAdapter[] so = new SqlDataAdapter[2];
            so[0] = new SqlDataAdapter("select Название_растения, Название_сорта, Год_выведения, Адаптация, Морозоустойчивость, Способ_посадки, Фотография, Срок_созревания_в_днях, Примечание, Наличие_в_текущее_время from Сорта_растений", sqlConnect);
            so[1] = new SqlDataAdapter("select Срок_годности, Одобрено_инспекцией, Вид_упаковки, Количество_в_упаковке, Цена, Дата_расфасовки, Вес_семян_в_граммах, Код_сорта_растения from Упаковки_семян", sqlConnect);
            DataSet ps = new DataSet();
            so[i].Fill(ps);
            Поле_для_таблиц_DataGridView1.DataSource = ps.Tables[0];
        }

        private void вернуться_Click(object sender, EventArgs e)        //Переходит на форму 'Авторизация'
        {
            Авторизация AvtFrm = new Авторизация();
            AvtFrm.Show();
            this.Hide();
        }

        private void Таблица_Сорта_растений_Click(object sender, EventArgs e)                   //Открывает таблицу 'Сорта растени'
        {
            Tob(0);
            Фотография_представителя_PictureBox2.Visible = true;
            Поле_для_таблиц_DataGridView1.Size = new Size(598, 301);
        }

        private void Таблица_Упаковки_семян_Click(object sender, EventArgs e)                    //Открывает таблицу 'Упаковки семян'
        {
            Tob(1);
            Фотография_представителя_PictureBox2.Visible = false;
            Поле_для_таблиц_DataGridView1.Size = new Size(794, 301);
        }

        private void Покупатель_Load(object sender, EventArgs e)                                 //Загрузка данных в таблицы
        {
            this.упаковки_семянTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Упаковки_семян);
            this.сорта_растенийTableAdapter.Fill(this.уП01_ИСПП5_Швидко_ИАDataSet.Сорта_растений);
        }

        private void выйти_Click(object sender, EventArgs e)      //Прекращает работу программы
        {
            Application.Exit();
        }

        private void Поисковая_строка_TextChanged(object sender, EventArgs e)          //Выделение строки, которая подходит под введённые данные в поисковую строку
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
        private void Покупатель_MouseMove(object sender, MouseEventArgs e)       //Перемещает форму при удержании мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - Mouse.X;
                Top += e.Y - Mouse.Y;
            }
        }

        private void Покупатель_MouseDown(object sender, MouseEventArgs e)       //Перемещает форму при удержании мыши
        {
            Mouse = new Point(e.X, e.Y);
        }
        string pic;
        private void Поле_для_таблиц_DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)       //Изменение фотографий при нажатие на разные строки
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
