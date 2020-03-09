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
            this.Exit = new System.Windows.Forms.Button();
            this.DataRepr = new System.Windows.Forms.Button();
            this.DataMng = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrhIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.worthDataGridViewTextBoxColumn,
            this.arDateDataGridViewTextBoxColumn,
            this.inStockDataGridViewCheckBoxColumn,
            this.distrDataGridViewTextBoxColumn,
            this.wrhIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(931, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(KR.Goods);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DataRepr);
            this.Controls.Add(this.DataMng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DataRepr;
        private System.Windows.Forms.Button DataMng;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

