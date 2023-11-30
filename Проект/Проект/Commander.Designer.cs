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
            this.labelFam = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1Check = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.labelSoldier = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.buttonPassport = new System.Windows.Forms.Button();
            this.buttonBat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.командирыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостверениеличностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.военнослужащиеBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
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
            // labelFam
            // 
            this.labelFam.AutoSize = true;
            this.labelFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Фамилия", true));
            this.labelFam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFam.Location = new System.Drawing.Point(11, 80);
            this.labelFam.Name = "labelFam";
            this.labelFam.Size = new System.Drawing.Size(45, 19);
            this.labelFam.TabIndex = 3;
            this.labelFam.Text = "label1";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Отчество", true));
            this.labelName2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName2.Location = new System.Drawing.Point(11, 142);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(45, 19);
            this.labelName2.TabIndex = 4;
            this.labelName2.Text = "label2";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Имя", true));
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(11, 111);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "label3";
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
            // button1Check
            // 
            this.button1Check.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Check.Location = new System.Drawing.Point(207, 212);
            this.button1Check.Name = "button1Check";
            this.button1Check.Size = new System.Drawing.Size(102, 27);
            this.button1Check.TabIndex = 8;
            this.button1Check.Text = "Проверить";
            this.button1Check.UseVisualStyleBackColor = true;
            this.button1Check.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.командирыBindingSource, "Код_Удовстверения", true));
            this.textBoxPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(160, 212);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(41, 26);
            this.textBoxPass.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(7, 291);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 27);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(120, 291);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(104, 27);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev.Location = new System.Drawing.Point(10, 324);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 28);
            this.buttonPrev.TabIndex = 11;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(91, 324);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 28);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button5_Click);
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
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCom.Location = new System.Drawing.Point(11, 16);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(114, 19);
            this.labelCom.TabIndex = 14;
            this.labelCom.Text = "Код командира:";
            // 
            // labelSoldier
            // 
            this.labelSoldier.AutoSize = true;
            this.labelSoldier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoldier.Location = new System.Drawing.Point(11, 47);
            this.labelSoldier.Name = "labelSoldier";
            this.labelSoldier.Size = new System.Drawing.Size(163, 19);
            this.labelSoldier.TabIndex = 15;
            this.labelSoldier.Text = "Код военнослужащего:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(6, 215);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(148, 19);
            this.labelPass.TabIndex = 16;
            this.labelPass.Text = "Номер удостверения";
            // 
            // buttonPassport
            // 
            this.buttonPassport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPassport.Location = new System.Drawing.Point(207, 172);
            this.buttonPassport.Name = "buttonPassport";
            this.buttonPassport.Size = new System.Drawing.Size(118, 29);
            this.buttonPassport.TabIndex = 17;
            this.buttonPassport.Text = "Удостверение";
            this.buttonPassport.UseVisualStyleBackColor = true;
            this.buttonPassport.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonBat
            // 
            this.buttonBat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBat.Location = new System.Drawing.Point(10, 247);
            this.buttonBat.Name = "buttonBat";
            this.buttonBat.Size = new System.Drawing.Size(101, 29);
            this.buttonBat.TabIndex = 18;
            this.buttonBat.Text = "Батальон";
            this.buttonBat.UseVisualStyleBackColor = true;
            this.buttonBat.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxPhoto);
            this.panel1.Controls.Add(this.buttonReturn);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.labelCom);
            this.panel1.Controls.Add(this.buttonPassport);
            this.panel1.Controls.Add(this.buttonBat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1Check);
            this.panel1.Controls.Add(this.labelFam);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.labelPass);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.labelSoldier);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelName2);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 355);
            this.panel1.TabIndex = 19;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(207, 3);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(121, 158);
            this.pictureBoxPhoto.TabIndex = 35;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonReturn.Location = new System.Drawing.Point(237, 289);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(102, 28);
            this.buttonReturn.TabIndex = 34;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(172, 323);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(102, 29);
            this.buttonOpen.TabIndex = 19;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "картинка", true));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 10);
            this.label9.TabIndex = 36;
            this.label9.Text = "label9";
            // 
            // Commander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label9);
            this.Name = "Commander";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label labelFam;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1Check;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label labelSoldier;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonPassport;
        private System.Windows.Forms.Button buttonBat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
    }
}