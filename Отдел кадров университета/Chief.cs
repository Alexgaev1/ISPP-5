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
    public partial class Chief : Form
    {
        public Chief()
        {
            InitializeComponent();
        }

        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        private int x, y;
        private int indexOfPanel = 7;
        private int indexOfDataGridView = 0;
        private string imagePath = null;
        private string nameOfTable = null;

        private const int widthFlowLayoutPanel = 95;
        private const int heightFlowLayoutPanel = 60;



        private void Chief_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Отдел_кадров_университета.Properties.Settings.УП01_ИСПП_5_Гаевский_ААConnectionString"].ConnectionString);

            sqlConnection.Open();

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);

            dataGridView3.Click += HideFlowLayoutPanel;

            panel1.Click += HideFlowLayoutPanel;
            panel2.Click += HideFlowLayoutPanel;
            panel3.Click += HideFlowLayoutPanel;
            panel4.Click += HideFlowLayoutPanel;
            panel5.Click += HideFlowLayoutPanel;
            panel6.Click += HideFlowLayoutPanel;
            panel7.Click += HideFlowLayoutPanel;
            panel8.Click += HideFlowLayoutPanel;
            panel9.Click += HideFlowLayoutPanel;

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

            Button buttonСоздатьТрудовойДоговор = new Button();
            buttonСоздатьТрудовойДоговор.Text = "Добавить трудовой договор";
            buttonСоздатьТрудовойДоговор.Width = flowLayoutPanel1.Width - 5;
            buttonСоздатьТрудовойДоговор.Click += buttonСоздатьТрудовойДоговор_Click;
            flowLayoutPanel1.Controls.Add(buttonСоздатьТрудовойДоговор);
           
        }

        private void buttonСоздатьТрудовойДоговор_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
            button17.Enabled = true;

            indexOfPanel = 0;

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);
        }
        private void buttonТрудовыеДоговоры_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
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

            Button buttonСоздатьСотрудника = new Button();
            buttonСоздатьСотрудника.Text = "Добавить сотрудника";
            buttonСоздатьСотрудника.Width = flowLayoutPanel1.Width - 5;
            buttonСотрудники.BackColor = button2.BackColor;
            buttonСоздатьСотрудника.Click += buttonСоздатьСотрудника_Click;
            flowLayoutPanel1.Controls.Add(buttonСоздатьСотрудника);
        }

        private void buttonСоздатьСотрудника_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
            button17.Enabled = true;

            indexOfPanel = 1;

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);
        }
        private void buttonСотрудники_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
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

            Button buttonСоздатьЛичнуюИнформациюСотрудника = new Button();
            buttonСоздатьЛичнуюИнформациюСотрудника.Text = "Добавить личную информацию";
            buttonСоздатьЛичнуюИнформациюСотрудника.Width = flowLayoutPanel1.Width - 5;
            buttonСоздатьЛичнуюИнформациюСотрудника.Click += buttonСоздатьЛичнуюИнформациюСотрудника_Click;
            flowLayoutPanel1.Controls.Add(buttonСоздатьЛичнуюИнформациюСотрудника);
        }

        private void buttonСоздатьЛичнуюИнформациюСотрудника_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
            button17.Enabled = true;

            indexOfPanel = 2;

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);
        }
        private void buttonЛичнаяИнформацияСотрудников_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
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

            Button buttonДобавитьРабочееМесто = new Button();
            buttonДобавитьРабочееМесто.Text = "Добавить рабочее место";
            buttonДобавитьРабочееМесто.Width = flowLayoutPanel1.Width - 5;
            buttonДобавитьРабочееМесто.Click += buttonДобавитьРабочееМесто_Click;
            flowLayoutPanel1.Controls.Add(buttonДобавитьРабочееМесто);

            Button buttonДобавитьБывшееРабочееМесто = new Button();
            buttonДобавитьБывшееРабочееМесто.Text = "Добавить предыдущее место";
            buttonДобавитьБывшееРабочееМесто.Width = flowLayoutPanel1.Width - 5;
            buttonДобавитьБывшееРабочееМесто.Click += buttonДобавитьБывшееРабочееМесто_Click;
            flowLayoutPanel1.Controls.Add(buttonДобавитьБывшееРабочееМесто);
        }

        private void buttonДобавитьБывшееРабочееМесто_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
            button17.Enabled = true;

            indexOfPanel = 4;

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);
        }

        private void buttonДобавитьРабочееМесто_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
            button17.Enabled = true;

            indexOfPanel = 3;

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);
        }

        private void buttonБывшееРабочееМестоСотрудника_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
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
            button10.Enabled = true;
            button27.Enabled = true;
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

            Button buttonДобавитьВзыскание = new Button();
            buttonДобавитьВзыскание.Text = "Вознаграждения и поощрения";
            buttonДобавитьВзыскание.Width = flowLayoutPanel1.Width - 5;
            buttonДобавитьВзыскание.Click += buttonДобавитьВзыскание_Click;
            flowLayoutPanel1.Controls.Add(buttonДобавитьВзыскание);
        }

        private void buttonДобавитьВзыскание_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
            button17.Enabled = true;

            indexOfPanel = 5;

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);
        }
        private void buttonДисциплинарныеМеры_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
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

            Button buttonДобавитьОбразованиеСотрудника = new Button();
            buttonДобавитьОбразованиеСотрудника.Text = "Добавить образование";
            buttonДобавитьОбразованиеСотрудника.Width = flowLayoutPanel1.Width - 5;
            buttonДобавитьОбразованиеСотрудника.Click += buttonДобавитьОбразованиеСотрудника_Click;
            flowLayoutPanel1.Controls.Add(buttonДобавитьОбразованиеСотрудника);
        }

        private void buttonДобавитьОбразованиеСотрудника_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
            button17.Enabled = true;

            indexOfPanel = 6;

            OpenPanels.openPanels(tableLayoutPanel1, indexOfPanel);
        }

        private void buttonДобавлениеТрудовогоДоговора_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ТрудовойДоговор(РегистрационныйНомерСотрудника, КодРабочегоМеста, КоличествоРабочихСроков, ДатаНачалаТрудовойДеятельности, ДатаОкончанияТрудовойДеятельности, Оклад) " +
                "VALUES (@РегистрационныйНомерСотрудника, @КодРабочегоМеста, @КоличествоРабочихСроков, @ДатаНачалаТрудовойДеятельности, @ДатаОкончанияТрудовойДеятельности, @Оклад)", sqlConnection);

                DateTime firstDate = DateTime.Parse(maskedTextBoxДатаНачТрудДеят.Text);
                DateTime? secondDate = null;

                if (!string.IsNullOrEmpty(maskedTextBoxДатаОкончТрудДеят.Text))
                {
                    string dateInput = maskedTextBoxДатаОкончТрудДеят.Text;
                    string dateFormat = "dd.MM.yyyy"; // Замените на нужный формат маски

                    if (DateTime.TryParseExact(dateInput, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                    {
                        secondDate = parsedDate;
                    }
                }

                sqlCommand.Parameters.AddWithValue("РегистрационныйНомерСотрудника", maskedTextBoxРНС1.Text);
                sqlCommand.Parameters.AddWithValue("КодРабочегоМеста", maskedTextBoxКодРабМеста.Text);
                sqlCommand.Parameters.AddWithValue("КоличествоРабочихСроков", maskedTextBoxКолРабСроков.Text);
                sqlCommand.Parameters.AddWithValue("ДатаНачалаТрудовойДеятельности", $"{firstDate.Month}/{firstDate.Day}/{firstDate.Year}");

                if (secondDate.HasValue)
                {
                    sqlCommand.Parameters.AddWithValue("ДатаОкончанияТрудовойДеятельности", $"{secondDate.Value.Month}/{secondDate.Value.Day}/{secondDate.Value.Year}");
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("ДатаОкончанияТрудовойДеятельности", DBNull.Value);
                }

                sqlCommand.Parameters.AddWithValue("Оклад", maskedTextBoxОклад.Text);

                if (string.IsNullOrEmpty(maskedTextBoxРНС1.Text) || string.IsNullOrEmpty(maskedTextBoxКодРабМеста.Text) || string.IsNullOrEmpty(maskedTextBoxКолРабСроков.Text) || string.IsNullOrEmpty(maskedTextBoxОклад.Text))
                {
                    Notification notification = new Notification();
                    notification.titleLabel.ForeColor = Color.Red;
                    notification.Title = "Не все поля заполнены";
                    notification.Show(3000);
                }
                else
                {
                    sqlCommand.ExecuteNonQuery();
                    Notification notification = new Notification();
                    notification.titleLabel.ForeColor = Color.ForestGreen;
                    notification.Title = "Добавлена новая строка в таблицу 'Трудовой договор'";
                    notification.Show(3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }




        private void buttonДобавлениеСотрудника_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Сотрудники (Фамилия, Имя, Отчество, Дата_рождения, Место_рождения, Фото, Примечания) " +
                "VALUES(@Фамилия, @Имя, @Отчество, @Дата_рождения, @Место_рождения, @Фото, @Примечания)", sqlConnection);
                DateTime firstDate = DateTime.Parse(maskedTextBoxДатаРождения.Text);
                Notification notification = new Notification();

                if (!string.IsNullOrEmpty(imagePath))
                {
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    sqlCommand.Parameters.AddWithValue("Фамилия", maskedTextBoxФамилия.Text);
                    sqlCommand.Parameters.AddWithValue("Имя", maskedTextBoxИмя.Text);
                    sqlCommand.Parameters.AddWithValue("Отчество", maskedTextBoxОтчество.Text);
                    sqlCommand.Parameters.AddWithValue("Дата_рождения", $"{firstDate.Month}/{firstDate.Day}/{firstDate.Year}");
                    sqlCommand.Parameters.AddWithValue("Место_рождения", maskedTextBoxМестоРождения.Text);
                    sqlCommand.Parameters.Add("@Фото", SqlDbType.VarBinary, -1).Value = imageData;
                    sqlCommand.Parameters.AddWithValue("Примечания", maskedTextBoxПримечания.Text);

                    sqlCommand.ExecuteNonQuery();
                    notification = new Notification();
                    notification.titleLabel.ForeColor = Color.ForestGreen;
                    notification.Title = "Добавлена новая строка в таблицу 'Сотрудники'";
                    notification.Show(3000);
                }
                else
                {
                    notification = new Notification();
                    notification.titleLabel.ForeColor = Color.Red;
                    notification.Title = "Выберите фотографию сотрудника";
                    notification.Show(3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonДобавлениеЛичнойИнформацииСотрудника_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ЛичнаяИнформацияСотрудников (РегистрационныйНомерСотрудника, Паспорт, ДатаВыдачиПаспорта, КемВыдан, ДомашнийАдрес, ДомашнийТелефон, АдресЭлектроннойПочты) " +
                    "VALUES(@РегистрационныйНомерСотрудника, @Паспорт, @ДатаВыдачиПаспорта, @КемВыдан, @ДомашнийАдрес, @ДомашнийТелефон, @АдресЭлектроннойПочты)", sqlConnection);

                DateTime firstDate = DateTime.Parse(maskedTextBoxДатаВыдачиПаспорта.Text);

                sqlCommand.Parameters.AddWithValue("РегистрационныйНомерСотрудника", maskedTextBoxРНС3.Text);
                sqlCommand.Parameters.AddWithValue("Паспорт", maskedTextBoxПаспорт.Text);
                sqlCommand.Parameters.AddWithValue("ДатаВыдачиПаспорта", $"{firstDate.Month}/{firstDate.Day}/{firstDate.Year}");
                sqlCommand.Parameters.AddWithValue("КемВыдан", maskedTextBoxКемВыдан.Text);
                sqlCommand.Parameters.AddWithValue("ДомашнийАдрес", maskedTextBoxДомашнийАдрес.Text);
                sqlCommand.Parameters.AddWithValue("ДомашнийТелефон", maskedTextBoxДомашнийТелефон.Text);
                sqlCommand.Parameters.AddWithValue("АдресЭлектроннойПочты", maskedTextBoxАдресЭлПочты.Text);

                sqlCommand.ExecuteNonQuery();
                Notification notification = new Notification();
                notification.titleLabel.ForeColor = Color.ForestGreen;
                notification.Title = "Добавлена новая строка в таблицу 'Личная информация сотрудников'";
                notification.Show(3000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonДобавлениеРабочегоМестаСотрудника_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ИнформацияОРабочемМестеСотрудников(РегистрационныйНомерСотрудника, НазваниеКафедры, ЗанимаемаяДолжность) " +
                    "VALUES(@РегистрационныйНомерСотрудника, @НазваниеКафедры, @ЗанимаемаяДолжность)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("РегистрационныйНомерСотрудника", maskedTextBoxРНС4.Text);
                sqlCommand.Parameters.AddWithValue("НазваниеКафедры", maskedTextBoxНазваниеКафедры.Text);
                sqlCommand.Parameters.AddWithValue("ЗанимаемаяДолжность", maskedTextBoxЗанимаемаяДолжность.Text);

                sqlCommand.ExecuteNonQuery();
                Notification notification = new Notification();
                notification.titleLabel.ForeColor = Color.ForestGreen;
                notification.Title = "Добавлена новая строка в таблицу 'Информация о рабочем месте'";
                notification.Show(3000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonДобавлениеПредыдущегоРабочегоМестаСотрудника_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ИнформацияОПредыдущемРабочемМесте (РегистрационныйНомерСотрудника, НазваниеПредприятия, Должность, ДатаУстройства, ДатаУвольнения, ПричинаУвольнения, АдресПредприятия, ТелефонПредприятия) " +
                    "VALUES(@РегистрационныйНомерСотрудника, @НазваниеПредприятия , @Должность, @ДатаУстройства, @ДатаУвольнения, @ПричинаУвольнения, @АдресПредприятия, @ТелефонПредприятия)", sqlConnection);

                DateTime firstDate = DateTime.Parse(maskedTextBoxДатаУстройства.Text);
                DateTime secondDate = DateTime.Parse(maskedTextBoxДатаУвольнения.Text);

                sqlCommand.Parameters.AddWithValue("РегистрационныйНомерСотрудника", maskedTextBoxРНС5.Text);
                sqlCommand.Parameters.AddWithValue("НазваниеПредприятия", maskedTextBoxНазваниеПредприятия.Text);
                sqlCommand.Parameters.AddWithValue("Должность", maskedTextBoxДолжность.Text);
                sqlCommand.Parameters.AddWithValue("ДатаУстройства", $"{firstDate.Month}/{firstDate.Day}/{firstDate.Year}");
                sqlCommand.Parameters.AddWithValue("ДатаУвольнения", $"{secondDate.Month}/{secondDate.Day}/{secondDate.Year}");
                sqlCommand.Parameters.AddWithValue("ПричинаУвольнения", maskedTextBoxПричинаУвольнения.Text);
                sqlCommand.Parameters.AddWithValue("АдресПредприятия", maskedTextBoxАдресПредприятия.Text);
                sqlCommand.Parameters.AddWithValue("ТелефонПредприятия", maskedTextBoxТелефонПредприятия.Text);

                sqlCommand.ExecuteNonQuery();
                Notification notification = new Notification();
                notification.titleLabel.ForeColor = Color.ForestGreen;
                notification.Title = "Добавлена новая строка в таблицу 'Информация о предыдущем рабочем месте'";
                notification.Show(3000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonДобавлениеВзысканияНаграждения_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ДисциплинарныеМерыВОтношенииСотрудников(РегистрационныйНомерСотрудника, СведенияОВзысканиях, СведенияОНаграждениях) " +
                    "VALUES(@РегистрационныйНомерСотрудника, @СведенияОВзысканиях, @СведенияОНаграждениях)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("РегистрационныйНомерСотрудника", maskedTextBoxРНС6.Text);
                sqlCommand.Parameters.AddWithValue("СведенияОВзысканиях", maskedTextBoxСведенияОВзысканиях.Text);
                sqlCommand.Parameters.AddWithValue("СведенияОНаграждениях", maskedTextBoxСведенияОНаграждениях.Text);

                sqlCommand.ExecuteNonQuery();
                Notification notification = new Notification();
                notification.titleLabel.ForeColor = Color.ForestGreen;
                notification.Title = "Добавлена новая строка в таблицу 'Дисциплинарные меры в отношении сотрудников'";
                notification.Show(3000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void maskedTextBoxСведенияОВзысканиях_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(maskedTextBoxСведенияОНаграждениях.Text))
            {
                maskedTextBoxСведенияОВзысканиях.Text = "";
                Notification notification = new Notification();
                notification.titleLabel.ForeColor = Color.Red;
                notification.Title = "Поле 'Сведения о награждениях' должно быть пустым";
                notification.Show(3000);
            }
        }

        private void maskedTextBoxСведенияОНаграждениях_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(maskedTextBoxСведенияОВзысканиях.Text))
            {
                maskedTextBoxСведенияОНаграждениях.Text = "";
                Notification notification = new Notification();
                notification.titleLabel.ForeColor = Color.Red;
                notification.Title = "Поле 'Сведения о взысканиях' должно быть пустым";
                notification.Show(3000);
            }
        }

        private void buttonДобавлениеОбразованияСотрудника_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO ОбразованиеСотрудников (РегистрационныйНомерСотрудника, ВУЗ, ГодОкончанияВУЗа, Специальность, УченаяСтепень, УченоеЗвание) " +
                    "VALUES(@РегистрационныйНомерСотрудника, @ВУЗ, @ГодОкончанияВУЗа, @Специальность, @УченаяСтепень, @УченоеЗвание)", sqlConnection);

                DateTime firstDate = DateTime.Parse(maskedTextBoxГодОкончанияВУЗа.Text);

                sqlCommand.Parameters.AddWithValue("РегистрационныйНомерСотрудника", maskedTextBoxРНС7.Text);
                sqlCommand.Parameters.AddWithValue("ВУЗ", maskedTextBoxВУЗ.Text);
                sqlCommand.Parameters.AddWithValue("ГодОкончанияВУЗа", $"{firstDate.Month}/{firstDate.Day}/{firstDate.Year}");
                sqlCommand.Parameters.AddWithValue("Специальность", maskedTextBoxСпециальность.Text);
                sqlCommand.Parameters.AddWithValue("УченаяСтепень", maskedTextBoxУченаяСтепень.Text);
                sqlCommand.Parameters.AddWithValue("УченоеЗвание", maskedTextBoxУченоеЗвание.Text);

                sqlCommand.ExecuteNonQuery();
                Notification notification = new Notification();
                notification.titleLabel.ForeColor = Color.ForestGreen;
                notification.Title = "Добавлена новая строка в таблицу 'Образование сотрудников'";
                notification.Show(3000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
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

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Изображения (*.png;*.jpg)|*.png;*.jpg";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
            }

            maskedTextBoxФото.Text = imagePath;
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

        private void Chief_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            трудовойДоговорTableAdapter.Update(уП01_ИСПП_5_Гаевский_ААDataSet.ТрудовойДоговор);
            сотрудникиTableAdapter.Update(уП01_ИСПП_5_Гаевский_ААDataSet.Сотрудники);
            образованиеСотрудниковTableAdapter.Update(уП01_ИСПП_5_Гаевский_ААDataSet.ОбразованиеСотрудников); 
            личнаяИнформацияСотрудниковTableAdapter.Update(уП01_ИСПП_5_Гаевский_ААDataSet.ЛичнаяИнформацияСотрудников); 
            информацияОПредыдущемРабочемМестеTableAdapter.Update(уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОПредыдущемРабочемМесте); 
            дисциплинарныеМерыВОтношенииСотрудниковTableAdapter.Update(уП01_ИСПП_5_Гаевский_ААDataSet.ДисциплинарныеМерыВОтношенииСотрудников); 
            информацияОРабочемМестеСотрудниковTableAdapter.Update(уП01_ИСПП_5_Гаевский_ААDataSet.ИнформацияОРабочемМестеСотрудников);
            пользователиTableAdapter.Update(уП01_ИСПП_5_Гаевский_ААDataSet.Пользователи);

            Notification notification = new Notification();
            notification.titleLabel.ForeColor = Color.ForestGreen;
            notification.Title = "Запись изменена";
            notification.Height = 75;
            notification.Show(3000);

        }

        private void buttonОбразованиеСотрудников_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            button27.Enabled = true;
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

        private void button8_Click(object sender, EventArgs e)
        {
            maskedTextBoxРНС1.Text = null;
            maskedTextBoxКодРабМеста.Text = null;
            maskedTextBoxКолРабСроков.Text = null;
            maskedTextBoxДатаНачТрудДеят.Text = null;
            maskedTextBoxДатаОкончТрудДеят.Text = null;
            maskedTextBoxОклад.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            maskedTextBoxФамилия.Text = null;
            maskedTextBoxИмя.Text = null;
            maskedTextBoxОтчество.Text = null;
            maskedTextBoxДатаРождения.Text = null;
            maskedTextBoxМестоРождения.Text = null;
            maskedTextBoxФото.Text = null;
            maskedTextBoxПримечания.Text = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            maskedTextBoxРНС3.Text = null;
            maskedTextBoxПаспорт.Text = null;
            maskedTextBoxДатаВыдачиПаспорта.Text = null;
            maskedTextBoxКемВыдан.Text = null;
            maskedTextBoxДомашнийАдрес.Text = null;
            maskedTextBoxДомашнийТелефон.Text = null;
            maskedTextBoxАдресЭлПочты.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBoxРНС4.Text = null;
            maskedTextBoxНазваниеКафедры.Text = null;
            maskedTextBoxЗанимаемаяДолжность.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            maskedTextBoxРНС5.Text = null;
            maskedTextBoxНазваниеПредприятия.Text = null;
            maskedTextBoxДолжность.Text = null;
            maskedTextBoxДатаУстройства.Text = null;
            maskedTextBoxДатаУвольнения.Text = null;
            maskedTextBoxПричинаУвольнения.Text = null;
            maskedTextBoxАдресПредприятия.Text = null;
            maskedTextBoxТелефонПредприятия.Text = null;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            maskedTextBoxРНС6.Text = null;
            maskedTextBoxСведенияОВзысканиях.Text = null;
            maskedTextBoxСведенияОНаграждениях.Text= null;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            maskedTextBoxРНС7.Text = null;
            maskedTextBoxВУЗ.Text = null;
            maskedTextBoxГодОкончанияВУЗа.Text = null;
            maskedTextBoxСпециальность.Text= null;
            maskedTextBoxУченаяСтепень.Text = null;
            maskedTextBoxУченоеЗвание.Text = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {

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

        private void button10_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Сохранить таблицу", button10);
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
            button10.Enabled = false;
            button27.Enabled = false;
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

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Пользователи (Логин, Пароль, ПраваДоступа) " +
                    "VALUES(@Логин, @Пароль, @ПраваДоступа)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("Логин", maskedTextBoxЛогин.Text);
                sqlCommand.Parameters.AddWithValue("Пароль", maskedTextBoxПароль.Text);
                sqlCommand.Parameters.AddWithValue("ПраваДоступа", comboBox1.SelectedItem.ToString());

                sqlCommand.ExecuteNonQuery();
                Notification notification = new Notification();
                notification.titleLabel.ForeColor = Color.Orange;
                notification.Title = "Добавлен новый пользователь";
                notification.Show(3000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.SelectedRows.Count > 0)
                {
                    var id = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();

                    string Message;
                    Message = "Вы действительно хотите удалить выделенную запись?";

                    if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }

                    var deleQuery = $"DELETE FROM {nameOfTable} WHERE {dataGridView3.Columns[0].Name} = {id}";

                    SqlCommand sqlCommand = new SqlCommand(deleQuery, sqlConnection);

                    sqlCommand.ExecuteNonQuery();

                    Notification notification = new Notification();
                    notification.titleLabel.ForeColor = Color.Orange;
                    notification.Title = "Запись удалена, обновите таблицу";
                    notification.Show(3000);
                }
                else
                {
                    Notification notification = new Notification();
                    notification.titleLabel.ForeColor = Color.DarkRed;
                    notification.Title = "Выберите запись, которую следует удалить";
                    notification.Show(3000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button27_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Удалить запись в таблице", button10);
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
