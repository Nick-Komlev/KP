namespace KR
{
    partial class Form2
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
            this.GGds = new System.Windows.Forms.DataGridView();
            this.WrhCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CtgCmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MdlCmbBox = new System.Windows.Forms.ComboBox();
            this.PrdCmbBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WthCmbBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrhIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GGds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GGds
            // 
            this.GGds.AllowUserToAddRows = false;
            this.GGds.AllowUserToDeleteRows = false;
            this.GGds.AllowUserToResizeColumns = false;
            this.GGds.AllowUserToResizeRows = false;
            this.GGds.AutoGenerateColumns = false;
            this.GGds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GGds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.worthDataGridViewTextBoxColumn,
            this.arDateDataGridViewTextBoxColumn,
            this.inStockDataGridViewCheckBoxColumn,
            this.distrDataGridViewTextBoxColumn,
            this.wrhIdDataGridViewTextBoxColumn});
            this.GGds.DataSource = this.goodsBindingSource;
            this.GGds.Location = new System.Drawing.Point(41, 97);
            this.GGds.Name = "GGds";
            this.GGds.Size = new System.Drawing.Size(946, 288);
            this.GGds.TabIndex = 0;
            // 
            // WrhCmbBox
            // 
            this.WrhCmbBox.FormattingEnabled = true;
            this.WrhCmbBox.Location = new System.Drawing.Point(41, 39);
            this.WrhCmbBox.Name = "WrhCmbBox";
            this.WrhCmbBox.Size = new System.Drawing.Size(121, 21);
            this.WrhCmbBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Склад";
            // 
            // CtgCmbBox
            // 
            this.CtgCmbBox.FormattingEnabled = true;
            this.CtgCmbBox.Location = new System.Drawing.Point(202, 39);
            this.CtgCmbBox.Name = "CtgCmbBox";
            this.CtgCmbBox.Size = new System.Drawing.Size(121, 21);
            this.CtgCmbBox.TabIndex = 1;
            this.CtgCmbBox.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Модель";
            // 
            // MdlCmbBox
            // 
            this.MdlCmbBox.FormattingEnabled = true;
            this.MdlCmbBox.Location = new System.Drawing.Point(365, 39);
            this.MdlCmbBox.Name = "MdlCmbBox";
            this.MdlCmbBox.Size = new System.Drawing.Size(121, 21);
            this.MdlCmbBox.TabIndex = 1;
            this.MdlCmbBox.Text = "*";
            // 
            // PrdCmbBox
            // 
            this.PrdCmbBox.FormattingEnabled = true;
            this.PrdCmbBox.Location = new System.Drawing.Point(531, 39);
            this.PrdCmbBox.Name = "PrdCmbBox";
            this.PrdCmbBox.Size = new System.Drawing.Size(121, 21);
            this.PrdCmbBox.TabIndex = 1;
            this.PrdCmbBox.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Производитель";
            // 
            // WthCmbBox
            // 
            this.WthCmbBox.FormattingEnabled = true;
            this.WthCmbBox.Location = new System.Drawing.Point(694, 39);
            this.WthCmbBox.Name = "WthCmbBox";
            this.WthCmbBox.Size = new System.Drawing.Size(121, 21);
            this.WthCmbBox.TabIndex = 1;
            this.WthCmbBox.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цена";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // categDataGridViewTextBoxColumn
            // 
            this.categDataGridViewTextBoxColumn.DataPropertyName = "Categ";
            this.categDataGridViewTextBoxColumn.HeaderText = "Categ";
            this.categDataGridViewTextBoxColumn.Name = "categDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // producerDataGridViewTextBoxColumn
            // 
            this.producerDataGridViewTextBoxColumn.DataPropertyName = "Producer";
            this.producerDataGridViewTextBoxColumn.HeaderText = "Producer";
            this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
            // 
            // worthDataGridViewTextBoxColumn
            // 
            this.worthDataGridViewTextBoxColumn.DataPropertyName = "Worth";
            this.worthDataGridViewTextBoxColumn.HeaderText = "Worth";
            this.worthDataGridViewTextBoxColumn.Name = "worthDataGridViewTextBoxColumn";
            // 
            // arDateDataGridViewTextBoxColumn
            // 
            this.arDateDataGridViewTextBoxColumn.DataPropertyName = "ArDate";
            this.arDateDataGridViewTextBoxColumn.HeaderText = "ArDate";
            this.arDateDataGridViewTextBoxColumn.Name = "arDateDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewCheckBoxColumn
            // 
            this.inStockDataGridViewCheckBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewCheckBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewCheckBoxColumn.Name = "inStockDataGridViewCheckBoxColumn";
            // 
            // distrDataGridViewTextBoxColumn
            // 
            this.distrDataGridViewTextBoxColumn.DataPropertyName = "Distr";
            this.distrDataGridViewTextBoxColumn.HeaderText = "Distr";
            this.distrDataGridViewTextBoxColumn.Name = "distrDataGridViewTextBoxColumn";
            // 
            // wrhIdDataGridViewTextBoxColumn
            // 
            this.wrhIdDataGridViewTextBoxColumn.DataPropertyName = "WrhId";
            this.wrhIdDataGridViewTextBoxColumn.HeaderText = "WrhId";
            this.wrhIdDataGridViewTextBoxColumn.Name = "wrhIdDataGridViewTextBoxColumn";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(KR.Goods);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(1017, 415);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WthCmbBox);
            this.Controls.Add(this.PrdCmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MdlCmbBox);
            this.Controls.Add(this.CtgCmbBox);
            this.Controls.Add(this.WrhCmbBox);
            this.Controls.Add(this.GGds);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GGds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GGds;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrhIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.ComboBox WrhCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CtgCmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MdlCmbBox;
        private System.Windows.Forms.ComboBox PrdCmbBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox WthCmbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchBtn;
    }
}