namespace KR
{
    partial class CountF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountF));
            this.ListBox = new System.Windows.Forms.ListBox();
            this.InfCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddInfBtn = new System.Windows.Forms.Button();
            this.FormRepBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.BinBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.SystemColors.Window;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Items.AddRange(new object[] {
            "Склад*",
            "Категория*",
            "Модель*",
            "Производитель*",
            "Поставщик*",
            "Время поступления*",
            "Диапазон цен*"});
            this.ListBox.Location = new System.Drawing.Point(30, 22);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(250, 381);
            this.ListBox.TabIndex = 9;
            // 
            // InfCmbBox
            // 
            this.InfCmbBox.FormattingEnabled = true;
            this.InfCmbBox.Items.AddRange(new object[] {
            "Количество товара",
            "Средняя цена",
            "Сумма цен",
            "Товара в наличии",
            "Самый дорогостоящий товар",
            "Самый дешевый товар",
            "Список товаров"});
            this.InfCmbBox.Location = new System.Drawing.Point(349, 38);
            this.InfCmbBox.Name = "InfCmbBox";
            this.InfCmbBox.Size = new System.Drawing.Size(243, 21);
            this.InfCmbBox.TabIndex = 0;
            this.InfCmbBox.Text = "Количество товара";
            this.InfCmbBox.TextChanged += new System.EventHandler(this.InfCmbBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Операция";
            // 
            // InfLbl
            // 
            this.InfLbl.AutoSize = true;
            this.InfLbl.Location = new System.Drawing.Point(346, 71);
            this.InfLbl.Name = "InfLbl";
            this.InfLbl.Size = new System.Drawing.Size(46, 13);
            this.InfLbl.TabIndex = 3;
            this.InfLbl.Text = "Вывод: ";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(484, 295);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 108);
            this.ExitBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ExitBtn, "Вернуться назад");
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddInfBtn
            // 
            this.AddInfBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddInfBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddInfBtn.Image")));
            this.AddInfBtn.Location = new System.Drawing.Point(286, 22);
            this.AddInfBtn.Name = "AddInfBtn";
            this.AddInfBtn.Size = new System.Drawing.Size(40, 40);
            this.AddInfBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.AddInfBtn, "Добавить операцию в список пунктов, добавляемых в отчет");
            this.AddInfBtn.UseVisualStyleBackColor = false;
            this.AddInfBtn.Click += new System.EventHandler(this.AddInfBtn_Click);
            // 
            // FormRepBtn
            // 
            this.FormRepBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FormRepBtn.Image = ((System.Drawing.Image)(resources.GetObject("FormRepBtn.Image")));
            this.FormRepBtn.Location = new System.Drawing.Point(484, 147);
            this.FormRepBtn.Name = "FormRepBtn";
            this.FormRepBtn.Size = new System.Drawing.Size(108, 108);
            this.FormRepBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.FormRepBtn, "Сформировать текст отчета в файле блокнота");
            this.FormRepBtn.UseVisualStyleBackColor = false;
            this.FormRepBtn.Click += new System.EventHandler(this.FormRepBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClearBtn.Image")));
            this.ClearBtn.Location = new System.Drawing.Point(286, 71);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(40, 40);
            this.ClearBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ClearBtn, "Убрать выбранный пункт из списка");
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // BinBtn
            // 
            this.BinBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BinBtn.Image = ((System.Drawing.Image)(resources.GetObject("BinBtn.Image")));
            this.BinBtn.Location = new System.Drawing.Point(286, 117);
            this.BinBtn.Name = "BinBtn";
            this.BinBtn.Size = new System.Drawing.Size(40, 40);
            this.BinBtn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BinBtn, "Очистить все необязательные пункты");
            this.BinBtn.UseVisualStyleBackColor = false;
            this.BinBtn.Click += new System.EventHandler(this.BinBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(627, 426);
            this.Controls.Add(this.FormRepBtn);
            this.Controls.Add(this.BinBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddInfBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.InfLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfCmbBox);
            this.Controls.Add(this.ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подсчет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ComboBox InfCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddInfBtn;
        private System.Windows.Forms.Button FormRepBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button BinBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}