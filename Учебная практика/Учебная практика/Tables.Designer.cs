namespace Учебная_практика
{
    partial class Tables
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Abityrient = new System.Windows.Forms.ToolStripLabel();
            this.EGE = new System.Windows.Forms.ToolStripLabel();
            this.Contract = new System.Windows.Forms.ToolStripLabel();
            this.Commission = new System.Windows.Forms.ToolStripLabel();
            this.Proshedshie = new System.Windows.Forms.ToolStripLabel();
            this.PravaDostypa = new System.Windows.Forms.ToolStripLabel();
            this.UniversalTable = new System.Windows.Forms.DataGridView();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.ArrowLeft = new System.Windows.Forms.Button();
            this.ArrowRight = new System.Windows.Forms.Button();
            this.NameColumn1 = new System.Windows.Forms.Label();
            this.NameColumn2 = new System.Windows.Forms.Label();
            this.NameColumn3 = new System.Windows.Forms.Label();
            this.NameColumn4 = new System.Windows.Forms.Label();
            this.NameColumn5 = new System.Windows.Forms.Label();
            this.ExitToAvtorization = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PhotoAbPicture = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhotoAb = new System.Windows.Forms.Button();
            this.YesNo = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.PhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.MenuPrav = new System.Windows.Forms.ComboBox();
            this.MenuOsnov = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoAbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abityrient,
            this.EGE,
            this.Contract,
            this.Commission,
            this.Proshedshie,
            this.PravaDostypa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Abityrient
            // 
            this.Abityrient.AutoSize = false;
            this.Abityrient.Name = "Abityrient";
            this.Abityrient.Size = new System.Drawing.Size(100, 22);
            this.Abityrient.Text = "Абитуриент";
            this.Abityrient.Click += new System.EventHandler(this.Abityrient_Click);
            // 
            // EGE
            // 
            this.EGE.AutoSize = false;
            this.EGE.Name = "EGE";
            this.EGE.Size = new System.Drawing.Size(100, 22);
            this.EGE.Text = "ЕГЭ абитуриента";
            this.EGE.Click += new System.EventHandler(this.EGE_Click);
            // 
            // Contract
            // 
            this.Contract.AutoSize = false;
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(100, 22);
            this.Contract.Text = "Контракт";
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // Commission
            // 
            this.Commission.AutoSize = false;
            this.Commission.Name = "Commission";
            this.Commission.Size = new System.Drawing.Size(100, 22);
            this.Commission.Text = "Коммиссия";
            this.Commission.Click += new System.EventHandler(this.Commission_Click);
            // 
            // Proshedshie
            // 
            this.Proshedshie.AutoSize = false;
            this.Proshedshie.Name = "Proshedshie";
            this.Proshedshie.Size = new System.Drawing.Size(100, 22);
            this.Proshedshie.Text = "Прошедшие";
            this.Proshedshie.Click += new System.EventHandler(this.Proshedshie_Click);
            // 
            // PravaDostypa
            // 
            this.PravaDostypa.AutoSize = false;
            this.PravaDostypa.Name = "PravaDostypa";
            this.PravaDostypa.Size = new System.Drawing.Size(100, 22);
            this.PravaDostypa.Text = "Права доступа";
            this.PravaDostypa.Click += new System.EventHandler(this.PravaDostypa_Click);
            // 
            // UniversalTable
            // 
            this.UniversalTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.UniversalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UniversalTable.Location = new System.Drawing.Point(12, 28);
            this.UniversalTable.Name = "UniversalTable";
            this.UniversalTable.Size = new System.Drawing.Size(583, 165);
            this.UniversalTable.TabIndex = 1;
            this.UniversalTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UniversalTable_CellClick);
            // 
            // TB1
            // 
            this.TB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB1.Location = new System.Drawing.Point(12, 233);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 20);
            this.TB1.TabIndex = 2;
            this.TB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB1_KeyPress);
            // 
            // TB2
            // 
            this.TB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB2.Location = new System.Drawing.Point(132, 233);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(100, 20);
            this.TB2.TabIndex = 3;
            this.TB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB2_KeyPress);
            // 
            // TB3
            // 
            this.TB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB3.Location = new System.Drawing.Point(252, 233);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(100, 20);
            this.TB3.TabIndex = 4;
            // 
            // TB4
            // 
            this.TB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB4.Location = new System.Drawing.Point(374, 233);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(100, 20);
            this.TB4.TabIndex = 5;
            this.TB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB4_KeyPress);
            // 
            // TB5
            // 
            this.TB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB5.Location = new System.Drawing.Point(495, 233);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(100, 20);
            this.TB5.TabIndex = 6;
            this.TB5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB5_KeyPress);
            // 
            // ArrowLeft
            // 
            this.ArrowLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.ArrowLeft.Location = new System.Drawing.Point(12, 259);
            this.ArrowLeft.Name = "ArrowLeft";
            this.ArrowLeft.Size = new System.Drawing.Size(289, 23);
            this.ArrowLeft.TabIndex = 7;
            this.ArrowLeft.Text = "<-------------";
            this.ArrowLeft.UseVisualStyleBackColor = false;
            this.ArrowLeft.Click += new System.EventHandler(this.ArrowLeft_Click);
            // 
            // ArrowRight
            // 
            this.ArrowRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.ArrowRight.Location = new System.Drawing.Point(307, 259);
            this.ArrowRight.Name = "ArrowRight";
            this.ArrowRight.Size = new System.Drawing.Size(305, 23);
            this.ArrowRight.TabIndex = 8;
            this.ArrowRight.Text = "------------->";
            this.ArrowRight.UseVisualStyleBackColor = false;
            this.ArrowRight.Click += new System.EventHandler(this.ArrowRight_Click);
            // 
            // NameColumn1
            // 
            this.NameColumn1.Location = new System.Drawing.Point(12, 196);
            this.NameColumn1.Name = "NameColumn1";
            this.NameColumn1.Size = new System.Drawing.Size(100, 34);
            this.NameColumn1.TabIndex = 9;
            this.NameColumn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameColumn2
            // 
            this.NameColumn2.Location = new System.Drawing.Point(132, 196);
            this.NameColumn2.Name = "NameColumn2";
            this.NameColumn2.Size = new System.Drawing.Size(100, 34);
            this.NameColumn2.TabIndex = 10;
            this.NameColumn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameColumn3
            // 
            this.NameColumn3.Location = new System.Drawing.Point(252, 196);
            this.NameColumn3.Name = "NameColumn3";
            this.NameColumn3.Size = new System.Drawing.Size(100, 34);
            this.NameColumn3.TabIndex = 11;
            this.NameColumn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameColumn4
            // 
            this.NameColumn4.Location = new System.Drawing.Point(374, 196);
            this.NameColumn4.Name = "NameColumn4";
            this.NameColumn4.Size = new System.Drawing.Size(100, 34);
            this.NameColumn4.TabIndex = 12;
            this.NameColumn4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameColumn5
            // 
            this.NameColumn5.Location = new System.Drawing.Point(495, 196);
            this.NameColumn5.Name = "NameColumn5";
            this.NameColumn5.Size = new System.Drawing.Size(100, 34);
            this.NameColumn5.TabIndex = 13;
            this.NameColumn5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitToAvtorization
            // 
            this.ExitToAvtorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.ExitToAvtorization.Location = new System.Drawing.Point(12, 346);
            this.ExitToAvtorization.Name = "ExitToAvtorization";
            this.ExitToAvtorization.Size = new System.Drawing.Size(600, 23);
            this.ExitToAvtorization.TabIndex = 15;
            this.ExitToAvtorization.Text = "Вернуться к авторизации";
            this.ExitToAvtorization.UseVisualStyleBackColor = false;
            this.ExitToAvtorization.Click += new System.EventHandler(this.ExitToAvtorization_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.Exit.Location = new System.Drawing.Point(12, 375);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(600, 23);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.Create.Location = new System.Drawing.Point(12, 288);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(289, 23);
            this.Create.TabIndex = 17;
            this.Create.Text = "Создать запись";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhotoAbPicture
            // 
            this.PhotoAbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoAbPicture.Location = new System.Drawing.Point(625, 28);
            this.PhotoAbPicture.Name = "PhotoAbPicture";
            this.PhotoAbPicture.Size = new System.Drawing.Size(200, 200);
            this.PhotoAbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoAbPicture.TabIndex = 19;
            this.PhotoAbPicture.TabStop = false;
            this.PhotoAbPicture.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(625, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Фото абитуриента";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // PhotoAb
            // 
            this.PhotoAb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.PhotoAb.Location = new System.Drawing.Point(620, 331);
            this.PhotoAb.Name = "PhotoAb";
            this.PhotoAb.Size = new System.Drawing.Size(100, 23);
            this.PhotoAb.TabIndex = 21;
            this.PhotoAb.Text = "Выбрать";
            this.PhotoAb.UseVisualStyleBackColor = false;
            this.PhotoAb.Visible = false;
            this.PhotoAb.Click += new System.EventHandler(this.PhotoAb_Click);
            // 
            // YesNo
            // 
            this.YesNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.YesNo.FormattingEnabled = true;
            this.YesNo.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.YesNo.Location = new System.Drawing.Point(726, 328);
            this.YesNo.Name = "YesNo";
            this.YesNo.Size = new System.Drawing.Size(100, 21);
            this.YesNo.TabIndex = 22;
            this.YesNo.Text = "Выберите";
            this.YesNo.Visible = false;
            this.YesNo.SelectedValueChanged += new System.EventHandler(this.YesNo_SelectedValueChanged);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(726, 276);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 20);
            this.Date.TabIndex = 23;
            this.Date.Visible = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.Delete.Location = new System.Drawing.Point(307, 288);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(305, 23);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.Update.Location = new System.Drawing.Point(16, 317);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(596, 23);
            this.Update.TabIndex = 25;
            this.Update.Text = "Изменить поле";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // PhoneNum
            // 
            this.PhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNum.Location = new System.Drawing.Point(726, 302);
            this.PhoneNum.Mask = "+7(999)999-99-99";
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(100, 20);
            this.PhoneNum.TabIndex = 26;
            this.PhoneNum.Visible = false;
            this.PhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNum_KeyPress);
            // 
            // MenuPrav
            // 
            this.MenuPrav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.MenuPrav.FormattingEnabled = true;
            this.MenuPrav.Items.AddRange(new object[] {
            "Гость",
            "Оператор",
            "Администратор",
            "Сотрудник"});
            this.MenuPrav.Location = new System.Drawing.Point(620, 276);
            this.MenuPrav.Name = "MenuPrav";
            this.MenuPrav.Size = new System.Drawing.Size(100, 21);
            this.MenuPrav.TabIndex = 27;
            this.MenuPrav.Text = "Выберите";
            this.MenuPrav.Visible = false;
            this.MenuPrav.SelectedValueChanged += new System.EventHandler(this.MenuPrav_SelectedValueChanged);
            // 
            // MenuOsnov
            // 
            this.MenuOsnov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(214)))));
            this.MenuOsnov.FormattingEnabled = true;
            this.MenuOsnov.Items.AddRange(new object[] {
            "Платная",
            "Бюджет"});
            this.MenuOsnov.Location = new System.Drawing.Point(620, 304);
            this.MenuOsnov.Name = "MenuOsnov";
            this.MenuOsnov.Size = new System.Drawing.Size(100, 21);
            this.MenuOsnov.TabIndex = 28;
            this.MenuOsnov.Text = "Выберите";
            this.MenuOsnov.Visible = false;
            this.MenuOsnov.SelectedValueChanged += new System.EventHandler(this.MenuOsnov_SelectedValueChanged);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(841, 407);
            this.Controls.Add(this.MenuOsnov);
            this.Controls.Add(this.MenuPrav);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.YesNo);
            this.Controls.Add(this.PhotoAb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhotoAbPicture);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ExitToAvtorization);
            this.Controls.Add(this.NameColumn5);
            this.Controls.Add(this.NameColumn4);
            this.Controls.Add(this.NameColumn3);
            this.Controls.Add(this.NameColumn2);
            this.Controls.Add(this.NameColumn1);
            this.Controls.Add(this.ArrowRight);
            this.Controls.Add(this.ArrowLeft);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.UniversalTable);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tables";
            this.Text = "Работа с таблицами";
            this.Load += new System.EventHandler(this.Tables_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoAbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Abityrient;
        private System.Windows.Forms.ToolStripLabel EGE;
        private System.Windows.Forms.ToolStripLabel Contract;
        private System.Windows.Forms.ToolStripLabel Commission;
        private System.Windows.Forms.ToolStripLabel Proshedshie;
        private System.Windows.Forms.ToolStripLabel PravaDostypa;
        private System.Windows.Forms.DataGridView UniversalTable;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.Button ArrowLeft;
        private System.Windows.Forms.Button ArrowRight;
        private System.Windows.Forms.Label NameColumn1;
        private System.Windows.Forms.Label NameColumn2;
        private System.Windows.Forms.Label NameColumn3;
        private System.Windows.Forms.Label NameColumn4;
        private System.Windows.Forms.Label NameColumn5;
        private System.Windows.Forms.Button ExitToAvtorization;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PhotoAbPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PhotoAb;
        private System.Windows.Forms.ComboBox YesNo;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.MaskedTextBox PhoneNum;
        private System.Windows.Forms.ComboBox MenuPrav;
        private System.Windows.Forms.ComboBox MenuOsnov;
    }
}