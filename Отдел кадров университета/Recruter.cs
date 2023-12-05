using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Text;
using Microsoft.SqlServer.Server;
using System.IO;
using Отдел_кадров_университета.УП01_ИСПП_5_Гаевский_ААDataSetTableAdapters;
using System.Data.Common;
using System.Security.Cryptography;
using System.Reflection;
using System.Globalization;
using System.Drawing.Imaging;

namespace Отдел_кадров_университета
{
    public partial class Recruter : Form
    {
        public Recruter()
        {
            InitializeComponent();
        }

        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        private int x, y;
        private int indexOfPanel = 7;
        private int indexOfDataGridView = 0;
        private string nameOfTable = null;

        private const int widthFlowLayoutPanel = 95;
        private const int heightFlowLayoutPanel = 60;



        private void Recruter_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Отдел_кадров_университета.Properties.Settings.УП01_ИСПП_5_Гаевский_ААConnectionString"].ConnectionString);

            sqlConnection.Open();

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.Click += HideFlowLayoutPanel;

            panel8.Click += HideFlowLayoutPanel;

            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dataGridView3.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ОбразованиеСотрудников". При необходимости она может быть перемещена или удалена.
            this.образованиеСотрудниковTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ОбразованиеСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ДисциплинарныеМерыВОтношенииСотрудников". При необходимости она может быть перемещена или удалена.
            this.дисциплинарныеМерыВОтношенииСотрудниковTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ДисциплинарныеМерыВОтношенииСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОПредыдущемРабочемМесте". При необходимости она может быть перемещена или удалена.
            this.информацияОПредыдущемРабочемМестеTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОПредыдущемРабочемМесте);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОРабочемМестеСотрудников". При необходимости она может быть перемещена или удалена.
            this.информацияОРабочемМестеСотрудниковTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОРабочемМестеСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ЛичнаяИнформацияСотрудников". При необходимости она может быть перемещена или удалена.
            this.личнаяИнформацияСотрудниковTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ЛичнаяИнформацияСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ТрудовойДоговор". При необходимости она может быть перемещена или удалена.
            this.трудовойДоговорTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ТрудовойДоговор);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button6.Location.X + button6.Size.Width;
            y = button6.Location.Y;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 200;
            flowLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            flowLayoutPanel1.Visible = true;

            Button buttonТрудовыеДоговоры = new Button();
            buttonТрудовыеДоговоры.Text = "Трудовые договоры";
            buttonТрудовыеДоговоры.Width = flowLayoutPanel1.Width - 5;
            buttonТрудовыеДоговоры.Click += buttonТрудовыеДоговоры_Click;
            flowLayoutPanel1.Controls.Add(buttonТрудовыеДоговоры);
        }
        private void buttonТрудовыеДоговоры_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;

            indexOfPanel = 7;
            indexOfDataGridView = 0;
            nameOfTable = "ТрудовойДоговор";

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.DataSource = трудовойДоговорbindingSource;

            dataGridView3.Columns["КодТрудовогоДоговора"].HeaderText = "Код трудового договора";
            dataGridView3.Columns["РегистрационныйНомерСотрудника"].HeaderText = "Регистрационный номер сотрудника";
            dataGridView3.Columns["КодРабочегоМеста"].HeaderText = "Код рабочего места";
            dataGridView3.Columns["КоличествоРабочихСроков"].HeaderText = "Количество рабочих сроков";
            dataGridView3.Columns["ДатаНачалаТрудовойДеятельности"].HeaderText = "Дата начала трудовой деятельности";
            dataGridView3.Columns["ДатаОкончанияТрудовойДеятельности"].HeaderText = "Дата окончания трудовой деятельности";

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dataGridView3, new object[] { true });

            dataGridView3.Scroll += (scrollSender, scrollEventArgs) =>
            {
                if (scrollEventArgs.ScrollOrientation == ScrollOrientation.VerticalScroll)
                {
                    dataGridView3.FirstDisplayedScrollingRowIndex = scrollEventArgs.NewValue;
                }
                else if (scrollEventArgs.ScrollOrientation == ScrollOrientation.HorizontalScroll)
                {
                    dataGridView3.FirstDisplayedScrollingColumnIndex = scrollEventArgs.NewValue;
                }
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button2.Location.X + button2.Size.Width;
            y = button2.Location.Y;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 150;
            flowLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            flowLayoutPanel1.Visible = true;

            Button buttonСотрудники = new Button();
            buttonСотрудники.Text = "Сотрудники";
            buttonСотрудники.Width = flowLayoutPanel1.Width - 5;
            buttonСотрудники.BackColor = button2.BackColor;
            buttonСотрудники.Click += buttonСотрудники_Click;
            flowLayoutPanel1.Controls.Add(buttonСотрудники);
        }

        private void buttonСотрудники_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;

            indexOfPanel = 7;
            indexOfDataGridView = 1;
            nameOfTable = "Сотрудники";

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.DataSource = сотрудникиbindingSource;

            int imageColumnIndex = 6;
            int desiredColumnWidth = 200;
            int desiredColumnHeight = 200;

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                if (column.Index != imageColumnIndex)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }

            dataGridView3.Columns[imageColumnIndex].Width = desiredColumnWidth;

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[imageColumnIndex].Value is Image image)
                {
                    Image resizedImage = new Bitmap(image, desiredColumnWidth, desiredColumnHeight);

                    row.Cells[imageColumnIndex].Value = resizedImage;
                }

                row.Height = desiredColumnHeight + dataGridView3.RowTemplate.Height - dataGridView3.DefaultCellStyle.Padding.Vertical;
            }

            dataGridView3.Columns["РегистрационныйНомерСотрудника"].HeaderText = "Регистрационный номер сотрудника";
            dataGridView3.Columns["Дата_рождения"].HeaderText = "Дата рождения";
            dataGridView3.Columns["Место_рождения"].HeaderText = "Место рождения";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button3.Location.X + button3.Size.Width;
            y = button3.Location.Y;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 200;
            flowLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            flowLayoutPanel1.Visible = true;

            Button buttonЛичнаяИнформацияСотрудников = new Button();
            buttonЛичнаяИнформацияСотрудников.Text = "Личная ифнормация сотрудников";
            buttonЛичнаяИнформацияСотрудников.Width = flowLayoutPanel1.Width - 5;
            buttonЛичнаяИнформацияСотрудников.Click += buttonЛичнаяИнформацияСотрудников_Click;
            flowLayoutPanel1.Controls.Add(buttonЛичнаяИнформацияСотрудников);
        }

        private void buttonЛичнаяИнформацияСотрудников_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;

            indexOfPanel = 7;
            indexOfDataGridView = 2;
            nameOfTable = "ЛичнаяИнформацияСотрудников";

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.DataSource = личнаяИнформацияСотрудниковbindingSource;

            dataGridView3.Columns["КодЛичнойИнформацииСотрудника"].HeaderText = "Код личной информации сотрудника";
            dataGridView3.Columns["РегистрационныйНомерСотрудника"].HeaderText = "Регистрационный номер сотрудника";
            dataGridView3.Columns["ДатаВыдачиПаспорта"].HeaderText = "Дата выдачи паспорта";
            dataGridView3.Columns["КемВыдан"].HeaderText = "Кем выдан";
            dataGridView3.Columns["ДомашнийАдрес"].HeaderText = "Домашний адрес";
            dataGridView3.Columns["ДомашнийТелефон"].HeaderText = "Домашний телефон";
            dataGridView3.Columns["АдресЭлектроннойПочты"].HeaderText = "Адрес электронной почты";

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button4.Location.X + button4.Size.Width;
            y = button4.Location.Y;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 200;
            flowLayoutPanel1.Height = 120;
            flowLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            flowLayoutPanel1.Visible = true;

            Button buttonРабочееМестоСотрудника = new Button();
            buttonРабочееМестоСотрудника.Text = "Рабочие места";
            buttonРабочееМестоСотрудника.Width = flowLayoutPanel1.Width - 5;
            buttonРабочееМестоСотрудника.Click += buttonРабочееМестоСотрудника_Click;
            flowLayoutPanel1.Controls.Add(buttonРабочееМестоСотрудника);

            Button buttonБывшееРабочееМестоСотрудника = new Button();
            buttonБывшееРабочееМестоСотрудника.Text = "Предыдущие рабочие места";
            buttonБывшееРабочееМестоСотрудника.Width = flowLayoutPanel1.Width - 5;
            buttonБывшееРабочееМестоСотрудника.Click += buttonБывшееРабочееМестоСотрудника_Click;
            flowLayoutPanel1.Controls.Add(buttonБывшееРабочееМестоСотрудника);
        }

        private void buttonБывшееРабочееМестоСотрудника_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;

            indexOfPanel = 7;
            indexOfDataGridView = 3;
            nameOfTable = "ИнформацияОПредыдущемРабочемМесте";

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.DataSource = информацияОПредыдущемРабочемМестеbindingSource;

            dataGridView3.Columns["КодПредыдущегоРабочегоМеста"].HeaderText = "Код предыдущего рабочего места";
            dataGridView3.Columns["РегистрационныйНомерСотрудника"].HeaderText = "Регистрационный номер сотрудника";
            dataGridView3.Columns["НазваниеПредприятия"].HeaderText = "Название предприятия";
            dataGridView3.Columns["ДатаУстройства"].HeaderText = "Дата устройства";
            dataGridView3.Columns["ДатаУвольнения"].HeaderText = "Дата увольнения";
            dataGridView3.Columns["ПричинаУвольнения"].HeaderText = "Причина увольнения";
            dataGridView3.Columns["АдресПредприятия"].HeaderText = "Адрес предприятия";
            dataGridView3.Columns["ТелефонПредприятия"].HeaderText = "Телефон предприятия";

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
        }
        private void buttonРабочееМестоСотрудника_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;

            indexOfPanel = 7;
            indexOfDataGridView = 4;
            nameOfTable = "ИнформацияОРабочемМестеСотрудников";

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.DataSource = информацияОРабочемМестеСотрудниковbindingSource;

            dataGridView3.Columns["КодРабочегоМеста"].HeaderText = "Код рабочего места";
            dataGridView3.Columns["РегистрационныйНомерСотрудника"].HeaderText = "Регистрационный номер сотрудника";
            dataGridView3.Columns["НазваниеКафедры"].HeaderText = "Название кафедры";
            dataGridView3.Columns["ЗанимаемаяДолжность"].HeaderText = "Занимаемая должность";

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button5.Location.X + button5.Size.Width;
            y = button5.Location.Y;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 200;
            flowLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            flowLayoutPanel1.Visible = true;

            Button buttonДисциплинарныеМеры = new Button();
            buttonДисциплинарныеМеры.Text = "Дисциплинарные меры";
            buttonДисциплинарныеМеры.Width = flowLayoutPanel1.Width - 5;
            buttonДисциплинарныеМеры.Click += buttonДисциплинарныеМеры_Click;
            flowLayoutPanel1.Controls.Add(buttonДисциплинарныеМеры);
        }

        private void buttonДисциплинарныеМеры_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;

            indexOfPanel = 7;
            indexOfDataGridView = 5;
            nameOfTable = "ДисциплинарныеМерыВОтношенииСотрудников";

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.DataSource = дисциплинарныеМерыВОтношенииСотрудниковbindingSource;

            dataGridView3.Columns["КодДисциплинарнойМеры"].HeaderText = "Код дисциплинарной меры";
            dataGridView3.Columns["РегистрационныйНомерСотрудника"].HeaderText = "Регистрационный номер сотрудника";
            dataGridView3.Columns["СведенияОВзысканиях"].HeaderText = "Сведения о взысканиях";
            dataGridView3.Columns["СведенияОНаграждениях"].HeaderText = "Сведения о награждениях";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button7.Location.X + button7.Size.Width;
            y = button7.Location.Y;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 200;
            flowLayoutPanel1.BackColor = Color.FromArgb(192, 192, 255);
            flowLayoutPanel1.Visible = true;

            Button buttonОбразованиеСотрудников = new Button();
            buttonОбразованиеСотрудников.Text = "Образование сотрудников";
            buttonОбразованиеСотрудников.Width = flowLayoutPanel1.Width - 5;
            buttonОбразованиеСотрудников.Click += buttonОбразованиеСотрудников_Click;
            flowLayoutPanel1.Controls.Add(buttonОбразованиеСотрудников);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization UserForm = new Authorization();
            UserForm.Show();
        }
    
        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Image defaultImage = Resource1.Noname;
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                e.ThrowException = false;
                e.Cancel = true;
                dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = defaultImage;
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                bool isMatch = false; 

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        isMatch = true; 
                        break;
                    }
                }

                if (isMatch)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = dataGridView3.DefaultCellStyle.BackColor;
                }
            }
        }

        private void Recruter_Click(object sender, EventArgs e)
        {
            if (!flowLayoutPanel1.ClientRectangle.Contains(flowLayoutPanel1.PointToClient(Cursor.Position)))
            {
                flowLayoutPanel1.Visible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                row.DefaultCellStyle.BackColor = dataGridView3.DefaultCellStyle.BackColor;
            }

            textBox1.Text = string.Empty;
        }

        private void buttonОбразованиеСотрудников_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;

            indexOfPanel = 7;
            indexOfDataGridView = 6;
            nameOfTable = "ОбразованиеСотрудников";

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.DataSource = образованиеСотрудниковbindingSource;

            dataGridView3.Columns["КодОбразования"].HeaderText = "Код образования";
            dataGridView3.Columns["РегистрационныйНомерСотрудника"].HeaderText = "Регистрационный номер сотрудника";
            dataGridView3.Columns["ГодОкончанияВУЗа"].HeaderText = "Год окончания ВУЗа";
            dataGridView3.Columns["УченаяСтепень"].HeaderText = "Ученая степень";
            dataGridView3.Columns["УченоеЗвание"].HeaderText = "Ученое звание";


        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Трудовые договоры", button6);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Сотрудники", button2);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Личная информация сотрудников", button3);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Рабочие места", button4);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Дисциплинарные меры", button5);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Образование сотрудников", button7);
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Сменить пользователя", button11);
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Закрыть", button9);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ОбразованиеСотрудников". При необходимости она может быть перемещена или удалена.
            this.образованиеСотрудниковTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ОбразованиеСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ДисциплинарныеМерыВОтношенииСотрудников". При необходимости она может быть перемещена или удалена.
            this.дисциплинарныеМерыВОтношенииСотрудниковTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ДисциплинарныеМерыВОтношенииСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОПредыдущемРабочемМесте". При необходимости она может быть перемещена или удалена.
            this.информацияОПредыдущемРабочемМестеTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОПредыдущемРабочемМесте);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОРабочемМестеСотрудников". При необходимости она может быть перемещена или удалена.
            this.информацияОРабочемМестеСотрудниковTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОРабочемМестеСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ЛичнаяИнформацияСотрудников". При необходимости она может быть перемещена или удалена.
            this.личнаяИнформацияСотрудниковTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ЛичнаяИнформацияСотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "уП01_ИСПП_5_Гаевский_ААDataSet.ТрудовойДоговор". При необходимости она может быть перемещена или удалена.
            this.трудовойДоговорTableAdapter.Fill(this.уП01_ИСПП_5_Гаевский_ААDataSet.ТрудовойДоговор);

            switch (indexOfDataGridView)
            {
                case 0:
                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    }; 
                    break;
                    
                case 1:
                    int imageColumnIndex = 6;
                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        if (column.Index != imageColumnIndex)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                        }
                    }

                    dataGridView3.Columns[imageColumnIndex].Width = 200;

                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        if (row.Cells[imageColumnIndex].Value is Image image)
                        {
                            Image resizedImage = new Bitmap(image, 200, 200);

                            row.Cells[imageColumnIndex].Value = resizedImage;
                        }

                        row.Height = 200 + dataGridView3.RowTemplate.Height - dataGridView3.DefaultCellStyle.Padding.Vertical;
                    };
                    break;

                case 2:
                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    };
                    break;
                case 3:
                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    };
                    break;
                case 4:
                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    };
                    break; 
            }
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Обновить таблицу", button17);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button21.Location.X + 110;
            y = button21.Location.Y + 85; ;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 280;
            flowLayoutPanel1.Height = 170;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Visible = true;

            Button buttonСотрудникиРаботающиеВНастоящееВремя = new Button();
            buttonСотрудникиРаботающиеВНастоящееВремя.Text = "Сотрудники работающие в настоящее время";
            buttonСотрудникиРаботающиеВНастоящееВремя.Size = new Size(100, 50);
            buttonСотрудникиРаботающиеВНастоящееВремя.Width = flowLayoutPanel1.Width - 5;
            buttonСотрудникиРаботающиеВНастоящееВремя.Click += buttonСотрудникиРаботающиеВНастоящееВремя_Click;
            buttonСотрудникиРаботающиеВНастоящееВремя.BackColor = Color.White;
            buttonСотрудникиРаботающиеВНастоящееВремя.ForeColor = Color.DarkSlateBlue;
            buttonСотрудникиРаботающиеВНастоящееВремя.FlatStyle = FlatStyle.Flat;
            buttonСотрудникиРаботающиеВНастоящееВремя.Font = new Font("Microsoft Sans Serif", 10); 
            flowLayoutPanel1.Controls.Add(buttonСотрудникиРаботающиеВНастоящееВремя);

            Button buttonСотрудникиРаботающиеВпервые = new Button();
            buttonСотрудникиРаботающиеВпервые.Text = "Сотрудники без опыта";
            buttonСотрудникиРаботающиеВпервые.Size = new Size(100, 50);
            buttonСотрудникиРаботающиеВпервые.Width = flowLayoutPanel1.Width - 5;
            buttonСотрудникиРаботающиеВпервые.Click += buttonСотрудникиРаботающиеВпервые_Click;
            buttonСотрудникиРаботающиеВпервые.BackColor = Color.White;
            buttonСотрудникиРаботающиеВпервые.ForeColor = Color.DarkSlateBlue;
            buttonСотрудникиРаботающиеВпервые.FlatStyle = FlatStyle.Flat;
            buttonСотрудникиРаботающиеВпервые.Font = new Font("Microsoft Sans Serif", 10);
            flowLayoutPanel1.Controls.Add(buttonСотрудникиРаботающиеВпервые);

            Button buttonСотрудникиКоличествоПрошлыхРабот = new Button();
            buttonСотрудникиКоличествоПрошлыхРабот.Text = "Сотрудники и количество их прошлых работ";
            buttonСотрудникиКоличествоПрошлыхРабот.Size = new Size(100, 50);
            buttonСотрудникиКоличествоПрошлыхРабот.Width = flowLayoutPanel1.Width - 5;
            buttonСотрудникиКоличествоПрошлыхРабот.Click += buttonСотрудникиКоличествоПрошлыхРабот_Click;
            buttonСотрудникиКоличествоПрошлыхРабот.BackColor = Color.White;
            buttonСотрудникиКоличествоПрошлыхРабот.ForeColor = Color.DarkSlateBlue;
            buttonСотрудникиКоличествоПрошлыхРабот.FlatStyle = FlatStyle.Flat;
            buttonСотрудникиКоличествоПрошлыхРабот.Font = new Font("Microsoft Sans Serif", 10);
            flowLayoutPanel1.Controls.Add(buttonСотрудникиКоличествоПрошлыхРабот);

        }

        private void buttonСотрудникиКоличествоПрошлыхРабот_Click(object sender, EventArgs e)
        {
            sqlDataAdapter = new SqlDataAdapter("SELECT Сотрудники.РегистрационныйНомерСотрудника, CONCAT(Сотрудники.Фамилия, ' ', Сотрудники.Имя, ' ', Сотрудники.Отчество) " +
                "AS ФИО_Сотрудника, COUNT(ИнформацияОПредыдущемРабочемМесте.КодПредыдущегоРабочегоМеста) AS КоличествоПредыдущихМест FROM Сотрудники LEFT JOIN ИнформацияОПредыдущемРабочемМесте " +
                "ON Сотрудники.РегистрационныйНомерСотрудника = ИнформацияОПредыдущемРабочемМесте.РегистрационныйНомерСотрудника GROUP BY Сотрудники.РегистрационныйНомерСотрудника, " +
                "Сотрудники.Фамилия, Сотрудники.Имя, Сотрудники.Отчество HAVING COUNT(ИнформацияОПредыдущемРабочемМесте.КодПредыдущегоРабочегоМеста) > 0 ORDER BY КоличествоПредыдущихМест " +
                "DESC; ", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;

            dataGridView3.Columns["РегистрационныйНомерСотрудника"].HeaderText = "Регистрационный номер сотрудника";
            dataGridView3.Columns["ФИО_Сотрудника"].HeaderText = "ФИО сотрудника";
            dataGridView3.Columns["КоличествоПредыдущихМест"].HeaderText = "Количество предыдущих мест";
        }

        private void buttonСотрудникиРаботающиеВпервые_Click(object sender, EventArgs e)
        {
            sqlDataAdapter = new SqlDataAdapter("SELECT Сотрудники.РегистрационныйНомерСотрудника AS [Регистрационный номер сотрудника], CONCAT(Сотрудники.Фамилия, ' ', Сотрудники.Имя, ' ', Сотрудники.Отчество) " +
                "AS [ФИО сотрудника], Дата_рождения AS [Дата рождения], Место_рождения AS [Место рождения] FROM Сотрудники WHERE РегистрационныйНомерСотрудника " +
                "NOT IN(SELECT РегистрационныйНомерСотрудника FROM ИнформацияОПредыдущемРабочемМесте)", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }

        private void buttonСотрудникиРаботающиеВНастоящееВремя_Click(object sender, EventArgs e)
        {
            sqlDataAdapter = new SqlDataAdapter("SELECT Сотрудники.РегистрационныйНомерСотрудника AS [Регистрационный номер сотрудника], CONCAT(Сотрудники.Фамилия, ' ', Сотрудники.Имя, ' ', " +
                "Сотрудники.Отчество) AS [ФИО сотрудника], Сотрудники.Дата_рождения AS [Дата рождения], Сотрудники.Место_рождения AS [Место рождения]" +
                "FROM Сотрудники " +
                "WHERE Сотрудники.РегистрационныйНомерСотрудника NOT IN " +
                "(SELECT ТрудовойДоговор.РегистрационныйНомерСотрудника FROM ТрудовойДоговор WHERE ТрудовойДоговор.ДатаОкончанияТрудовойДеятельности IS NOT NULL)", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button21.Location.X + 110;
            y = button21.Location.Y + 85; ;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 280;
            flowLayoutPanel1.Height = 70;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Visible = true;

            Button buttonСотрудникиОкладВышеСреднего = new Button();
            buttonСотрудникиОкладВышеСреднего.Text = "Сотрудники с окладом выше среднего";
            buttonСотрудникиОкладВышеСреднего.Size = new Size(100, 50);
            buttonСотрудникиОкладВышеСреднего.Width = flowLayoutPanel1.Width - 5;
            buttonСотрудникиОкладВышеСреднего.Click += buttonСотрудникиОкладВышеСреднего_Click;
            buttonСотрудникиОкладВышеСреднего.BackColor = Color.White;
            buttonСотрудникиОкладВышеСреднего.ForeColor = Color.DarkOrchid;
            buttonСотрудникиОкладВышеСреднего.FlatStyle = FlatStyle.Flat;
            buttonСотрудникиОкладВышеСреднего.Font = new Font("Microsoft Sans Serif", 10);
            flowLayoutPanel1.Controls.Add(buttonСотрудникиОкладВышеСреднего);
        }

        private void buttonСотрудникиОкладВышеСреднего_Click(object sender, EventArgs e)
        {
            sqlDataAdapter = new SqlDataAdapter("SELECT Сотрудники.РегистрационныйНомерСотрудника AS [Регистрационный номер сотрудника], CONCAT(Сотрудники.Фамилия, ' ', Сотрудники.Имя, ' ', " +
                "Сотрудники.Отчество) AS [ФИО сотрудника], ТрудовойДоговор.Оклад FROM Сотрудники INNER JOIN ТрудовойДоговор ON Сотрудники.РегистрационныйНомерСотрудника = " +
                "ТрудовойДоговор.РегистрационныйНомерСотрудника WHERE ТрудовойДоговор.Оклад > (SELECT AVG(Оклад) FROM ТрудовойДоговор); ", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = widthFlowLayoutPanel;
            flowLayoutPanel1.Height = heightFlowLayoutPanel;
            x = button21.Location.X + 110;
            y = button21.Location.Y + 85; ;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Location = new Point(x, y);
            flowLayoutPanel1.Width = 280;
            flowLayoutPanel1.Height = 70;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Visible = true;

            Button buttonСотрудникиКоличествоНаграждений = new Button();
            buttonСотрудникиКоличествоНаграждений.Text = "Количество награждений";
            buttonСотрудникиКоличествоНаграждений.Size = new Size(100, 50);
            buttonСотрудникиКоличествоНаграждений.Width = flowLayoutPanel1.Width - 5;
            buttonСотрудникиКоличествоНаграждений.Click += buttonСотрудникиКоличествоНаграждений_Click;
            buttonСотрудникиКоличествоНаграждений.BackColor = Color.White;
            buttonСотрудникиКоличествоНаграждений.ForeColor = Color.Indigo;
            buttonСотрудникиКоличествоНаграждений.FlatStyle = FlatStyle.Flat;
            buttonСотрудникиКоличествоНаграждений.Font = new Font("Microsoft Sans Serif", 10);
            flowLayoutPanel1.Controls.Add(buttonСотрудникиКоличествоНаграждений);
        }

        private void buttonСотрудникиКоличествоНаграждений_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;

            sqlDataAdapter = new SqlDataAdapter("SELECT Сотрудники.РегистрационныйНомерСотрудника AS [Регистрационный номер сотрудника], CONCAT(Сотрудники.Фамилия, ' ', Сотрудники.Имя, ' ', " +
                "Сотрудники.Отчество) AS [ФИО сотрудника], ИнформацияОРабочемМестеСотрудников.КодРабочегоМеста AS [Код рабочего места], Сотрудники.Фото, " +
                "COUNT(ДисциплинарныеМерыВОтношенииСотрудников.КодДисциплинарнойМеры) " +
                "AS [Количество награждений] FROM Сотрудники LEFT JOIN ДисциплинарныеМерыВОтношенииСотрудников ON Сотрудники.РегистрационныйНомерСотрудника = " +
                "ДисциплинарныеМерыВОтношенииСотрудников.РегистрационныйНомерСотрудника INNER JOIN ИнформацияОРабочемМестеСотрудников ON Сотрудники.РегистрационныйНомерСотрудника = " +
                "ИнформацияОРабочемМестеСотрудников.РегистрационныйНомерСотрудника WHERE ДисциплинарныеМерыВОтношенииСотрудников.СведенияОНаграждениях IS NOT NULL GROUP BY " +
                "Сотрудники.РегистрационныйНомерСотрудника, Сотрудники.Фамилия, Сотрудники.Имя, Сотрудники.Отчество, Сотрудники.Фото, ИнформацияОРабочемМестеСотрудников.КодРабочегоМеста; ", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;

            int imageColumnIndex = 3;
            int desiredColumnWidth = 200;
            int desiredColumnHeight = 200;

            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                if (column.Index != imageColumnIndex)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                }
            }

            dataGridView3.Columns[imageColumnIndex].Width = desiredColumnWidth;

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[imageColumnIndex].Value is Image image)
                {
                    Image resizedImage = new Bitmap(image, desiredColumnWidth, desiredColumnHeight);

                    row.Cells[imageColumnIndex].Value = resizedImage;
                }

                row.Height = desiredColumnHeight + dataGridView3.RowTemplate.Height - dataGridView3.DefaultCellStyle.Padding.Vertical;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6) 
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView3.Rows.Count - 1) 
                {
                    var openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "JPEG Files (*.jpeg;*.jpg)|*.jpeg;*.jpg|PNG Files (*.png)|*.png"; 

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var selectedFiles = openFileDialog.FileNames;

                        foreach (var file in selectedFiles)
                        {
                            var imageBytes = File.ReadAllBytes(file);
                            dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = imageBytes;
                        }
                    }
                }
            }
        }

        private void HideFlowLayoutPanel(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
        }
    }
}
