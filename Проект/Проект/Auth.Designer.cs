namespace Проект
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSingup = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.LoginLab = new System.Windows.Forms.Label();
            this.buttonSingout = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.PasswordLab = new System.Windows.Forms.Label();
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSet();
            this.authBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authTableAdapter = new Проект.УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.AuthTableAdapter();
            this.buttonVisPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSingup
            // 
            this.buttonSingup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSingup.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.buttonSingup.Location = new System.Drawing.Point(87, 185);
            this.buttonSingup.Name = "buttonSingup";
            this.buttonSingup.Size = new System.Drawing.Size(94, 32);
            this.buttonSingup.TabIndex = 0;
            this.buttonSingup.Text = "Войти";
            this.buttonSingup.UseVisualStyleBackColor = true;
            this.buttonSingup.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLog.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.textBoxLog.Location = new System.Drawing.Point(127, 66);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(179, 32);
            this.textBoxLog.TabIndex = 1;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoginLab
            // 
            this.LoginLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginLab.AutoSize = true;
            this.LoginLab.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLab.Location = new System.Drawing.Point(46, 75);
            this.LoginLab.Name = "LoginLab";
            this.LoginLab.Size = new System.Drawing.Size(71, 23);
            this.LoginLab.TabIndex = 2;
            this.LoginLab.Text = "Логин:";
            this.LoginLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSingout
            // 
            this.buttonSingout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSingout.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.buttonSingout.Location = new System.Drawing.Point(212, 185);
            this.buttonSingout.Name = "buttonSingout";
            this.buttonSingout.Size = new System.Drawing.Size(94, 32);
            this.buttonSingout.TabIndex = 3;
            this.buttonSingout.Text = "Выйти";
            this.buttonSingout.UseVisualStyleBackColor = true;
            this.buttonSingout.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPass.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.textBoxPass.Location = new System.Drawing.Point(127, 128);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(179, 32);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PasswordLab
            // 
            this.PasswordLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLab.AutoSize = true;
            this.PasswordLab.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLab.Location = new System.Drawing.Point(46, 131);
            this.PasswordLab.Name = "PasswordLab";
            this.PasswordLab.Size = new System.Drawing.Size(81, 23);
            this.PasswordLab.TabIndex = 5;
            this.PasswordLab.Text = "Пароль:";
            this.PasswordLab.Click += new System.EventHandler(this.label2_Click);
            // 
            // уП_ПМ01_ИСПП_5_Степурин_НСDataSet
            // 
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.DataSetName = "УП_ПМ01_ИСПП_5_Степурин_НСDataSet";
            this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authBindingSource
            // 
            this.authBindingSource.DataMember = "Auth";
            this.authBindingSource.DataSource = this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
            // 
            // authTableAdapter
            // 
            this.authTableAdapter.ClearBeforeFill = true;
            // 
            // buttonVisPass
            // 
            this.buttonVisPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVisPass.Location = new System.Drawing.Point(313, 119);
            this.buttonVisPass.Name = "buttonVisPass";
            this.buttonVisPass.Size = new System.Drawing.Size(66, 41);
            this.buttonVisPass.TabIndex = 6;
            this.buttonVisPass.Text = "Показать пароль";
            this.buttonVisPass.UseVisualStyleBackColor = true;
            this.buttonVisPass.Click += new System.EventHandler(this.button3_Click);
            // 
            // Auth
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 272);
            this.Controls.Add(this.buttonVisPass);
            this.Controls.Add(this.PasswordLab);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.buttonSingout);
            this.Controls.Add(this.LoginLab);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonSingup);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.Auth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.уП_ПМ01_ИСПП_5_Степурин_НСDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSingup;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label LoginLab;
        private System.Windows.Forms.Button buttonSingout;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label PasswordLab;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSet уП_ПМ01_ИСПП_5_Степурин_НСDataSet;
        private System.Windows.Forms.BindingSource authBindingSource;
        private УП_ПМ01_ИСПП_5_Степурин_НСDataSetTableAdapters.AuthTableAdapter authTableAdapter;
        private System.Windows.Forms.Button buttonVisPass;
    }
}

