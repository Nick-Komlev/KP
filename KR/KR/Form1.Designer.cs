namespace KR
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
            this.Exit = new System.Windows.Forms.Button();
            this.DataRepr = new System.Windows.Forms.Button();
            this.DataMng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(252, 286);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 39);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // DataRepr
            // 
            this.DataRepr.Location = new System.Drawing.Point(349, 64);
            this.DataRepr.Name = "DataRepr";
            this.DataRepr.Size = new System.Drawing.Size(187, 170);
            this.DataRepr.TabIndex = 0;
            this.DataRepr.Text = "Учет";
            this.DataRepr.UseVisualStyleBackColor = true;
            this.DataRepr.Click += new System.EventHandler(this.DataRepr_Click);
            // 
            // DataMng
            // 
            this.DataMng.Location = new System.Drawing.Point(68, 64);
            this.DataMng.Name = "DataMng";
            this.DataMng.Size = new System.Drawing.Size(187, 170);
            this.DataMng.TabIndex = 0;
            this.DataMng.Text = "Управление данными";
            this.DataMng.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 372);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DataRepr);
            this.Controls.Add(this.DataMng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DataRepr;
        private System.Windows.Forms.Button DataMng;
    }
}

