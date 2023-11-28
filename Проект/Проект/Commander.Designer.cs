namespace Проект
{
    partial class Commander
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодкомандираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодУдовстверенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.командирыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодУдовстверенияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодвоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.званиевоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видслужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началослужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.конецслужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.удостверениеличностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годрожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийтелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адреспроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.военнослужащиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.командирыTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.КомандирыTableAdapter();
            this.удостверение_личностиTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.Удостверение_личностиTableAdapter();
            this.военнослужащиеTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.ВоеннослужащиеTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.командирыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостверениеличностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.военнослужащиеBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодкомандираDataGridViewTextBoxColumn,
            this.кодУдовстверенияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.командирыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // кодкомандираDataGridViewTextBoxColumn
            // 
            this.кодкомандираDataGridViewTextBoxColumn.DataPropertyName = "Код_командира";
            this.кодкомандираDataGridViewTextBoxColumn.HeaderText = "Код_командира";
            this.кодкомандираDataGridViewTextBoxColumn.Name = "кодкомандираDataGridViewTextBoxColumn";
            this.кодкомандираDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодУдовстверенияDataGridViewTextBoxColumn
            // 
            this.кодУдовстверенияDataGridViewTextBoxColumn.DataPropertyName = "Код_Удовстверения";
            this.кодУдовстверенияDataGridViewTextBoxColumn.HeaderText = "Код_Удовстверения";
            this.кодУдовстверенияDataGridViewTextBoxColumn.Name = "кодУдовстверенияDataGridViewTextBoxColumn";
            // 
            // командирыBindingSource
            // 
            this.командирыBindingSource.DataMember = "Командиры";
            this.командирыBindingSource.DataSource = this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
            // 
            // уП_ПМ01_ИСПП_5_Степурин_НСDataSet
            // 
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.DataSetName = "УП_ПМ01_ИСПП_5_Степурин_НСDataSet";
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодУдовстверенияDataGridViewTextBoxColumn1,
            this.кодвоеннослужащегоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.званиевоеннослужащегоDataGridViewTextBoxColumn,
            this.видслужбыDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn,
            this.началослужбыDataGridViewTextBoxColumn,
            this.конецслужбыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.удостверениеличностиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(188, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(84, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // кодУдовстверенияDataGridViewTextBoxColumn1
            // 
            this.кодУдовстверенияDataGridViewTextBoxColumn1.DataPropertyName = "Код_Удовстверения";
            this.кодУдовстверенияDataGridViewTextBoxColumn1.HeaderText = "Код_Удовстверения";
            this.кодУдовстверенияDataGridViewTextBoxColumn1.Name = "кодУдовстверенияDataGridViewTextBoxColumn1";
            this.кодУдовстверенияDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кодвоеннослужащегоDataGridViewTextBoxColumn
            // 
            this.кодвоеннослужащегоDataGridViewTextBoxColumn.DataPropertyName = "Код_военнослужащего";
            this.кодвоеннослужащегоDataGridViewTextBoxColumn.HeaderText = "Код_военнослужащего";
            this.кодвоеннослужащегоDataGridViewTextBoxColumn.Name = "кодвоеннослужащегоDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // званиевоеннослужащегоDataGridViewTextBoxColumn
            // 
            this.званиевоеннослужащегоDataGridViewTextBoxColumn.DataPropertyName = "Звание_военнослужащего";
            this.званиевоеннослужащегоDataGridViewTextBoxColumn.HeaderText = "Звание_военнослужащего";
            this.званиевоеннослужащегоDataGridViewTextBoxColumn.Name = "званиевоеннослужащегоDataGridViewTextBoxColumn";
            // 
            // видслужбыDataGridViewTextBoxColumn
            // 
            this.видслужбыDataGridViewTextBoxColumn.DataPropertyName = "Вид_службы";
            this.видслужбыDataGridViewTextBoxColumn.HeaderText = "Вид_службы";
            this.видслужбыDataGridViewTextBoxColumn.Name = "видслужбыDataGridViewTextBoxColumn";
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            // 
            // началослужбыDataGridViewTextBoxColumn
            // 
            this.началослужбыDataGridViewTextBoxColumn.DataPropertyName = "Начало_службы";
            this.началослужбыDataGridViewTextBoxColumn.HeaderText = "Начало_службы";
            this.началослужбыDataGridViewTextBoxColumn.Name = "началослужбыDataGridViewTextBoxColumn";
            // 
            // конецслужбыDataGridViewTextBoxColumn
            // 
            this.конецслужбыDataGridViewTextBoxColumn.DataPropertyName = "Конец_службы";
            this.конецслужбыDataGridViewTextBoxColumn.HeaderText = "Конец_службы";
            this.конецслужбыDataGridViewTextBoxColumn.Name = "конецслужбыDataGridViewTextBoxColumn";
            // 
            // удостверениеличностиBindingSource
            // 
            this.удостверениеличностиBindingSource.DataMember = "Удостверение_личности";
            this.удостверениеличностиBindingSource.DataSource = this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1,
            this.фотоDataGridViewImageColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.годрожденияDataGridViewTextBoxColumn,
            this.домашнийтелефонDataGridViewTextBoxColumn,
            this.адреспроживанияDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.военнослужащиеBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(188, 73);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(84, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // кодвоеннослужащегоDataGridViewTextBoxColumn1
            // 
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1.DataPropertyName = "Код_военнослужащего";
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1.HeaderText = "Код_военнослужащего";
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1.Name = "кодвоеннослужащегоDataGridViewTextBoxColumn1";
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // годрожденияDataGridViewTextBoxColumn
            // 
            this.годрожденияDataGridViewTextBoxColumn.DataPropertyName = "Год_рождения";
            this.годрожденияDataGridViewTextBoxColumn.HeaderText = "Год_рождения";
            this.годрожденияDataGridViewTextBoxColumn.Name = "годрожденияDataGridViewTextBoxColumn";
            // 
            // домашнийтелефонDataGridViewTextBoxColumn
            // 
            this.домашнийтелефонDataGridViewTextBoxColumn.DataPropertyName = "Домашний _телефон";
            this.домашнийтелефонDataGridViewTextBoxColumn.HeaderText = "Домашний _телефон";
            this.домашнийтелефонDataGridViewTextBoxColumn.Name = "домашнийтелефонDataGridViewTextBoxColumn";
            // 
            // адреспроживанияDataGridViewTextBoxColumn
            // 
            this.адреспроживанияDataGridViewTextBoxColumn.DataPropertyName = "Адрес_проживания";
            this.адреспроживанияDataGridViewTextBoxColumn.HeaderText = "Адрес_проживания";
            this.адреспроживанияDataGridViewTextBoxColumn.Name = "адреспроживанияDataGridViewTextBoxColumn";
            // 
            // военнослужащиеBindingSource
            // 
            this.военнослужащиеBindingSource.DataMember = "Военнослужащие";
            this.военнослужащиеBindingSource.DataSource = this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
            // 
            // командирыTableAdapter
            // 
            this.командирыTableAdapter.ClearBeforeFill = true;
            // 
            // удостверение_личностиTableAdapter
            // 
            this.удостверение_личностиTableAdapter.ClearBeforeFill = true;
            // 
            // военнослужащиеTableAdapter
            // 
            this.военнослужащиеTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Фамилия", true));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Отчество", true));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Имя", true));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Код_военнослужащего", true));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(177, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(204, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.командирыBindingSource, "Код_Удовстверения", true));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(157, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 26);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(7, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(120, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 27);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(10, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(91, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 12;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.командирыBindingSource, "Код_командира", true));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(131, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Код командира:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Код военнослужащего:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер удостверения";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(188, 150);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 29);
            this.button6.TabIndex = 17;
            this.button6.Text = "Удостверение";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(10, 247);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 29);
            this.button7.TabIndex = 18;
            this.button7.Text = "Батальон";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 355);
            this.panel1.TabIndex = 19;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button9.Location = new System.Drawing.Point(216, 248);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 28);
            this.button9.TabIndex = 34;
            this.button9.Text = "Вернуться";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(172, 323);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 29);
            this.button8.TabIndex = 19;
            this.button8.Text = "Открыть";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Commander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Commander";
            this.Text = "Commander";
            this.Load += new System.EventHandler(this.Commander_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.командирыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостверениеличностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.военнослужащиеBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSet уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
        private System.Windows.Forms.BindingSource командирыBindingSource;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.КомандирыTableAdapter командирыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкомандираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодУдовстверенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource удостверениеличностиBindingSource;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.Удостверение_личностиTableAdapter удостверение_личностиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодУдовстверенияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвоеннослужащегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn званиевоеннослужащегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видслужбыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началослужбыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn конецслужбыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource военнослужащиеBindingSource;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.ВоеннослужащиеTableAdapter военнослужащиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвоеннослужащегоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годрожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домашнийтелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адреспроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}