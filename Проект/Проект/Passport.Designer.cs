namespace Проект
{
    partial class Passport
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
            this.кодУдовстверенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодвоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.званиевоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видслужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началослужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.конецслужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.удостверениеличностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSet();
            this.удостверение_личностиTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.Удостверение_личностиTableAdapter();
            this.военнослужащиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годрожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийтелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адреспроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.военнослужащиеTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.ВоеннослужащиеTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxSoldier = new System.Windows.Forms.TextBox();
            this.labelFam = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelSoldier = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTypServ = new System.Windows.Forms.Label();
            this.labelStartServ = new System.Windows.Forms.Label();
            this.labelEndServ = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPas = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxTypServ = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBoxEndServ = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartServ = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостверениеличностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.военнослужащиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодУдовстверенияDataGridViewTextBoxColumn,
            this.кодвоеннослужащегоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.званиевоеннослужащегоDataGridViewTextBoxColumn,
            this.видслужбыDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn,
            this.началослужбыDataGridViewTextBoxColumn,
            this.конецслужбыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.удостверениеличностиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 642);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // кодУдовстверенияDataGridViewTextBoxColumn
            // 
            this.кодУдовстверенияDataGridViewTextBoxColumn.DataPropertyName = "Код_Удовстверения";
            this.кодУдовстверенияDataGridViewTextBoxColumn.HeaderText = "Код_Удовстверения";
            this.кодУдовстверенияDataGridViewTextBoxColumn.Name = "кодУдовстверенияDataGridViewTextBoxColumn";
            this.кодУдовстверенияDataGridViewTextBoxColumn.ReadOnly = true;
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
            // уП_ПМ01_ИСПП_5_Степурин_НСDataSet
            // 
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.DataSetName = "УП_ПМ01_ИСПП_5_Степурин_НСDataSet";
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // удостверение_личностиTableAdapter
            // 
            this.удостверение_личностиTableAdapter.ClearBeforeFill = true;
            // 
            // военнослужащиеBindingSource
            // 
            this.военнослужащиеBindingSource.DataMember = "Военнослужащие";
            this.военнослужащиеBindingSource.DataSource = this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.годрожденияDataGridViewTextBoxColumn,
            this.домашнийтелефонDataGridViewTextBoxColumn,
            this.адреспроживанияDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.военнослужащиеBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(18, 79);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(360, 219);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Visible = false;
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
            // военнослужащиеTableAdapter
            // 
            this.военнослужащиеTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(246, 624);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 34);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonReturn.Location = new System.Drawing.Point(329, 566);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(112, 34);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSoldier
            // 
            this.textBoxSoldier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Код_военнослужащего", true));
            this.textBoxSoldier.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxSoldier.Location = new System.Drawing.Point(9, 61);
            this.textBoxSoldier.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoldier.Name = "textBoxSoldier";
            this.textBoxSoldier.Size = new System.Drawing.Size(42, 26);
            this.textBoxSoldier.TabIndex = 6;
            // 
            // labelFam
            // 
            this.labelFam.AutoSize = true;
            this.labelFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Фамилия", true));
            this.labelFam.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelFam.Location = new System.Drawing.Point(90, 72);
            this.labelFam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFam.Name = "labelFam";
            this.labelFam.Size = new System.Drawing.Size(45, 19);
            this.labelFam.TabIndex = 7;
            this.labelFam.Text = "label1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Имя", true));
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelName.Location = new System.Drawing.Point(203, 72);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "label2";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Отчество", true));
            this.labelName2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelName2.Location = new System.Drawing.Point(325, 72);
            this.labelName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(45, 19);
            this.labelName2.TabIndex = 9;
            this.labelName2.Text = "label3";
            // 
            // textBoxPost
            // 
            this.textBoxPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Должность", true));
            this.textBoxPost.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxPost.Location = new System.Drawing.Point(9, 114);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(148, 26);
            this.textBoxPost.TabIndex = 10;
            // 
            // textBoxNote
            // 
            this.textBoxNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Примечание", true));
            this.textBoxNote.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxNote.Location = new System.Drawing.Point(4, 323);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(445, 235);
            this.textBoxNote.TabIndex = 13;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonNext.Location = new System.Drawing.Point(126, 624);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 34);
            this.buttonNext.TabIndex = 16;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonPrev.Location = new System.Drawing.Point(4, 624);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(112, 34);
            this.buttonPrev.TabIndex = 17;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelSoldier
            // 
            this.labelSoldier.AutoSize = true;
            this.labelSoldier.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelSoldier.Location = new System.Drawing.Point(5, 38);
            this.labelSoldier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoldier.Name = "labelSoldier";
            this.labelSoldier.Size = new System.Drawing.Size(160, 19);
            this.labelSoldier.TabIndex = 18;
            this.labelSoldier.Text = "Код военнослужащего";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPost.Location = new System.Drawing.Point(4, 91);
            this.labelPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(85, 19);
            this.labelPost.TabIndex = 19;
            this.labelPost.Text = "Должность";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelTitle.Location = new System.Drawing.Point(172, 91);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 19);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Звание";
            // 
            // labelTypServ
            // 
            this.labelTypServ.AutoSize = true;
            this.labelTypServ.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelTypServ.Location = new System.Drawing.Point(4, 164);
            this.labelTypServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTypServ.Name = "labelTypServ";
            this.labelTypServ.Size = new System.Drawing.Size(92, 19);
            this.labelTypServ.TabIndex = 21;
            this.labelTypServ.Text = "Вид службы";
            // 
            // labelStartServ
            // 
            this.labelStartServ.AutoSize = true;
            this.labelStartServ.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelStartServ.Location = new System.Drawing.Point(172, 164);
            this.labelStartServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartServ.Name = "labelStartServ";
            this.labelStartServ.Size = new System.Drawing.Size(113, 19);
            this.labelStartServ.TabIndex = 22;
            this.labelStartServ.Text = "Начало службы";
            // 
            // labelEndServ
            // 
            this.labelEndServ.AutoSize = true;
            this.labelEndServ.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelEndServ.Location = new System.Drawing.Point(172, 224);
            this.labelEndServ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndServ.Name = "labelEndServ";
            this.labelEndServ.Size = new System.Drawing.Size(108, 19);
            this.labelEndServ.TabIndex = 23;
            this.labelEndServ.Text = "Конец службы";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelNote.Location = new System.Drawing.Point(4, 300);
            this.labelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(94, 19);
            this.labelNote.TabIndex = 24;
            this.labelNote.Text = "Примечания";
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonDel.Location = new System.Drawing.Point(23, 566);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(112, 34);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelPass2
            // 
            this.labelPass2.AutoSize = true;
            this.labelPass2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Код_Удовстверения", true));
            this.labelPass2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPass2.Location = new System.Drawing.Point(362, 36);
            this.labelPass2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Size = new System.Drawing.Size(52, 19);
            this.labelPass2.TabIndex = 26;
            this.labelPass2.Text = "label11";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(156, 566);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 34);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPas.Location = new System.Drawing.Point(203, 36);
            this.labelPas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(151, 19);
            this.labelPas.TabIndex = 29;
            this.labelPas.Text = "Номер удостверения:";
            
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonOpen.Location = new System.Drawing.Point(366, 624);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(83, 34);
            this.buttonOpen.TabIndex = 30;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonsearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBoxTitle);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.comboBoxTypServ);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.maskedTextBoxEndServ);
            this.panel1.Controls.Add(this.maskedTextBoxStartServ);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.labelPas);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.labelPass2);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.labelNote);
            this.panel1.Controls.Add(this.labelEndServ);
            this.panel1.Controls.Add(this.labelStartServ);
            this.panel1.Controls.Add(this.labelTypServ);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.labelPost);
            this.panel1.Controls.Add(this.labelSoldier);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.textBoxNote);
            this.panel1.Controls.Add(this.textBoxPost);
            this.panel1.Controls.Add(this.labelName2);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelFam);
            this.panel1.Controls.Add(this.textBoxSoldier);
            this.panel1.Controls.Add(this.buttonReturn);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 753);
            this.panel1.TabIndex = 3;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonsearch.Location = new System.Drawing.Point(339, 3);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 37;
            this.buttonsearch.Text = "Найти";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(233, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 36;
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "Рядовой",
            "Евфрейтор",
            "Мл. Сержант",
            "Сержант",
            "Ст. Сержант",
            "Старшина",
            "Прапорщик",
            "Ст. Прапорщик",
            "Мл.Лейтенант",
            "Лейтенант",
            "Ст. Лейтенант",
            "Капитан",
            "Маойр",
            "Подполковник",
            "Полковник",
            "Генерал-майор",
            "Генерал-лейтенант",
            "Генерал-полковник",
            "Генерал-армии",
            "Маршал РФ"});
            this.comboBoxTitle.Location = new System.Drawing.Point(176, 113);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(121, 27);
            this.comboBoxTitle.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Звание_военнослужащего", true));
            this.label14.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(181, 117);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 14);
            this.label14.TabIndex = 36;
            this.label14.Text = "Звание";
            // 
            // comboBoxTypServ
            // 
            this.comboBoxTypServ.FormattingEnabled = true;
            this.comboBoxTypServ.Items.AddRange(new object[] {
            "Срочная",
            "Контрактная"});
            this.comboBoxTypServ.Location = new System.Drawing.Point(4, 186);
            this.comboBoxTypServ.Name = "comboBoxTypServ";
            this.comboBoxTypServ.Size = new System.Drawing.Size(121, 27);
            this.comboBoxTypServ.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Вид_службы", true));
            this.label13.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 193);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 14);
            this.label13.TabIndex = 34;
            this.label13.Text = "Вид службы";
            // 
            // maskedTextBoxEndServ
            // 
            this.maskedTextBoxEndServ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Конец_службы", true));
            this.maskedTextBoxEndServ.Location = new System.Drawing.Point(176, 246);
            this.maskedTextBoxEndServ.Mask = "00/00/0000";
            this.maskedTextBoxEndServ.Name = "maskedTextBoxEndServ";
            this.maskedTextBoxEndServ.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBoxEndServ.TabIndex = 33;
            this.maskedTextBoxEndServ.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxStartServ
            // 
            this.maskedTextBoxStartServ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Начало_службы", true));
            this.maskedTextBoxStartServ.Location = new System.Drawing.Point(176, 186);
            this.maskedTextBoxStartServ.Mask = "00/00/0000";
            this.maskedTextBoxStartServ.Name = "maskedTextBoxStartServ";
            this.maskedTextBoxStartServ.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBoxStartServ.TabIndex = 32;
            this.maskedTextBoxStartServ.ValidatingType = typeof(System.DateTime);
            // 
            // Passport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Passport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passport";
            this.Load += new System.EventHandler(this.Passport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостверениеличностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.военнослужащиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSet уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
        private System.Windows.Forms.BindingSource удостверениеличностиBindingSource;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.Удостверение_личностиTableAdapter удостверение_личностиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодУдовстверенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвоеннослужащегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn званиевоеннослужащегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видслужбыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началослужбыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn конецслужбыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxSoldier;
        private System.Windows.Forms.Label labelFam;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label labelSoldier;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTypServ;
        private System.Windows.Forms.Label labelStartServ;
        private System.Windows.Forms.Label labelEndServ;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelPass2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndServ;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartServ;
        private System.Windows.Forms.ComboBox comboBoxTypServ;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}