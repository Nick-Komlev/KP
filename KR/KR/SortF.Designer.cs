namespace KR
{
    partial class SortF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortF));
            this.ParLevel1 = new System.Windows.Forms.ComboBox();
            this.ParLevel2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParLevel1
            // 
            this.ParLevel1.FormattingEnabled = true;
            this.ParLevel1.Location = new System.Drawing.Point(12, 38);
            this.ParLevel1.Name = "ParLevel1";
            this.ParLevel1.Size = new System.Drawing.Size(121, 21);
            this.ParLevel1.TabIndex = 0;
            this.ParLevel1.TextChanged += new System.EventHandler(this.ParLevel1_TextChanged);
            // 
            // ParLevel2
            // 
            this.ParLevel2.FormattingEnabled = true;
            this.ParLevel2.Location = new System.Drawing.Point(12, 96);
            this.ParLevel2.Name = "ParLevel2";
            this.ParLevel2.Size = new System.Drawing.Size(121, 21);
            this.ParLevel2.TabIndex = 0;
            this.ParLevel2.TextChanged += new System.EventHandler(this.ParLevel2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметр первого уровня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Параметр второго уровня";
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.YesBtn.Image = ((System.Drawing.Image)(resources.GetObject("YesBtn.Image")));
            this.YesBtn.Location = new System.Drawing.Point(162, 22);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(108, 108);
            this.YesBtn.TabIndex = 6;
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(282, 150);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParLevel2);
            this.Controls.Add(this.ParLevel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры сортировки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form11_FormClosing);
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ParLevel1;
        private System.Windows.Forms.ComboBox ParLevel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YesBtn;
    }
}