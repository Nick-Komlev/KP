namespace KR
{
    partial class MngWrh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MngWrh));
            this.WrhCmbBox = new System.Windows.Forms.ComboBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.WrhSelBtn = new System.Windows.Forms.Button();
            this.WrhAddBtn = new System.Windows.Forms.Button();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.BaseStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // WrhCmbBox
            // 
            this.WrhCmbBox.FormattingEnabled = true;
            this.WrhCmbBox.Location = new System.Drawing.Point(12, 43);
            this.WrhCmbBox.Name = "WrhCmbBox";
            this.WrhCmbBox.Size = new System.Drawing.Size(136, 21);
            this.WrhCmbBox.TabIndex = 0;
            this.WrhCmbBox.TextChanged += new System.EventHandler(this.WrhCmbBox_TextChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(155, 82);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 108);
            this.ExitBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ExitBtn, "Вернуться назад");
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // WrhSelBtn
            // 
            this.WrhSelBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.WrhSelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrhSelBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.WrhSelBtn.Image = ((System.Drawing.Image)(resources.GetObject("WrhSelBtn.Image")));
            this.WrhSelBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WrhSelBtn.Location = new System.Drawing.Point(26, 82);
            this.WrhSelBtn.Name = "WrhSelBtn";
            this.WrhSelBtn.Size = new System.Drawing.Size(108, 108);
            this.WrhSelBtn.TabIndex = 1;
            this.WrhSelBtn.Text = "Перейти";
            this.WrhSelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.WrhSelBtn, "Начать работу с товарами в выбранном складе");
            this.WrhSelBtn.UseVisualStyleBackColor = false;
            this.WrhSelBtn.Click += new System.EventHandler(this.WrhSelBtn_Click);
            // 
            // WrhAddBtn
            // 
            this.WrhAddBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.WrhAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrhAddBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.WrhAddBtn.Location = new System.Drawing.Point(155, 36);
            this.WrhAddBtn.Name = "WrhAddBtn";
            this.WrhAddBtn.Size = new System.Drawing.Size(30, 34);
            this.WrhAddBtn.TabIndex = 4;
            this.WrhAddBtn.Text = "+";
            this.toolTip1.SetToolTip(this.WrhAddBtn, "Добавить новый склад");
            this.WrhAddBtn.UseVisualStyleBackColor = false;
            this.WrhAddBtn.Click += new System.EventHandler(this.WrhAddBtn_Click);
            // 
            // MainStrip
            // 
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseStrip,
            this.перейтиToolStripMenuItem,
            this.cправкаToolStripMenuItem});
            this.MainStrip.Location = new System.Drawing.Point(0, 0);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Size = new System.Drawing.Size(291, 24);
            this.MainStrip.TabIndex = 6;
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
            // перейтиToolStripMenuItem
            // 
            this.перейтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учетToolStripMenuItem,
            this.главнаяToolStripMenuItem});
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.перейтиToolStripMenuItem.Text = "Перейти";
            // 
            // учетToolStripMenuItem
            // 
            this.учетToolStripMenuItem.Name = "учетToolStripMenuItem";
            this.учетToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.учетToolStripMenuItem.Text = "Учет";
            this.учетToolStripMenuItem.Click += new System.EventHandler(this.УчетToolStripMenuItem_Click);
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.главнаяToolStripMenuItem.Text = "Главная";
            this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.ГлавнаяToolStripMenuItem_Click);
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
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.оПрограммеToolStripMenuItem.Text = "Показать справку";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.ОбАвтореToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(291, 223);
            this.Controls.Add(this.MainStrip);
            this.Controls.Add(this.WrhAddBtn);
            this.Controls.Add(this.WrhSelBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.WrhCmbBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление данными: Склады";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox WrhCmbBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button WrhSelBtn;
        private System.Windows.Forms.Button WrhAddBtn;
        private System.Windows.Forms.MenuStrip MainStrip;
        private System.Windows.Forms.ToolStripMenuItem BaseStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveStrip;
        private System.Windows.Forms.ToolStripMenuItem CancelStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.ToolStripMenuItem cправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem перейтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
    }
}