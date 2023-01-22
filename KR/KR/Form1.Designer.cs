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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataRepr = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.DataMng = new System.Windows.Forms.Button();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.BaseStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataRepr
            // 
            this.DataRepr.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataRepr.Font = new System.Drawing.Font("Wide Latin", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataRepr.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DataRepr.Image = ((System.Drawing.Image)(resources.GetObject("DataRepr.Image")));
            this.DataRepr.Location = new System.Drawing.Point(349, 43);
            this.DataRepr.Name = "DataRepr";
            this.DataRepr.Size = new System.Drawing.Size(190, 190);
            this.DataRepr.TabIndex = 0;
            this.DataRepr.Text = "Учет";
            this.DataRepr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.DataRepr, "Переход к Учету товаров");
            this.DataRepr.UseVisualStyleBackColor = false;
            this.DataRepr.Click += new System.EventHandler(this.DataRepr_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(249, 257);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 108);
            this.ExitBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.ExitBtn, "Выход");
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // DataMng
            // 
            this.DataMng.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataMng.Font = new System.Drawing.Font("Wide Latin", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataMng.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DataMng.Image = ((System.Drawing.Image)(resources.GetObject("DataMng.Image")));
            this.DataMng.Location = new System.Drawing.Point(70, 43);
            this.DataMng.Name = "DataMng";
            this.DataMng.Size = new System.Drawing.Size(190, 190);
            this.DataMng.TabIndex = 0;
            this.DataMng.Text = "Управление данными";
            this.DataMng.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.DataMng, "Переход к Управлению данными");
            this.DataMng.UseVisualStyleBackColor = false;
            this.DataMng.Click += new System.EventHandler(this.DataMng_Click);
            // 
            // MainStrip
            // 
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseStrip,
            this.cправкаToolStripMenuItem});
            this.MainStrip.Location = new System.Drawing.Point(0, 0);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Size = new System.Drawing.Size(624, 24);
            this.MainStrip.TabIndex = 5;
            this.MainStrip.Text = "Стрип";
            // 
            // BaseStrip
            // 
            this.BaseStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStrip,
            this.CancelStrip,
            this.ExitStrip});
            this.BaseStrip.Name = "BaseStrip";
            this.BaseStrip.Size = new System.Drawing.Size(43, 20);
            this.BaseStrip.Text = "База";
            // 
            // SaveStrip
            // 
            this.SaveStrip.Name = "SaveStrip";
            this.SaveStrip.Size = new System.Drawing.Size(195, 22);
            this.SaveStrip.Text = "Сохранить изменения";
            this.SaveStrip.Click += new System.EventHandler(this.SaveStrip_Click);
            // 
            // CancelStrip
            // 
            this.CancelStrip.Name = "CancelStrip";
            this.CancelStrip.Size = new System.Drawing.Size(195, 22);
            this.CancelStrip.Text = "Отменить изменения";
            this.CancelStrip.Click += new System.EventHandler(this.CancelStrip_Click);
            // 
            // ExitStrip
            // 
            this.ExitStrip.Name = "ExitStrip";
            this.ExitStrip.Size = new System.Drawing.Size(195, 22);
            this.ExitStrip.Text = "Закрыть";
            this.ExitStrip.Click += new System.EventHandler(this.ExitStrip_Click);
            // 
            // cправкаToolStripMenuItem
            // 
            this.cправкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.cправкаToolStripMenuItem.Name = "cправкаToolStripMenuItem";
            this.cправкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cправкаToolStripMenuItem.Text = "Cправка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.оПрограммеToolStripMenuItem.Text = "Просмотреть справку";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.ОбАвтореToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(624, 388);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DataMng);
            this.Controls.Add(this.DataRepr);
            this.Controls.Add(this.MainStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АудиоСклад";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DataRepr;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button DataMng;
        private System.Windows.Forms.MenuStrip MainStrip;
        private System.Windows.Forms.ToolStripMenuItem BaseStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveStrip;
        private System.Windows.Forms.ToolStripMenuItem CancelStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.ToolStripMenuItem cправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

