namespace KR
{
    partial class MngGds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MngGds));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrhIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddGoodBtn = new System.Windows.Forms.Button();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.BaseStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeGoodBtn = new System.Windows.Forms.Button();
            this.DeleteGoodBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModCmbBx = new System.Windows.Forms.ComboBox();
            this.IdCmbBx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.distrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrhIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.SortBtn = new System.Windows.Forms.Button();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.MainStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categDataGridViewTextBoxColumn,
            this.modDataGridViewTextBoxColumn,
            this.prodDataGridViewTextBoxColumn,
            this.worthDataGridViewTextBoxColumn,
            this.arDateDataGridViewTextBoxColumn,
            this.inStockDataGridViewCheckBoxColumn,
            this.distrDataGridViewTextBoxColumn,
            this.wrhIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(946, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categDataGridViewTextBoxColumn
            // 
            this.categDataGridViewTextBoxColumn.DataPropertyName = "Categ";
            this.categDataGridViewTextBoxColumn.HeaderText = "Categ";
            this.categDataGridViewTextBoxColumn.Name = "categDataGridViewTextBoxColumn";
            this.categDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modDataGridViewTextBoxColumn
            // 
            this.modDataGridViewTextBoxColumn.DataPropertyName = "Mod";
            this.modDataGridViewTextBoxColumn.HeaderText = "Mod";
            this.modDataGridViewTextBoxColumn.Name = "modDataGridViewTextBoxColumn";
            this.modDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodDataGridViewTextBoxColumn
            // 
            this.prodDataGridViewTextBoxColumn.DataPropertyName = "Prod";
            this.prodDataGridViewTextBoxColumn.HeaderText = "Prod";
            this.prodDataGridViewTextBoxColumn.Name = "prodDataGridViewTextBoxColumn";
            this.prodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // worthDataGridViewTextBoxColumn
            // 
            this.worthDataGridViewTextBoxColumn.DataPropertyName = "Worth";
            this.worthDataGridViewTextBoxColumn.HeaderText = "Worth";
            this.worthDataGridViewTextBoxColumn.Name = "worthDataGridViewTextBoxColumn";
            this.worthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arDateDataGridViewTextBoxColumn
            // 
            this.arDateDataGridViewTextBoxColumn.DataPropertyName = "ArDate";
            this.arDateDataGridViewTextBoxColumn.HeaderText = "ArDate";
            this.arDateDataGridViewTextBoxColumn.Name = "arDateDataGridViewTextBoxColumn";
            this.arDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inStockDataGridViewCheckBoxColumn
            // 
            this.inStockDataGridViewCheckBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewCheckBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewCheckBoxColumn.Name = "inStockDataGridViewCheckBoxColumn";
            this.inStockDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // distrDataGridViewTextBoxColumn
            // 
            this.distrDataGridViewTextBoxColumn.DataPropertyName = "Distr";
            this.distrDataGridViewTextBoxColumn.HeaderText = "Distr";
            this.distrDataGridViewTextBoxColumn.Name = "distrDataGridViewTextBoxColumn";
            this.distrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wrhIdDataGridViewTextBoxColumn
            // 
            this.wrhIdDataGridViewTextBoxColumn.DataPropertyName = "WrhId";
            this.wrhIdDataGridViewTextBoxColumn.HeaderText = "WrhId";
            this.wrhIdDataGridViewTextBoxColumn.Name = "wrhIdDataGridViewTextBoxColumn";
            this.wrhIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(KR.Goods);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(850, 31);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 108);
            this.ExitBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.ExitBtn, "Вернуться назад");
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddGoodBtn
            // 
            this.AddGoodBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddGoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGoodBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AddGoodBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddGoodBtn.Image")));
            this.AddGoodBtn.Location = new System.Drawing.Point(12, 31);
            this.AddGoodBtn.Name = "AddGoodBtn";
            this.AddGoodBtn.Size = new System.Drawing.Size(108, 108);
            this.AddGoodBtn.TabIndex = 4;
            this.AddGoodBtn.Text = "Добавить";
            this.AddGoodBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.AddGoodBtn, "Перейти к добавлению нового объекта");
            this.AddGoodBtn.UseVisualStyleBackColor = false;
            this.AddGoodBtn.Click += new System.EventHandler(this.AddGoodBtn_Click);
            // 
            // MainStrip
            // 
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseStrip,
            this.перейтиToolStripMenuItem,
            this.cправкаToolStripMenuItem});
            this.MainStrip.Location = new System.Drawing.Point(0, 0);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Size = new System.Drawing.Size(986, 24);
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
            // ChangeGoodBtn
            // 
            this.ChangeGoodBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ChangeGoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeGoodBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ChangeGoodBtn.Image = ((System.Drawing.Image)(resources.GetObject("ChangeGoodBtn.Image")));
            this.ChangeGoodBtn.Location = new System.Drawing.Point(143, 31);
            this.ChangeGoodBtn.Name = "ChangeGoodBtn";
            this.ChangeGoodBtn.Size = new System.Drawing.Size(108, 108);
            this.ChangeGoodBtn.TabIndex = 4;
            this.ChangeGoodBtn.Text = "Изменить";
            this.ChangeGoodBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.ChangeGoodBtn, "Перейти к изменению выбранного товара");
            this.ChangeGoodBtn.UseVisualStyleBackColor = false;
            this.ChangeGoodBtn.Click += new System.EventHandler(this.ChangeGoodBtn_Click);
            // 
            // DeleteGoodBtn
            // 
            this.DeleteGoodBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DeleteGoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteGoodBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DeleteGoodBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteGoodBtn.Image")));
            this.DeleteGoodBtn.Location = new System.Drawing.Point(275, 31);
            this.DeleteGoodBtn.Name = "DeleteGoodBtn";
            this.DeleteGoodBtn.Size = new System.Drawing.Size(108, 108);
            this.DeleteGoodBtn.TabIndex = 4;
            this.DeleteGoodBtn.Text = "Удалить";
            this.DeleteGoodBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.DeleteGoodBtn, "Удалить выбранный товар");
            this.DeleteGoodBtn.UseVisualStyleBackColor = false;
            this.DeleteGoodBtn.Click += new System.EventHandler(this.DeleteGoodBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(202, 8);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(92, 92);
            this.SearchBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.SearchBtn, "Поиск по фильтрам");
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.ModCmbBx);
            this.panel1.Controls.Add(this.IdCmbBx);
            this.panel1.Location = new System.Drawing.Point(517, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 108);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Идентификационный номер";
            // 
            // ModCmbBx
            // 
            this.ModCmbBx.FormattingEnabled = true;
            this.ModCmbBx.Location = new System.Drawing.Point(18, 72);
            this.ModCmbBx.Name = "ModCmbBx";
            this.ModCmbBx.Size = new System.Drawing.Size(161, 21);
            this.ModCmbBx.TabIndex = 1;
            this.ModCmbBx.Text = "*";
            // 
            // IdCmbBx
            // 
            this.IdCmbBx.Location = new System.Drawing.Point(18, 33);
            this.IdCmbBx.Name = "IdCmbBx";
            this.IdCmbBx.Size = new System.Drawing.Size(161, 20);
            this.IdCmbBx.TabIndex = 0;
            this.IdCmbBx.Text = "*";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(12, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 197);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Результаты поиска:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.categDataGridViewTextBoxColumn1,
            this.modDataGridViewTextBoxColumn1,
            this.prodDataGridViewTextBoxColumn1,
            this.worthDataGridViewTextBoxColumn1,
            this.arDateDataGridViewTextBoxColumn1,
            this.inStockDataGridViewCheckBoxColumn1,
            this.distrDataGridViewTextBoxColumn1,
            this.wrhIdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.goodsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(0, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(946, 151);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView2_ColumnHeaderMouseClick);
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView2_DataBindingComplete);
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_RowEnter);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categDataGridViewTextBoxColumn1
            // 
            this.categDataGridViewTextBoxColumn1.DataPropertyName = "Categ";
            this.categDataGridViewTextBoxColumn1.HeaderText = "Categ";
            this.categDataGridViewTextBoxColumn1.Name = "categDataGridViewTextBoxColumn1";
            this.categDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modDataGridViewTextBoxColumn1
            // 
            this.modDataGridViewTextBoxColumn1.DataPropertyName = "Mod";
            this.modDataGridViewTextBoxColumn1.HeaderText = "Mod";
            this.modDataGridViewTextBoxColumn1.Name = "modDataGridViewTextBoxColumn1";
            this.modDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prodDataGridViewTextBoxColumn1
            // 
            this.prodDataGridViewTextBoxColumn1.DataPropertyName = "Prod";
            this.prodDataGridViewTextBoxColumn1.HeaderText = "Prod";
            this.prodDataGridViewTextBoxColumn1.Name = "prodDataGridViewTextBoxColumn1";
            this.prodDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // worthDataGridViewTextBoxColumn1
            // 
            this.worthDataGridViewTextBoxColumn1.DataPropertyName = "Worth";
            this.worthDataGridViewTextBoxColumn1.HeaderText = "Worth";
            this.worthDataGridViewTextBoxColumn1.Name = "worthDataGridViewTextBoxColumn1";
            this.worthDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // arDateDataGridViewTextBoxColumn1
            // 
            this.arDateDataGridViewTextBoxColumn1.DataPropertyName = "ArDate";
            this.arDateDataGridViewTextBoxColumn1.HeaderText = "ArDate";
            this.arDateDataGridViewTextBoxColumn1.Name = "arDateDataGridViewTextBoxColumn1";
            this.arDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inStockDataGridViewCheckBoxColumn1
            // 
            this.inStockDataGridViewCheckBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewCheckBoxColumn1.HeaderText = "InStock";
            this.inStockDataGridViewCheckBoxColumn1.Name = "inStockDataGridViewCheckBoxColumn1";
            this.inStockDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // distrDataGridViewTextBoxColumn1
            // 
            this.distrDataGridViewTextBoxColumn1.DataPropertyName = "Distr";
            this.distrDataGridViewTextBoxColumn1.HeaderText = "Distr";
            this.distrDataGridViewTextBoxColumn1.Name = "distrDataGridViewTextBoxColumn1";
            this.distrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // wrhIdDataGridViewTextBoxColumn1
            // 
            this.wrhIdDataGridViewTextBoxColumn1.DataPropertyName = "WrhId";
            this.wrhIdDataGridViewTextBoxColumn1.HeaderText = "WrhId";
            this.wrhIdDataGridViewTextBoxColumn1.Name = "wrhIdDataGridViewTextBoxColumn1";
            this.wrhIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // goodsBindingSource1
            // 
            this.goodsBindingSource1.DataSource = typeof(KR.Goods);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 39);
            this.label13.TabIndex = 10;
            this.label13.Text = "Задать параметры\r\nдвухуровневой\r\nсортировки";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SortBtn
            // 
            this.SortBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SortBtn.Image = ((System.Drawing.Image)(resources.GetObject("SortBtn.Image")));
            this.SortBtn.Location = new System.Drawing.Point(412, 83);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 41);
            this.SortBtn.TabIndex = 9;
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // перейтиToolStripMenuItem
            // 
            this.перейтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учетToolStripMenuItem,
            this.управлениеСкладToolStripMenuItem,
            this.главнаяToolStripMenuItem});
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.перейтиToolStripMenuItem.Text = "Перейти";
            // 
            // учетToolStripMenuItem
            // 
            this.учетToolStripMenuItem.Name = "учетToolStripMenuItem";
            this.учетToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.учетToolStripMenuItem.Text = "Учет";
            this.учетToolStripMenuItem.Click += new System.EventHandler(this.УчетToolStripMenuItem_Click);
            // 
            // управлениеСкладToolStripMenuItem
            // 
            this.управлениеСкладToolStripMenuItem.Name = "управлениеСкладToolStripMenuItem";
            this.управлениеСкладToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.управлениеСкладToolStripMenuItem.Text = "Управление: Склады";
            this.управлениеСкладToolStripMenuItem.Click += new System.EventHandler(this.УправлениеСкладToolStripMenuItem_Click);
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.главнаяToolStripMenuItem.Text = "Главная";
            this.главнаяToolStripMenuItem.Click += new System.EventHandler(this.ГлавнаяToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(986, 666);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainStrip);
            this.Controls.Add(this.DeleteGoodBtn);
            this.Controls.Add(this.ChangeGoodBtn);
            this.Controls.Add(this.AddGoodBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление данными: Товары";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrhIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddGoodBtn;
        private System.Windows.Forms.MenuStrip MainStrip;
        private System.Windows.Forms.ToolStripMenuItem BaseStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveStrip;
        private System.Windows.Forms.ToolStripMenuItem CancelStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.ToolStripMenuItem cправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.Button ChangeGoodBtn;
        private System.Windows.Forms.Button DeleteGoodBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource goodsBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IdCmbBx;
        private System.Windows.Forms.ComboBox ModCmbBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn worthDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStockDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn distrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrhIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.ToolStripMenuItem перейтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеСкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
    }
}