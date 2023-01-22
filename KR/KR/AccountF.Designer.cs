namespace KR
{
    partial class AccountF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountF));
            this.GGds = new System.Windows.Forms.DataGridView();
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
            this.WrhCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CtgCmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MdlCmbBox = new System.Windows.Forms.ComboBox();
            this.PrdCmbBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WthFromCmbBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DisCmbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WthToCmbBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DatePickFrom = new System.Windows.Forms.DateTimePicker();
            this.DatePickTo = new System.Windows.Forms.DateTimePicker();
            this.CountBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MainStrip = new System.Windows.Forms.MenuStrip();
            this.BaseStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеСкладыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SortBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GGds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.MainStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GGds
            // 
            this.GGds.AllowUserToAddRows = false;
            this.GGds.AllowUserToDeleteRows = false;
            this.GGds.AllowUserToResizeColumns = false;
            this.GGds.AllowUserToResizeRows = false;
            this.GGds.AutoGenerateColumns = false;
            this.GGds.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GGds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GGds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categDataGridViewTextBoxColumn,
            this.modDataGridViewTextBoxColumn,
            this.prodDataGridViewTextBoxColumn,
            this.worthDataGridViewTextBoxColumn,
            this.arDateDataGridViewTextBoxColumn,
            this.inStockDataGridViewCheckBoxColumn,
            this.distrDataGridViewTextBoxColumn,
            this.wrhIdDataGridViewTextBoxColumn});
            this.GGds.DataSource = this.goodsBindingSource;
            this.GGds.Location = new System.Drawing.Point(38, 187);
            this.GGds.Name = "GGds";
            this.GGds.ReadOnly = true;
            this.GGds.Size = new System.Drawing.Size(1051, 338);
            this.GGds.TabIndex = 0;
            this.GGds.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GGds_ColumnHeaderMouseClick);
            this.GGds.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GGds_DataBindingComplete);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 85;
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
            this.modDataGridViewTextBoxColumn.Width = 155;
            // 
            // prodDataGridViewTextBoxColumn
            // 
            this.prodDataGridViewTextBoxColumn.DataPropertyName = "Prod";
            this.prodDataGridViewTextBoxColumn.HeaderText = "Prod";
            this.prodDataGridViewTextBoxColumn.Name = "prodDataGridViewTextBoxColumn";
            this.prodDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodDataGridViewTextBoxColumn.Width = 160;
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
            this.arDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // inStockDataGridViewCheckBoxColumn
            // 
            this.inStockDataGridViewCheckBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewCheckBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewCheckBoxColumn.Name = "inStockDataGridViewCheckBoxColumn";
            this.inStockDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inStockDataGridViewCheckBoxColumn.Width = 70;
            // 
            // distrDataGridViewTextBoxColumn
            // 
            this.distrDataGridViewTextBoxColumn.DataPropertyName = "Distr";
            this.distrDataGridViewTextBoxColumn.HeaderText = "Distr";
            this.distrDataGridViewTextBoxColumn.Name = "distrDataGridViewTextBoxColumn";
            this.distrDataGridViewTextBoxColumn.ReadOnly = true;
            this.distrDataGridViewTextBoxColumn.Width = 145;
            // 
            // wrhIdDataGridViewTextBoxColumn
            // 
            this.wrhIdDataGridViewTextBoxColumn.DataPropertyName = "WrhId";
            this.wrhIdDataGridViewTextBoxColumn.HeaderText = "WrhId";
            this.wrhIdDataGridViewTextBoxColumn.Name = "wrhIdDataGridViewTextBoxColumn";
            this.wrhIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.wrhIdDataGridViewTextBoxColumn.Width = 67;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(KR.Goods);
            // 
            // WrhCmbBox
            // 
            this.WrhCmbBox.FormattingEnabled = true;
            this.WrhCmbBox.Location = new System.Drawing.Point(38, 66);
            this.WrhCmbBox.Name = "WrhCmbBox";
            this.WrhCmbBox.Size = new System.Drawing.Size(121, 21);
            this.WrhCmbBox.TabIndex = 1;
            this.WrhCmbBox.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Склад";
            // 
            // CtgCmbBox
            // 
            this.CtgCmbBox.FormattingEnabled = true;
            this.CtgCmbBox.Location = new System.Drawing.Point(203, 66);
            this.CtgCmbBox.Name = "CtgCmbBox";
            this.CtgCmbBox.Size = new System.Drawing.Size(182, 21);
            this.CtgCmbBox.TabIndex = 1;
            this.CtgCmbBox.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Модель";
            // 
            // MdlCmbBox
            // 
            this.MdlCmbBox.FormattingEnabled = true;
            this.MdlCmbBox.Location = new System.Drawing.Point(203, 133);
            this.MdlCmbBox.Name = "MdlCmbBox";
            this.MdlCmbBox.Size = new System.Drawing.Size(182, 21);
            this.MdlCmbBox.TabIndex = 1;
            this.MdlCmbBox.Text = "*";
            // 
            // PrdCmbBox
            // 
            this.PrdCmbBox.FormattingEnabled = true;
            this.PrdCmbBox.Location = new System.Drawing.Point(427, 133);
            this.PrdCmbBox.Name = "PrdCmbBox";
            this.PrdCmbBox.Size = new System.Drawing.Size(231, 21);
            this.PrdCmbBox.TabIndex = 1;
            this.PrdCmbBox.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Производитель";
            // 
            // WthFromCmbBox
            // 
            this.WthFromCmbBox.FormattingEnabled = true;
            this.WthFromCmbBox.Location = new System.Drawing.Point(729, 66);
            this.WthFromCmbBox.Name = "WthFromCmbBox";
            this.WthFromCmbBox.Size = new System.Drawing.Size(108, 21);
            this.WthFromCmbBox.TabIndex = 1;
            this.WthFromCmbBox.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(726, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цена";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(1117, 66);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(108, 108);
            this.SearchBtn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.SearchBtn, "Поиск по фильтрам");
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DisCmbBox
            // 
            this.DisCmbBox.FormattingEnabled = true;
            this.DisCmbBox.Location = new System.Drawing.Point(427, 65);
            this.DisCmbBox.Name = "DisCmbBox";
            this.DisCmbBox.Size = new System.Drawing.Size(231, 21);
            this.DisCmbBox.TabIndex = 1;
            this.DisCmbBox.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Постащик";
            // 
            // WthToCmbBox
            // 
            this.WthToCmbBox.FormattingEnabled = true;
            this.WthToCmbBox.Location = new System.Drawing.Point(729, 100);
            this.WthToCmbBox.Name = "WthToCmbBox";
            this.WthToCmbBox.Size = new System.Drawing.Size(108, 21);
            this.WthToCmbBox.TabIndex = 1;
            this.WthToCmbBox.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "От";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "До";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Id";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Location = new System.Drawing.Point(38, 134);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(121, 20);
            this.IdTxtBox.TabIndex = 4;
            this.IdTxtBox.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(898, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Дата прибытия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(862, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "От";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(862, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "До";
            // 
            // DatePickFrom
            // 
            this.DatePickFrom.Location = new System.Drawing.Point(901, 66);
            this.DatePickFrom.Name = "DatePickFrom";
            this.DatePickFrom.Size = new System.Drawing.Size(188, 20);
            this.DatePickFrom.TabIndex = 5;
            this.DatePickFrom.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // DatePickTo
            // 
            this.DatePickTo.Location = new System.Drawing.Point(901, 100);
            this.DatePickTo.Name = "DatePickTo";
            this.DatePickTo.Size = new System.Drawing.Size(188, 20);
            this.DatePickTo.TabIndex = 5;
            // 
            // CountBtn
            // 
            this.CountBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CountBtn.Image = ((System.Drawing.Image)(resources.GetObject("CountBtn.Image")));
            this.CountBtn.Location = new System.Drawing.Point(1117, 187);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(108, 108);
            this.CountBtn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.CountBtn, "Подсчет. Переход к отображению статистических данных");
            this.CountBtn.UseVisualStyleBackColor = false;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(1117, 417);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 108);
            this.ExitBtn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.ExitBtn, "Вернуться назад");
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainStrip
            // 
            this.MainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseStrip,
            this.перейтиToolStripMenuItem,
            this.cправкаToolStripMenuItem});
            this.MainStrip.Location = new System.Drawing.Point(0, 0);
            this.MainStrip.Name = "MainStrip";
            this.MainStrip.Size = new System.Drawing.Size(1276, 24);
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
            this.управлениеСкладыToolStripMenuItem,
            this.главнаяToolStripMenuItem});
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.перейтиToolStripMenuItem.Text = "Перейти";
            // 
            // управлениеСкладыToolStripMenuItem
            // 
            this.управлениеСкладыToolStripMenuItem.Name = "управлениеСкладыToolStripMenuItem";
            this.управлениеСкладыToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.управлениеСкладыToolStripMenuItem.Text = "Управление: Склады";
            this.управлениеСкладыToolStripMenuItem.Click += new System.EventHandler(this.УправлениеСкладыToolStripMenuItem_Click);
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
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
            // SortBtn
            // 
            this.SortBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SortBtn.Image = ((System.Drawing.Image)(resources.GetObject("SortBtn.Image")));
            this.SortBtn.Location = new System.Drawing.Point(901, 133);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 41);
            this.SortBtn.TabIndex = 7;
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(982, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 39);
            this.label13.TabIndex = 8;
            this.label13.Text = "Задать параметры\r\nдвухуровневой\r\nсортировки";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1276, 549);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.MainStrip);
            this.Controls.Add(this.DatePickTo);
            this.Controls.Add(this.DatePickFrom);
            this.Controls.Add(this.IdTxtBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WthToCmbBox);
            this.Controls.Add(this.WthFromCmbBox);
            this.Controls.Add(this.DisCmbBox);
            this.Controls.Add(this.PrdCmbBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MdlCmbBox);
            this.Controls.Add(this.CtgCmbBox);
            this.Controls.Add(this.WrhCmbBox);
            this.Controls.Add(this.GGds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GGds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.MainStrip.ResumeLayout(false);
            this.MainStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GGds;
        private System.Windows.Forms.ComboBox WrhCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CtgCmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MdlCmbBox;
        private System.Windows.Forms.ComboBox PrdCmbBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox WthFromCmbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ComboBox DisCmbBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox WthToCmbBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DatePickFrom;
        private System.Windows.Forms.DateTimePicker DatePickTo;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.MenuStrip MainStrip;
        private System.Windows.Forms.ToolStripMenuItem BaseStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveStrip;
        private System.Windows.Forms.ToolStripMenuItem CancelStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.ToolStripMenuItem cправкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrhIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem перейтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеСкладыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
    }
}