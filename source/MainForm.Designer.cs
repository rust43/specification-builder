namespace SpecificationBuilder
{
    partial class MainForm
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
            this.pnlBot = new System.Windows.Forms.Panel();
            this.pnlJournal = new System.Windows.Forms.Panel();
            this.journal = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnBuildSpecification = new System.Windows.Forms.Button();
            this.btnCollectDrawingSet = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.pnlTbl = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCross = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpCross = new System.Windows.Forms.GroupBox();
            this.chkBtnAddCross = new System.Windows.Forms.CheckBox();
            this.pnlCross1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCrossCount = new System.Windows.Forms.Label();
            this.lblCrossVar = new System.Windows.Forms.Label();
            this.txtCrossCount = new System.Windows.Forms.TextBox();
            this.cmbCrossVar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCoupling = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grpCoup = new System.Windows.Forms.GroupBox();
            this.chkBtnAddCoup = new System.Windows.Forms.CheckBox();
            this.pnlCoup1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lblCoupCount = new System.Windows.Forms.Label();
            this.lblCoupVar = new System.Windows.Forms.Label();
            this.txtCoupCount = new System.Windows.Forms.TextBox();
            this.cmbCoupVar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSupFastening = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpSup = new System.Windows.Forms.GroupBox();
            this.chkBtnAddSup = new System.Windows.Forms.CheckBox();
            this.pnlSup1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSupCount = new System.Windows.Forms.Label();
            this.lblSupVar = new System.Windows.Forms.Label();
            this.txtSupCount = new System.Windows.Forms.TextBox();
            this.cmbSupVar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFastening = new System.Windows.Forms.Panel();
            this.tblFastening = new System.Windows.Forms.Panel();
            this.grpFastening = new System.Windows.Forms.GroupBox();
            this.chkBtnAddFastening = new System.Windows.Forms.CheckBox();
            this.pnlFastening1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblFastCount = new System.Windows.Forms.Label();
            this.lblFastVar = new System.Windows.Forms.Label();
            this.txtFastCount = new System.Windows.Forms.TextBox();
            this.cmbFastVar = new System.Windows.Forms.ComboBox();
            this.lblFastening = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlBot.SuspendLayout();
            this.pnlJournal.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.pnlTbl.SuspendLayout();
            this.pnlCross.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpCross.SuspendLayout();
            this.pnlCross1.SuspendLayout();
            this.pnlCoupling.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpCoup.SuspendLayout();
            this.pnlCoup1.SuspendLayout();
            this.pnlSupFastening.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpSup.SuspendLayout();
            this.pnlSup1.SuspendLayout();
            this.pnlFastening.SuspendLayout();
            this.tblFastening.SuspendLayout();
            this.grpFastening.SuspendLayout();
            this.pnlFastening1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBot
            // 
            this.pnlBot.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBot.Controls.Add(this.pnlJournal);
            this.pnlBot.Controls.Add(this.pnlButtons);
            this.pnlBot.Controls.Add(this.pnlProgress);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(5, 309);
            this.pnlBot.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.pnlBot.Size = new System.Drawing.Size(804, 247);
            this.pnlBot.TabIndex = 1;
            // 
            // pnlJournal
            // 
            this.pnlJournal.Controls.Add(this.journal);
            this.pnlJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJournal.Location = new System.Drawing.Point(5, 65);
            this.pnlJournal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlJournal.Name = "pnlJournal";
            this.pnlJournal.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnlJournal.Size = new System.Drawing.Size(794, 182);
            this.pnlJournal.TabIndex = 2;
            // 
            // journal
            // 
            this.journal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.journal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.journal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journal.FullRowSelect = true;
            this.journal.GridLines = true;
            this.journal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.journal.HideSelection = false;
            this.journal.Location = new System.Drawing.Point(5, 0);
            this.journal.Margin = new System.Windows.Forms.Padding(0);
            this.journal.MultiSelect = false;
            this.journal.Name = "journal";
            this.journal.ShowItemToolTips = true;
            this.journal.Size = new System.Drawing.Size(784, 177);
            this.journal.TabIndex = 0;
            this.journal.UseCompatibleStateImageBehavior = false;
            this.journal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 763;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnBuildSpecification);
            this.pnlButtons.Controls.Add(this.btnCollectDrawingSet);
            this.pnlButtons.Controls.Add(this.btnLoadFile);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(5, 25);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Size = new System.Drawing.Size(794, 40);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnBuildSpecification
            // 
            this.btnBuildSpecification.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuildSpecification.Location = new System.Drawing.Point(405, 5);
            this.btnBuildSpecification.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuildSpecification.Name = "btnBuildSpecification";
            this.btnBuildSpecification.Size = new System.Drawing.Size(200, 30);
            this.btnBuildSpecification.TabIndex = 2;
            this.btnBuildSpecification.Text = "Создать спецификацию";
            this.btnBuildSpecification.UseVisualStyleBackColor = true;
            this.btnBuildSpecification.Click += new System.EventHandler(this.btnBuildSpecification_Click);
            // 
            // btnCollectDrawingSet
            // 
            this.btnCollectDrawingSet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCollectDrawingSet.Location = new System.Drawing.Point(205, 5);
            this.btnCollectDrawingSet.Margin = new System.Windows.Forms.Padding(0);
            this.btnCollectDrawingSet.Name = "btnCollectDrawingSet";
            this.btnCollectDrawingSet.Size = new System.Drawing.Size(200, 30);
            this.btnCollectDrawingSet.TabIndex = 1;
            this.btnCollectDrawingSet.Text = "Собрать комплект чертежей";
            this.btnCollectDrawingSet.UseVisualStyleBackColor = true;
            this.btnCollectDrawingSet.Click += new System.EventHandler(this.btnCollectDrawingSet_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoadFile.Location = new System.Drawing.Point(5, 5);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(200, 30);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Загрузить параметры";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.White;
            this.pnlProgress.Controls.Add(this.pnlProgressBar);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgress.Location = new System.Drawing.Point(5, 10);
            this.pnlProgress.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(794, 15);
            this.pnlProgress.TabIndex = 0;
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.BackColor = System.Drawing.Color.Lime;
            this.pnlProgressBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProgressBar.Location = new System.Drawing.Point(0, 0);
            this.pnlProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(200, 15);
            this.pnlProgressBar.TabIndex = 0;
            // 
            // pnlTbl
            // 
            this.pnlTbl.ColumnCount = 4;
            this.pnlTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlTbl.Controls.Add(this.pnlCross, 3, 0);
            this.pnlTbl.Controls.Add(this.pnlCoupling, 2, 0);
            this.pnlTbl.Controls.Add(this.pnlSupFastening, 1, 0);
            this.pnlTbl.Controls.Add(this.pnlFastening, 0, 0);
            this.pnlTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTbl.Location = new System.Drawing.Point(5, 5);
            this.pnlTbl.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTbl.Name = "pnlTbl";
            this.pnlTbl.RowCount = 1;
            this.pnlTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTbl.Size = new System.Drawing.Size(804, 301);
            this.pnlTbl.TabIndex = 2;
            // 
            // pnlCross
            // 
            this.pnlCross.AutoScroll = true;
            this.pnlCross.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCross.Controls.Add(this.panel3);
            this.pnlCross.Controls.Add(this.label3);
            this.pnlCross.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCross.Location = new System.Drawing.Point(603, 0);
            this.pnlCross.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCross.Name = "pnlCross";
            this.pnlCross.Size = new System.Drawing.Size(201, 301);
            this.pnlCross.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.grpCross);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(201, 256);
            this.panel3.TabIndex = 2;
            // 
            // grpCross
            // 
            this.grpCross.AutoSize = true;
            this.grpCross.Controls.Add(this.chkBtnAddCross);
            this.grpCross.Controls.Add(this.pnlCross1);
            this.grpCross.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCross.Location = new System.Drawing.Point(5, 5);
            this.grpCross.Margin = new System.Windows.Forms.Padding(0);
            this.grpCross.Name = "grpCross";
            this.grpCross.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grpCross.Size = new System.Drawing.Size(191, 111);
            this.grpCross.TabIndex = 0;
            this.grpCross.TabStop = false;
            // 
            // chkBtnAddCross
            // 
            this.chkBtnAddCross.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBtnAddCross.Location = new System.Drawing.Point(3, 78);
            this.chkBtnAddCross.Margin = new System.Windows.Forms.Padding(0);
            this.chkBtnAddCross.Name = "chkBtnAddCross";
            this.chkBtnAddCross.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkBtnAddCross.Size = new System.Drawing.Size(185, 30);
            this.chkBtnAddCross.TabIndex = 3;
            this.chkBtnAddCross.Text = "Добавить пункт";
            this.chkBtnAddCross.UseVisualStyleBackColor = true;
            this.chkBtnAddCross.CheckedChanged += new System.EventHandler(this.chkBtnAddCross_CheckedChanged);
            // 
            // pnlCross1
            // 
            this.pnlCross1.Controls.Add(this.button5);
            this.pnlCross1.Controls.Add(this.lblCrossCount);
            this.pnlCross1.Controls.Add(this.lblCrossVar);
            this.pnlCross1.Controls.Add(this.txtCrossCount);
            this.pnlCross1.Controls.Add(this.cmbCrossVar);
            this.pnlCross1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCross1.Location = new System.Drawing.Point(3, 18);
            this.pnlCross1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCross1.Name = "pnlCross1";
            this.pnlCross1.Size = new System.Drawing.Size(185, 60);
            this.pnlCross1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(162, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 20);
            this.button5.TabIndex = 6;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lblCrossCount
            // 
            this.lblCrossCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCrossCount.AutoSize = true;
            this.lblCrossCount.Location = new System.Drawing.Point(127, 3);
            this.lblCrossCount.Name = "lblCrossCount";
            this.lblCrossCount.Size = new System.Drawing.Size(27, 17);
            this.lblCrossCount.TabIndex = 3;
            this.lblCrossCount.Text = "шт.";
            // 
            // lblCrossVar
            // 
            this.lblCrossVar.AutoSize = true;
            this.lblCrossVar.Location = new System.Drawing.Point(3, 3);
            this.lblCrossVar.Name = "lblCrossVar";
            this.lblCrossVar.Size = new System.Drawing.Size(56, 17);
            this.lblCrossVar.TabIndex = 2;
            this.lblCrossVar.Text = "Вариант";
            // 
            // txtCrossCount
            // 
            this.txtCrossCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrossCount.Location = new System.Drawing.Point(130, 23);
            this.txtCrossCount.Name = "txtCrossCount";
            this.txtCrossCount.Size = new System.Drawing.Size(52, 25);
            this.txtCrossCount.TabIndex = 1;
            this.txtCrossCount.Text = "0";
            // 
            // cmbCrossVar
            // 
            this.cmbCrossVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCrossVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrossVar.FormattingEnabled = true;
            this.cmbCrossVar.Location = new System.Drawing.Point(3, 23);
            this.cmbCrossVar.Name = "cmbCrossVar";
            this.cmbCrossVar.Size = new System.Drawing.Size(121, 25);
            this.cmbCrossVar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Кросс";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCoupling
            // 
            this.pnlCoupling.AutoScroll = true;
            this.pnlCoupling.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCoupling.Controls.Add(this.panel4);
            this.pnlCoupling.Controls.Add(this.label4);
            this.pnlCoupling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCoupling.Location = new System.Drawing.Point(402, 0);
            this.pnlCoupling.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCoupling.Name = "pnlCoupling";
            this.pnlCoupling.Size = new System.Drawing.Size(201, 301);
            this.pnlCoupling.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.grpCoup);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(201, 256);
            this.panel4.TabIndex = 2;
            // 
            // grpCoup
            // 
            this.grpCoup.AutoSize = true;
            this.grpCoup.Controls.Add(this.chkBtnAddCoup);
            this.grpCoup.Controls.Add(this.pnlCoup1);
            this.grpCoup.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCoup.Location = new System.Drawing.Point(5, 5);
            this.grpCoup.Margin = new System.Windows.Forms.Padding(0);
            this.grpCoup.Name = "grpCoup";
            this.grpCoup.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grpCoup.Size = new System.Drawing.Size(191, 111);
            this.grpCoup.TabIndex = 0;
            this.grpCoup.TabStop = false;
            // 
            // chkBtnAddCoup
            // 
            this.chkBtnAddCoup.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBtnAddCoup.Location = new System.Drawing.Point(3, 78);
            this.chkBtnAddCoup.Margin = new System.Windows.Forms.Padding(0);
            this.chkBtnAddCoup.Name = "chkBtnAddCoup";
            this.chkBtnAddCoup.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkBtnAddCoup.Size = new System.Drawing.Size(185, 30);
            this.chkBtnAddCoup.TabIndex = 2;
            this.chkBtnAddCoup.Text = "Добавить пункт";
            this.chkBtnAddCoup.UseVisualStyleBackColor = true;
            this.chkBtnAddCoup.CheckedChanged += new System.EventHandler(this.chkBtnAddCoup_CheckedChanged);
            // 
            // pnlCoup1
            // 
            this.pnlCoup1.Controls.Add(this.button4);
            this.pnlCoup1.Controls.Add(this.lblCoupCount);
            this.pnlCoup1.Controls.Add(this.lblCoupVar);
            this.pnlCoup1.Controls.Add(this.txtCoupCount);
            this.pnlCoup1.Controls.Add(this.cmbCoupVar);
            this.pnlCoup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCoup1.Location = new System.Drawing.Point(3, 18);
            this.pnlCoup1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCoup1.Name = "pnlCoup1";
            this.pnlCoup1.Size = new System.Drawing.Size(185, 60);
            this.pnlCoup1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(162, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 6;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblCoupCount
            // 
            this.lblCoupCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoupCount.AutoSize = true;
            this.lblCoupCount.Location = new System.Drawing.Point(127, 3);
            this.lblCoupCount.Name = "lblCoupCount";
            this.lblCoupCount.Size = new System.Drawing.Size(27, 17);
            this.lblCoupCount.TabIndex = 3;
            this.lblCoupCount.Text = "шт.";
            // 
            // lblCoupVar
            // 
            this.lblCoupVar.AutoSize = true;
            this.lblCoupVar.Location = new System.Drawing.Point(3, 3);
            this.lblCoupVar.Name = "lblCoupVar";
            this.lblCoupVar.Size = new System.Drawing.Size(56, 17);
            this.lblCoupVar.TabIndex = 2;
            this.lblCoupVar.Text = "Вариант";
            // 
            // txtCoupCount
            // 
            this.txtCoupCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoupCount.Location = new System.Drawing.Point(130, 23);
            this.txtCoupCount.Name = "txtCoupCount";
            this.txtCoupCount.Size = new System.Drawing.Size(52, 25);
            this.txtCoupCount.TabIndex = 1;
            this.txtCoupCount.Text = "0";
            // 
            // cmbCoupVar
            // 
            this.cmbCoupVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCoupVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoupVar.FormattingEnabled = true;
            this.cmbCoupVar.Location = new System.Drawing.Point(3, 23);
            this.cmbCoupVar.Name = "cmbCoupVar";
            this.cmbCoupVar.Size = new System.Drawing.Size(121, 25);
            this.cmbCoupVar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Муфта";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSupFastening
            // 
            this.pnlSupFastening.AutoScroll = true;
            this.pnlSupFastening.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSupFastening.Controls.Add(this.panel2);
            this.pnlSupFastening.Controls.Add(this.label2);
            this.pnlSupFastening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSupFastening.Location = new System.Drawing.Point(201, 0);
            this.pnlSupFastening.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSupFastening.Name = "pnlSupFastening";
            this.pnlSupFastening.Size = new System.Drawing.Size(201, 301);
            this.pnlSupFastening.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.grpSup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(201, 256);
            this.panel2.TabIndex = 2;
            // 
            // grpSup
            // 
            this.grpSup.AutoSize = true;
            this.grpSup.Controls.Add(this.chkBtnAddSup);
            this.grpSup.Controls.Add(this.pnlSup1);
            this.grpSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSup.Location = new System.Drawing.Point(5, 5);
            this.grpSup.Margin = new System.Windows.Forms.Padding(0);
            this.grpSup.Name = "grpSup";
            this.grpSup.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grpSup.Size = new System.Drawing.Size(191, 111);
            this.grpSup.TabIndex = 0;
            this.grpSup.TabStop = false;
            // 
            // chkBtnAddSup
            // 
            this.chkBtnAddSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBtnAddSup.Location = new System.Drawing.Point(3, 78);
            this.chkBtnAddSup.Margin = new System.Windows.Forms.Padding(0);
            this.chkBtnAddSup.Name = "chkBtnAddSup";
            this.chkBtnAddSup.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkBtnAddSup.Size = new System.Drawing.Size(185, 30);
            this.chkBtnAddSup.TabIndex = 1;
            this.chkBtnAddSup.Text = "Добавить пункт";
            this.chkBtnAddSup.UseVisualStyleBackColor = true;
            this.chkBtnAddSup.CheckedChanged += new System.EventHandler(this.chkBtnAddSup_CheckedChanged);
            // 
            // pnlSup1
            // 
            this.pnlSup1.Controls.Add(this.button1);
            this.pnlSup1.Controls.Add(this.lblSupCount);
            this.pnlSup1.Controls.Add(this.lblSupVar);
            this.pnlSup1.Controls.Add(this.txtSupCount);
            this.pnlSup1.Controls.Add(this.cmbSupVar);
            this.pnlSup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSup1.Location = new System.Drawing.Point(3, 18);
            this.pnlSup1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSup1.Name = "pnlSup1";
            this.pnlSup1.Size = new System.Drawing.Size(185, 60);
            this.pnlSup1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(162, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSupCount
            // 
            this.lblSupCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupCount.AutoSize = true;
            this.lblSupCount.Location = new System.Drawing.Point(127, 3);
            this.lblSupCount.Name = "lblSupCount";
            this.lblSupCount.Size = new System.Drawing.Size(27, 17);
            this.lblSupCount.TabIndex = 3;
            this.lblSupCount.Text = "шт.";
            // 
            // lblSupVar
            // 
            this.lblSupVar.AutoSize = true;
            this.lblSupVar.Location = new System.Drawing.Point(3, 3);
            this.lblSupVar.Name = "lblSupVar";
            this.lblSupVar.Size = new System.Drawing.Size(56, 17);
            this.lblSupVar.TabIndex = 2;
            this.lblSupVar.Text = "Вариант";
            // 
            // txtSupCount
            // 
            this.txtSupCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupCount.Location = new System.Drawing.Point(130, 23);
            this.txtSupCount.Name = "txtSupCount";
            this.txtSupCount.Size = new System.Drawing.Size(52, 25);
            this.txtSupCount.TabIndex = 1;
            this.txtSupCount.Text = "0";
            // 
            // cmbSupVar
            // 
            this.cmbSupVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSupVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupVar.FormattingEnabled = true;
            this.cmbSupVar.Location = new System.Drawing.Point(3, 23);
            this.cmbSupVar.Name = "cmbSupVar";
            this.cmbSupVar.Size = new System.Drawing.Size(121, 25);
            this.cmbSupVar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Поддерживающие крепления";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFastening
            // 
            this.pnlFastening.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFastening.Controls.Add(this.tblFastening);
            this.pnlFastening.Controls.Add(this.lblFastening);
            this.pnlFastening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFastening.Location = new System.Drawing.Point(0, 0);
            this.pnlFastening.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFastening.Name = "pnlFastening";
            this.pnlFastening.Size = new System.Drawing.Size(201, 301);
            this.pnlFastening.TabIndex = 1;
            // 
            // tblFastening
            // 
            this.tblFastening.AutoScroll = true;
            this.tblFastening.Controls.Add(this.grpFastening);
            this.tblFastening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFastening.Location = new System.Drawing.Point(0, 45);
            this.tblFastening.Margin = new System.Windows.Forms.Padding(0);
            this.tblFastening.Name = "tblFastening";
            this.tblFastening.Padding = new System.Windows.Forms.Padding(5);
            this.tblFastening.Size = new System.Drawing.Size(201, 256);
            this.tblFastening.TabIndex = 1;
            // 
            // grpFastening
            // 
            this.grpFastening.AutoSize = true;
            this.grpFastening.Controls.Add(this.chkBtnAddFastening);
            this.grpFastening.Controls.Add(this.pnlFastening1);
            this.grpFastening.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFastening.Location = new System.Drawing.Point(5, 5);
            this.grpFastening.Margin = new System.Windows.Forms.Padding(0);
            this.grpFastening.Name = "grpFastening";
            this.grpFastening.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grpFastening.Size = new System.Drawing.Size(191, 111);
            this.grpFastening.TabIndex = 0;
            this.grpFastening.TabStop = false;
            // 
            // chkBtnAddFastening
            // 
            this.chkBtnAddFastening.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkBtnAddFastening.Location = new System.Drawing.Point(3, 78);
            this.chkBtnAddFastening.Margin = new System.Windows.Forms.Padding(0);
            this.chkBtnAddFastening.Name = "chkBtnAddFastening";
            this.chkBtnAddFastening.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkBtnAddFastening.Size = new System.Drawing.Size(185, 30);
            this.chkBtnAddFastening.TabIndex = 0;
            this.chkBtnAddFastening.Text = "Добавить пункт";
            this.chkBtnAddFastening.UseVisualStyleBackColor = true;
            this.chkBtnAddFastening.CheckedChanged += new System.EventHandler(this.chkBtnAddFastening_CheckedChanged);
            // 
            // pnlFastening1
            // 
            this.pnlFastening1.Controls.Add(this.btnDel);
            this.pnlFastening1.Controls.Add(this.lblFastCount);
            this.pnlFastening1.Controls.Add(this.lblFastVar);
            this.pnlFastening1.Controls.Add(this.txtFastCount);
            this.pnlFastening1.Controls.Add(this.cmbFastVar);
            this.pnlFastening1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFastening1.Location = new System.Drawing.Point(3, 18);
            this.pnlFastening1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFastening1.Name = "pnlFastening1";
            this.pnlFastening1.Size = new System.Drawing.Size(185, 60);
            this.pnlFastening1.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(162, 2);
            this.btnDel.Margin = new System.Windows.Forms.Padding(0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(20, 20);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "X";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // lblFastCount
            // 
            this.lblFastCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFastCount.AutoSize = true;
            this.lblFastCount.Location = new System.Drawing.Point(127, 3);
            this.lblFastCount.Name = "lblFastCount";
            this.lblFastCount.Size = new System.Drawing.Size(27, 17);
            this.lblFastCount.TabIndex = 3;
            this.lblFastCount.Text = "шт.";
            // 
            // lblFastVar
            // 
            this.lblFastVar.AutoSize = true;
            this.lblFastVar.Location = new System.Drawing.Point(3, 3);
            this.lblFastVar.Name = "lblFastVar";
            this.lblFastVar.Size = new System.Drawing.Size(56, 17);
            this.lblFastVar.TabIndex = 2;
            this.lblFastVar.Text = "Вариант";
            // 
            // txtFastCount
            // 
            this.txtFastCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFastCount.Location = new System.Drawing.Point(130, 23);
            this.txtFastCount.Name = "txtFastCount";
            this.txtFastCount.Size = new System.Drawing.Size(52, 25);
            this.txtFastCount.TabIndex = 1;
            this.txtFastCount.Text = "0";
            // 
            // cmbFastVar
            // 
            this.cmbFastVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFastVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFastVar.FormattingEnabled = true;
            this.cmbFastVar.Location = new System.Drawing.Point(3, 23);
            this.cmbFastVar.Name = "cmbFastVar";
            this.cmbFastVar.Size = new System.Drawing.Size(121, 25);
            this.cmbFastVar.TabIndex = 0;
            // 
            // lblFastening
            // 
            this.lblFastening.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFastening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFastening.Location = new System.Drawing.Point(0, 0);
            this.lblFastening.Name = "lblFastening";
            this.lblFastening.Size = new System.Drawing.Size(201, 45);
            this.lblFastening.TabIndex = 0;
            this.lblFastening.Text = "Натяжные крепления";
            this.lblFastening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(5, 306);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(804, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 561);
            this.Controls.Add(this.pnlTbl);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlBot);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Спецификация (вер. 0.1)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlBot.ResumeLayout(false);
            this.pnlJournal.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            this.pnlTbl.ResumeLayout(false);
            this.pnlCross.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpCross.ResumeLayout(false);
            this.pnlCross1.ResumeLayout(false);
            this.pnlCross1.PerformLayout();
            this.pnlCoupling.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.grpCoup.ResumeLayout(false);
            this.pnlCoup1.ResumeLayout(false);
            this.pnlCoup1.PerformLayout();
            this.pnlSupFastening.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpSup.ResumeLayout(false);
            this.pnlSup1.ResumeLayout(false);
            this.pnlSup1.PerformLayout();
            this.pnlFastening.ResumeLayout(false);
            this.tblFastening.ResumeLayout(false);
            this.tblFastening.PerformLayout();
            this.grpFastening.ResumeLayout(false);
            this.pnlFastening1.ResumeLayout(false);
            this.pnlFastening1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.TableLayoutPanel pnlTbl;
        private System.Windows.Forms.Panel pnlFastening;
        private System.Windows.Forms.Panel pnlCoupling;
        private System.Windows.Forms.Panel pnlCross;
        private System.Windows.Forms.Panel pnlSupFastening;
        private System.Windows.Forms.Label lblFastening;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel tblFastening;
        private System.Windows.Forms.GroupBox grpFastening;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grpCoup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpCross;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpSup;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCollectDrawingSet;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Panel pnlJournal;
        private System.Windows.Forms.ListView journal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox chkBtnAddFastening;
        private System.Windows.Forms.Panel pnlFastening1;
        private System.Windows.Forms.Label lblFastCount;
        private System.Windows.Forms.Label lblFastVar;
        private System.Windows.Forms.TextBox txtFastCount;
        private System.Windows.Forms.ComboBox cmbFastVar;
        private System.Windows.Forms.CheckBox chkBtnAddSup;
        private System.Windows.Forms.Panel pnlSup1;
        private System.Windows.Forms.Label lblSupCount;
        private System.Windows.Forms.Label lblSupVar;
        private System.Windows.Forms.TextBox txtSupCount;
        private System.Windows.Forms.ComboBox cmbSupVar;
        private System.Windows.Forms.CheckBox chkBtnAddCoup;
        private System.Windows.Forms.Panel pnlCoup1;
        private System.Windows.Forms.Label lblCoupCount;
        private System.Windows.Forms.Label lblCoupVar;
        private System.Windows.Forms.TextBox txtCoupCount;
        private System.Windows.Forms.ComboBox cmbCoupVar;
        private System.Windows.Forms.CheckBox chkBtnAddCross;
        private System.Windows.Forms.Panel pnlCross1;
        private System.Windows.Forms.Label lblCrossCount;
        private System.Windows.Forms.Label lblCrossVar;
        private System.Windows.Forms.TextBox txtCrossCount;
        private System.Windows.Forms.ComboBox cmbCrossVar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnBuildSpecification;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}

