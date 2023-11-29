namespace УП_МДК_01_01
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регистрационныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАгентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началоДействийДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окончаниеДействийДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дополнительныеУсловияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вознаграждениеЦентраОценкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договорыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП01_ИСПП5_Работягова_ААDataSet = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSet();
            this.договорыTableAdapter = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSetTableAdapters.ДоговорыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодПродленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продлениеСрокаДействияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKПродлениеДоговорыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продлениеTableAdapter = new УП_МДК_01_01.УП01_ИСПП5_Работягова_ААDataSetTableAdapters.ПродлениеTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Работягова_ААDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПродлениеДоговорыBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn,
            this.регистрационныйНомерDataGridViewTextBoxColumn,
            this.кодАгентаDataGridViewTextBoxColumn,
            this.кодКвартирыDataGridViewTextBoxColumn,
            this.началоДействийДоговораDataGridViewTextBoxColumn,
            this.окончаниеДействийДоговораDataGridViewTextBoxColumn,
            this.стоимостьКвартирыDataGridViewTextBoxColumn,
            this.дополнительныеУсловияDataGridViewTextBoxColumn,
            this.вознаграждениеЦентраОценкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.договорыBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // регистрационныйНомерДоговораDataGridViewTextBoxColumn
            // 
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный номер договора";
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn.HeaderText = "Регистрационный номер договора";
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn.Name = "регистрационныйНомерДоговораDataGridViewTextBoxColumn";
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // регистрационныйНомерDataGridViewTextBoxColumn
            // 
            this.регистрационныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Регистрационный номер";
            this.регистрационныйНомерDataGridViewTextBoxColumn.HeaderText = "Регистрационный номер";
            this.регистрационныйНомерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.регистрационныйНомерDataGridViewTextBoxColumn.Name = "регистрационныйНомерDataGridViewTextBoxColumn";
            this.регистрационныйНомерDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодАгентаDataGridViewTextBoxColumn
            // 
            this.кодАгентаDataGridViewTextBoxColumn.DataPropertyName = "Код агента";
            this.кодАгентаDataGridViewTextBoxColumn.HeaderText = "Код агента";
            this.кодАгентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодАгентаDataGridViewTextBoxColumn.Name = "кодАгентаDataGridViewTextBoxColumn";
            this.кодАгентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодКвартирыDataGridViewTextBoxColumn
            // 
            this.кодКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Код квартиры";
            this.кодКвартирыDataGridViewTextBoxColumn.HeaderText = "Код квартиры";
            this.кодКвартирыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодКвартирыDataGridViewTextBoxColumn.Name = "кодКвартирыDataGridViewTextBoxColumn";
            this.кодКвартирыDataGridViewTextBoxColumn.Width = 125;
            // 
            // началоДействийДоговораDataGridViewTextBoxColumn
            // 
            this.началоДействийДоговораDataGridViewTextBoxColumn.DataPropertyName = "Начало действий договора";
            this.началоДействийДоговораDataGridViewTextBoxColumn.HeaderText = "Начало действий договора";
            this.началоДействийДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.началоДействийДоговораDataGridViewTextBoxColumn.Name = "началоДействийДоговораDataGridViewTextBoxColumn";
            this.началоДействийДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // окончаниеДействийДоговораDataGridViewTextBoxColumn
            // 
            this.окончаниеДействийДоговораDataGridViewTextBoxColumn.DataPropertyName = "Окончание действий договора";
            this.окончаниеДействийДоговораDataGridViewTextBoxColumn.HeaderText = "Окончание действий договора";
            this.окончаниеДействийДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.окончаниеДействийДоговораDataGridViewTextBoxColumn.Name = "окончаниеДействийДоговораDataGridViewTextBoxColumn";
            this.окончаниеДействийДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьКвартирыDataGridViewTextBoxColumn
            // 
            this.стоимостьКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Стоимость квартиры";
            this.стоимостьКвартирыDataGridViewTextBoxColumn.HeaderText = "Стоимость квартиры";
            this.стоимостьКвартирыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьКвартирыDataGridViewTextBoxColumn.Name = "стоимостьКвартирыDataGridViewTextBoxColumn";
            this.стоимостьКвартирыDataGridViewTextBoxColumn.Width = 125;
            // 
            // дополнительныеУсловияDataGridViewTextBoxColumn
            // 
            this.дополнительныеУсловияDataGridViewTextBoxColumn.DataPropertyName = "Дополнительные условия";
            this.дополнительныеУсловияDataGridViewTextBoxColumn.HeaderText = "Дополнительные условия";
            this.дополнительныеУсловияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.дополнительныеУсловияDataGridViewTextBoxColumn.Name = "дополнительныеУсловияDataGridViewTextBoxColumn";
            this.дополнительныеУсловияDataGridViewTextBoxColumn.Width = 125;
            // 
            // вознаграждениеЦентраОценкиDataGridViewTextBoxColumn
            // 
            this.вознаграждениеЦентраОценкиDataGridViewTextBoxColumn.DataPropertyName = "Вознаграждение Центра оценки";
            this.вознаграждениеЦентраОценкиDataGridViewTextBoxColumn.HeaderText = "Вознаграждение Центра оценки";
            this.вознаграждениеЦентраОценкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вознаграждениеЦентраОценкиDataGridViewTextBoxColumn.Name = "вознаграждениеЦентраОценкиDataGridViewTextBoxColumn";
            this.вознаграждениеЦентраОценкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // договорыBindingSource
            // 
            this.договорыBindingSource.DataMember = "Договоры";
            this.договорыBindingSource.DataSource = this.уП01_ИСПП5_Работягова_ААDataSet;
            // 
            // уП01_ИСПП5_Работягова_ААDataSet
            // 
            this.уП01_ИСПП5_Работягова_ААDataSet.DataSetName = "УП01_ИСПП5_Работягова_ААDataSet";
            this.уП01_ИСПП5_Работягова_ААDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договорыTableAdapter
            // 
            this.договорыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1105, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Вернуться в меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПродленияDataGridViewTextBoxColumn,
            this.продлениеСрокаДействияДоговораDataGridViewTextBoxColumn,
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.fKПродлениеДоговорыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 225);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(460, 185);
            this.dataGridView2.TabIndex = 4;
            // 
            // кодПродленияDataGridViewTextBoxColumn
            // 
            this.кодПродленияDataGridViewTextBoxColumn.DataPropertyName = "Код продления";
            this.кодПродленияDataGridViewTextBoxColumn.HeaderText = "Код продления";
            this.кодПродленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПродленияDataGridViewTextBoxColumn.Name = "кодПродленияDataGridViewTextBoxColumn";
            this.кодПродленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // продлениеСрокаДействияДоговораDataGridViewTextBoxColumn
            // 
            this.продлениеСрокаДействияДоговораDataGridViewTextBoxColumn.DataPropertyName = "Продление срока действия договора";
            this.продлениеСрокаДействияДоговораDataGridViewTextBoxColumn.HeaderText = "Продление срока действия договора";
            this.продлениеСрокаДействияДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.продлениеСрокаДействияДоговораDataGridViewTextBoxColumn.Name = "продлениеСрокаДействияДоговораDataGridViewTextBoxColumn";
            this.продлениеСрокаДействияДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // регистрационныйНомерДоговораDataGridViewTextBoxColumn1
            // 
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn1.DataPropertyName = "Регистрационный номер договора";
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn1.HeaderText = "Регистрационный номер договора";
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn1.Name = "регистрационныйНомерДоговораDataGridViewTextBoxColumn1";
            this.регистрационныйНомерДоговораDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fKПродлениеДоговорыBindingSource
            // 
            this.fKПродлениеДоговорыBindingSource.DataMember = "FK_Продление_Договоры";
            this.fKПродлениеДоговорыBindingSource.DataSource = this.договорыBindingSource;
            // 
            // продлениеTableAdapter
            // 
            this.продлениеTableAdapter.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(172, 26);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(251, 22);
            this.textBox6.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 80);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(251, 22);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 135);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(251, 22);
            this.textBox4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Начало действий ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Оканчание действий";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(484, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 185);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Продление срока";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.fKПродлениеДоговорыBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.SaveButton,
            this.CancelButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1284, 31);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(56, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(29, 28);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(29, 28);
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 412);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Данные о договорах";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП01_ИСПП5_Работягова_ААDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПродлениеДоговорыBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private УП01_ИСПП5_Работягова_ААDataSet уП01_ИСПП5_Работягова_ААDataSet;
        private System.Windows.Forms.BindingSource договорыBindingSource;
        private УП01_ИСПП5_Работягова_ААDataSetTableAdapters.ДоговорыTableAdapter договорыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйНомерДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАгентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началоДействийДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окончаниеДействийДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дополнительныеУсловияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вознаграждениеЦентраОценкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKПродлениеДоговорыBindingSource;
        private УП01_ИСПП5_Работягова_ААDataSetTableAdapters.ПродлениеTableAdapter продлениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продлениеСрокаДействияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регистрационныйНомерДоговораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton CancelButton;
    }
}