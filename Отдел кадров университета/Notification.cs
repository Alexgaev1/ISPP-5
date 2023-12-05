using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Отдел_кадров_университета
{
    public class Notification : Form
    {
        public Label titleLabel;

        public string Title
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = value; }
        }

        public Notification()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(10, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(296, 71);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Заголовок уведомления";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 79);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уведомление";
            this.ResumeLayout(false);

        }

        private void messageLabel_Click(object sender, EventArgs e)
        {
            
        }

        public void Show(int duration)
        {
            // Отображаем форму уведомления
            Show();

            // Запускаем таймер для закрытия формы через указанное время
            Timer timer = new Timer();
            timer.Interval = duration;
            timer.Tick += (s, e) =>
            {
                Close();
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
