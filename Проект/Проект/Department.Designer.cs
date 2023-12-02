namespace Проект
{
    partial class Department
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
            this.кодотделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодудостверенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодвзводаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSet();
            this.отделениеTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.ОтделениеTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодУдовстверенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодвоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.званиевоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видслужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началослужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.конецслужбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.удостверениеличностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.удостверение_личностиTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.Удостверение_личностиTableAdapter();
            this.военнослужащиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.военнослужащиеTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.ВоеннослужащиеTableAdapter();
            this.labelSoldier2 = new System.Windows.Forms.Label();
            this.textBoxPlat = new System.Windows.Forms.TextBox();
            this.labelSoldier = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelPlat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDepart = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFam = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.кодвоеннослужащегоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годрожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийтелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адреспроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPassport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостверениеличностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.военнослужащиеBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодотделенияDataGridViewTextBoxColumn,
            this.кодудостверенияDataGridViewTextBoxColumn,
            this.кодвзводаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.отделениеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // кодотделенияDataGridViewTextBoxColumn
            // 
            this.кодотделенияDataGridViewTextBoxColumn.DataPropertyName = "Код_отделения";
            this.кодотделенияDataGridViewTextBoxColumn.HeaderText = "Код_отделения";
            this.кодотделенияDataGridViewTextBoxColumn.Name = "кодотделенияDataGridViewTextBoxColumn";
            this.кодотделенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодудостверенияDataGridViewTextBoxColumn
            // 
            this.кодудостверенияDataGridViewTextBoxColumn.DataPropertyName = "Код_удостверения";
            this.кодудостверенияDataGridViewTextBoxColumn.HeaderText = "Код_удостверения";
            this.кодудостверенияDataGridViewTextBoxColumn.Name = "кодудостверенияDataGridViewTextBoxColumn";
            // 
            // кодвзводаDataGridViewTextBoxColumn
            // 
            this.кодвзводаDataGridViewTextBoxColumn.DataPropertyName = "Код_взвода";
            this.кодвзводаDataGridViewTextBoxColumn.HeaderText = "Код_взвода";
            this.кодвзводаDataGridViewTextBoxColumn.Name = "кодвзводаDataGridViewTextBoxColumn";
            // 
            // отделениеBindingSource
            // 
            this.отделениеBindingSource.DataMember = "Отделение";
            this.отделениеBindingSource.DataSource = this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
            // 
            // уП_ПМ01_ИСПП_5_Степурин_НСDataSet
            // 
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.DataSetName = "УП_ПМ01_ИСПП_5_Степурин_НСDataSet";
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отделениеTableAdapter
            // 
            this.отделениеTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодУдовстверенияDataGridViewTextBoxColumn,
            this.кодвоеннослужащегоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.званиевоеннослужащегоDataGridViewTextBoxColumn,
            this.видслужбыDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn,
            this.началослужбыDataGridViewTextBoxColumn,
            this.конецслужбыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.удостверениеличностиBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(121, 150);
            this.dataGridView2.TabIndex = 1;
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
            // удостверение_личностиTableAdapter
            // 
            this.удостверение_личностиTableAdapter.ClearBeforeFill = true;
            // 
            // военнослужащиеBindingSource
            // 
            this.военнослужащиеBindingSource.DataMember = "Военнослужащие";
            this.военнослужащиеBindingSource.DataSource = this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
            // 
            // военнослужащиеTableAdapter
            // 
            this.военнослужащиеTableAdapter.ClearBeforeFill = true;
            // 
            // labelSoldier2
            // 
            this.labelSoldier2.AutoSize = true;
            this.labelSoldier2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.удостверениеличностиBindingSource, "Код_военнослужащего", true));
            this.labelSoldier2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoldier2.Location = new System.Drawing.Point(176, 199);
            this.labelSoldier2.Name = "labelSoldier2";
            this.labelSoldier2.Size = new System.Drawing.Size(156, 19);
            this.labelSoldier2.TabIndex = 67;
            this.labelSoldier2.Text = "код военнослужащего";
            // 
            // textBoxPlat
            // 
            this.textBoxPlat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделениеBindingSource, "Код_взвода", true));
            this.textBoxPlat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPlat.Location = new System.Drawing.Point(100, 61);
            this.textBoxPlat.Name = "textBoxPlat";
            this.textBoxPlat.Size = new System.Drawing.Size(58, 26);
            this.textBoxPlat.TabIndex = 65;
            // 
            // labelSoldier
            // 
            this.labelSoldier.AutoSize = true;
            this.labelSoldier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoldier.Location = new System.Drawing.Point(7, 199);
            this.labelSoldier.Name = "labelSoldier";
            this.labelSoldier.Size = new System.Drawing.Size(163, 19);
            this.labelSoldier.TabIndex = 64;
            this.labelSoldier.Text = "Код военнослужащего:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(7, 131);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(151, 19);
            this.labelPass.TabIndex = 63;
            this.labelPass.Text = "Номер удостверения:";
            // 
            // labelPlat
            // 
            this.labelPlat.AutoSize = true;
            this.labelPlat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlat.Location = new System.Drawing.Point(7, 68);
            this.labelPlat.Name = "labelPlat";
            this.labelPlat.Size = new System.Drawing.Size(87, 19);
            this.labelPlat.TabIndex = 61;
            this.labelPlat.Text = "Код взвода:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделениеBindingSource, "Код_отделения", true));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(121, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Взвод";
            // 
            // labelDepart
            // 
            this.labelDepart.AutoSize = true;
            this.labelDepart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepart.Location = new System.Drawing.Point(3, 10);
            this.labelDepart.Name = "labelDepart";
            this.labelDepart.Size = new System.Drawing.Size(112, 19);
            this.labelDepart.TabIndex = 56;
            this.labelDepart.Text = "Код отделения:";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Location = new System.Drawing.Point(100, 163);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(131, 26);
            this.buttonCheck.TabIndex = 79;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev.Location = new System.Drawing.Point(3, 393);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(56, 30);
            this.buttonPrev.TabIndex = 78;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(65, 393);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(56, 30);
            this.buttonNext.TabIndex = 77;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(117, 351);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(108, 30);
            this.buttonDel.TabIndex = 76;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(3, 351);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 30);
            this.buttonAdd.TabIndex = 75;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отделениеBindingSource, "Код_удостверения", true));
            this.textBoxPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(164, 124);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(67, 26);
            this.textBoxPass.TabIndex = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPassport);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonsearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.buttonReturn);
            this.panel1.Controls.Add(this.labelName2);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelFam);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.labelDepart);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.labelPlat);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.labelPass);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.labelSoldier);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.textBoxPlat);
            this.panel1.Controls.Add(this.labelSoldier2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 426);
            this.panel1.TabIndex = 81;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonUpdate.Location = new System.Drawing.Point(232, 351);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(112, 30);
            this.buttonUpdate.TabIndex = 85;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(282, 7);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 84;
            this.buttonsearch.Text = "Найти";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(176, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 83;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonReturn.Location = new System.Drawing.Point(267, 395);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(93, 28);
            this.buttonReturn.TabIndex = 83;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button9_Click);
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Отчество", true));
            this.labelName2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName2.Location = new System.Drawing.Point(21, 298);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(163, 19);
            this.labelName2.TabIndex = 84;
            this.labelName2.Text = "Код военнослужащего:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Имя", true));
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(21, 263);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(163, 19);
            this.labelName.TabIndex = 83;
            this.labelName.Text = "Код военнослужащего:";
            // 
            // labelFam
            // 
            this.labelFam.AutoSize = true;
            this.labelFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.военнослужащиеBindingSource, "Фамилия", true));
            this.labelFam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFam.Location = new System.Drawing.Point(21, 231);
            this.labelFam.Name = "labelFam";
            this.labelFam.Size = new System.Drawing.Size(72, 19);
            this.labelFam.TabIndex = 82;
            this.labelFam.Text = "Фамилия";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(125, 393);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(108, 30);
            this.buttonOpen.TabIndex = 81;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView3.Location = new System.Drawing.Point(12, 94);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(284, 150);
            this.dataGridView3.TabIndex = 82;
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
            // buttonPassport
            // 
            this.buttonPassport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPassport.Location = new System.Drawing.Point(239, 121);
            this.buttonPassport.Name = "buttonPassport";
            this.buttonPassport.Size = new System.Drawing.Size(118, 29);
            this.buttonPassport.TabIndex = 83;
            this.buttonPassport.Text = "Удостверение";
            this.buttonPassport.UseVisualStyleBackColor = true;
            this.buttonPassport.Click += new System.EventHandler(this.buttonPassport_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.удостверениеличностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.военнослужащиеBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSet уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
        private System.Windows.Forms.BindingSource отделениеBindingSource;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.ОтделениеTableAdapter отделениеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодотделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодудостверенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвзводаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.BindingSource военнослужащиеBindingSource;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.ВоеннослужащиеTableAdapter военнослужащиеTableAdapter;
        private System.Windows.Forms.Label labelSoldier2;
        private System.Windows.Forms.TextBox textBoxPlat;
        private System.Windows.Forms.Label labelSoldier;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelPlat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDepart;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвоеннослужащегоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годрожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домашнийтелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адреспроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFam;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonPassport;
    }
}