namespace KR
{
    partial class GdAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GdAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.CtgCmbBx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModCmbBx = new System.Windows.Forms.ComboBox();
            this.ProCmbBx = new System.Windows.Forms.ComboBox();
            this.DisCmbBx = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.WthTxt = new System.Windows.Forms.TextBox();
            this.DatePick = new System.Windows.Forms.DateTimePicker();
            this.StcCheck = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Склад: ";
            // 
            // CtgCmbBx
            // 
            this.CtgCmbBx.FormattingEnabled = true;
            this.CtgCmbBx.Location = new System.Drawing.Point(16, 61);
            this.CtgCmbBx.Name = "CtgCmbBx";
            this.CtgCmbBx.Size = new System.Drawing.Size(121, 21);
            this.CtgCmbBx.TabIndex = 1;
            this.CtgCmbBx.TextChanged += new System.EventHandler(this.CtgCmbBx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Модель";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Производитель";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Цена";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата поступления";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "В наличии";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Поставщик";
            this.label8.Visible = false;
            // 
            // ModCmbBx
            // 
            this.ModCmbBx.FormattingEnabled = true;
            this.ModCmbBx.Location = new System.Drawing.Point(17, 138);
            this.ModCmbBx.Name = "ModCmbBx";
            this.ModCmbBx.Size = new System.Drawing.Size(121, 21);
            this.ModCmbBx.TabIndex = 1;
            this.ModCmbBx.Visible = false;
            this.ModCmbBx.TextChanged += new System.EventHandler(this.ModCmbBx_TextChanged);
            // 
            // ProCmbBx
            // 
            this.ProCmbBx.FormattingEnabled = true;
            this.ProCmbBx.Location = new System.Drawing.Point(17, 98);
            this.ProCmbBx.Name = "ProCmbBx";
            this.ProCmbBx.Size = new System.Drawing.Size(121, 21);
            this.ProCmbBx.TabIndex = 1;
            this.ProCmbBx.Visible = false;
            this.ProCmbBx.TextChanged += new System.EventHandler(this.ProCmbBx_TextChanged);
            // 
            // DisCmbBx
            // 
            this.DisCmbBx.FormattingEnabled = true;
            this.DisCmbBx.Location = new System.Drawing.Point(16, 302);
            this.DisCmbBx.Name = "DisCmbBx";
            this.DisCmbBx.Size = new System.Drawing.Size(121, 21);
            this.DisCmbBx.TabIndex = 1;
            this.DisCmbBx.Visible = false;
            this.DisCmbBx.TextChanged += new System.EventHandler(this.DisCmbBx_TextChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelBtn.Image")));
            this.CancelBtn.Location = new System.Drawing.Point(146, 341);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(108, 108);
            this.CancelBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.CancelBtn, "Отменить и вернуться назад");
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.YesBtn.Enabled = false;
            this.YesBtn.Image = ((System.Drawing.Image)(resources.GetObject("YesBtn.Image")));
            this.YesBtn.Location = new System.Drawing.Point(12, 341);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(108, 108);
            this.YesBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.YesBtn, "Добавить товар");
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // WthTxt
            // 
            this.WthTxt.Location = new System.Drawing.Point(16, 181);
            this.WthTxt.Name = "WthTxt";
            this.WthTxt.Size = new System.Drawing.Size(121, 20);
            this.WthTxt.TabIndex = 6;
            this.WthTxt.Visible = false;
            this.WthTxt.TextChanged += new System.EventHandler(this.WthTxt_TextChanged);
            // 
            // DatePick
            // 
            this.DatePick.Location = new System.Drawing.Point(17, 215);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(120, 20);
            this.DatePick.TabIndex = 7;
            this.DatePick.Visible = false;
            // 
            // StcCheck
            // 
            this.StcCheck.AutoSize = true;
            this.StcCheck.Checked = true;
            this.StcCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StcCheck.Location = new System.Drawing.Point(122, 264);
            this.StcCheck.Name = "StcCheck";
            this.StcCheck.Size = new System.Drawing.Size(15, 14);
            this.StcCheck.TabIndex = 8;
            this.StcCheck.UseVisualStyleBackColor = true;
            this.StcCheck.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(299, 496);
            this.Controls.Add(this.StcCheck);
            this.Controls.Add(this.DatePick);
            this.Controls.Add(this.WthTxt);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DisCmbBx);
            this.Controls.Add(this.ProCmbBx);
            this.Controls.Add(this.ModCmbBx);
            this.Controls.Add(this.CtgCmbBx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CtgCmbBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ModCmbBx;
        private System.Windows.Forms.ComboBox ProCmbBx;
        private System.Windows.Forms.ComboBox DisCmbBx;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.TextBox WthTxt;
        private System.Windows.Forms.DateTimePicker DatePick;
        private System.Windows.Forms.CheckBox StcCheck;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}