namespace KR
{
    partial class ChAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChAdd));
            this.AddGdBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ModBtn = new System.Windows.Forms.Button();
            this.CtgBtn = new System.Windows.Forms.Button();
            this.ProBtn = new System.Windows.Forms.Button();
            this.DisBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AddGdBtn
            // 
            this.AddGdBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddGdBtn.Location = new System.Drawing.Point(37, 52);
            this.AddGdBtn.Name = "AddGdBtn";
            this.AddGdBtn.Size = new System.Drawing.Size(127, 31);
            this.AddGdBtn.TabIndex = 0;
            this.AddGdBtn.Text = "Товар";
            this.AddGdBtn.UseVisualStyleBackColor = false;
            this.AddGdBtn.Click += new System.EventHandler(this.AddGdBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление";
            // 
            // ModBtn
            // 
            this.ModBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ModBtn.Location = new System.Drawing.Point(37, 89);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(127, 31);
            this.ModBtn.TabIndex = 1;
            this.ModBtn.Text = "Модель";
            this.ModBtn.UseVisualStyleBackColor = false;
            this.ModBtn.Click += new System.EventHandler(this.ModBtn_Click);
            // 
            // CtgBtn
            // 
            this.CtgBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CtgBtn.Location = new System.Drawing.Point(37, 126);
            this.CtgBtn.Name = "CtgBtn";
            this.CtgBtn.Size = new System.Drawing.Size(127, 31);
            this.CtgBtn.TabIndex = 2;
            this.CtgBtn.Text = "Категория";
            this.CtgBtn.UseVisualStyleBackColor = false;
            this.CtgBtn.Click += new System.EventHandler(this.CtgBtn_Click);
            // 
            // ProBtn
            // 
            this.ProBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ProBtn.Location = new System.Drawing.Point(37, 163);
            this.ProBtn.Name = "ProBtn";
            this.ProBtn.Size = new System.Drawing.Size(127, 31);
            this.ProBtn.TabIndex = 3;
            this.ProBtn.Text = "Производитель";
            this.ProBtn.UseVisualStyleBackColor = false;
            this.ProBtn.Click += new System.EventHandler(this.ProBtn_Click);
            // 
            // DisBtn
            // 
            this.DisBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DisBtn.Location = new System.Drawing.Point(37, 200);
            this.DisBtn.Name = "DisBtn";
            this.DisBtn.Size = new System.Drawing.Size(127, 31);
            this.DisBtn.TabIndex = 4;
            this.DisBtn.Text = "Поставщик";
            this.DisBtn.UseVisualStyleBackColor = false;
            this.DisBtn.Click += new System.EventHandler(this.DisBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(46, 256);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 108);
            this.ExitBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ExitBtn, "Вернуться назад");
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(204, 376);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisBtn);
            this.Controls.Add(this.ProBtn);
            this.Controls.Add(this.CtgBtn);
            this.Controls.Add(this.ModBtn);
            this.Controls.Add(this.AddGdBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddGdBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModBtn;
        private System.Windows.Forms.Button CtgBtn;
        private System.Windows.Forms.Button ProBtn;
        private System.Windows.Forms.Button DisBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}