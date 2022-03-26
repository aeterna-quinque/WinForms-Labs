namespace WinOuestion
{
    partial class Form1
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
            this.btnyes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(13, 69);
            this.btnyes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(100, 28);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Да";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы довольны своей зарплатой?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(219, 69);
            this.btnno.Margin = new System.Windows.Forms.Padding(0);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(100, 28);
            this.btnno.TabIndex = 2;
            this.btnno.TabStop = false;
            this.btnno.Text = "Нет";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnno_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 149);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Насущный вопрос";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnno;
    }
}

