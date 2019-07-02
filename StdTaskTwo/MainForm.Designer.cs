namespace StdTaskTwo
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raceAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raceBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raceCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.startTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.secondsStartTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesStartTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hoursStartTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.secondsEndTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesEndTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hoursEndTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.actionButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.addGroupBox.SuspendLayout();
            this.dateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.startTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsStartTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesStartTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursStartTimeNumericUpDown)).BeginInit();
            this.endTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsEndTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesEndTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursEndTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(843, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.saveToolStripMenuItem.Text = "Экспорт";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.openToolStripMenuItem.Text = "Импорт";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.removeToolStripMenuItem.Text = "Удалить";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raceAToolStripMenuItem,
            this.raceBToolStripMenuItem,
            this.raceCToolStripMenuItem,
            this.averageTimeToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sortToolStripMenuItem.Text = "Сортировать";
            // 
            // raceAToolStripMenuItem
            // 
            this.raceAToolStripMenuItem.Name = "raceAToolStripMenuItem";
            this.raceAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raceAToolStripMenuItem.Text = "Соревнование А";
            this.raceAToolStripMenuItem.Click += new System.EventHandler(this.raceAToolStripMenuItem_Click);
            // 
            // raceBToolStripMenuItem
            // 
            this.raceBToolStripMenuItem.Name = "raceBToolStripMenuItem";
            this.raceBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raceBToolStripMenuItem.Text = "Соревнование B";
            this.raceBToolStripMenuItem.Click += new System.EventHandler(this.raceBToolStripMenuItem_Click);
            // 
            // raceCToolStripMenuItem
            // 
            this.raceCToolStripMenuItem.Name = "raceCToolStripMenuItem";
            this.raceCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raceCToolStripMenuItem.Text = "Соревнование С";
            this.raceCToolStripMenuItem.Click += new System.EventHandler(this.raceCToolStripMenuItem_Click);
            // 
            // averageTimeToolStripMenuItem
            // 
            this.averageTimeToolStripMenuItem.Name = "averageTimeToolStripMenuItem";
            this.averageTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.averageTimeToolStripMenuItem.Text = "Среднее время";
            this.averageTimeToolStripMenuItem.Click += new System.EventHandler(this.averageTimeToolStripMenuItem_Click);
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.raceComboBox);
            this.addGroupBox.Controls.Add(this.raceLabel);
            this.addGroupBox.Controls.Add(this.dateGroupBox);
            this.addGroupBox.Controls.Add(this.distanceLabel);
            this.addGroupBox.Controls.Add(this.numericUpDown1);
            this.addGroupBox.Controls.Add(this.clearButton);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.startTimeGroupBox);
            this.addGroupBox.Controls.Add(this.endTimeGroupBox);
            this.addGroupBox.Controls.Add(this.nameLabel);
            this.addGroupBox.Controls.Add(this.nameTextBox);
            this.addGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGroupBox.Location = new System.Drawing.Point(0, 24);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(843, 130);
            this.addGroupBox.TabIndex = 1;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Новый участник";
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(128, 38);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(80, 21);
            this.raceComboBox.TabIndex = 11;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(125, 19);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(83, 13);
            this.raceLabel.TabIndex = 10;
            this.raceLabel.Text = "Соревнование:";
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.monthComboBox);
            this.dateGroupBox.Controls.Add(this.yearNumericUpDown);
            this.dateGroupBox.Controls.Add(this.dayNumericUpDown);
            this.dateGroupBox.Location = new System.Drawing.Point(214, 18);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(196, 55);
            this.dateGroupBox.TabIndex = 9;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Дата забега";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.monthComboBox.Location = new System.Drawing.Point(57, 20);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(73, 21);
            this.monthComboBox.TabIndex = 2;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(136, 21);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.ReadOnly = true;
            this.yearNumericUpDown.Size = new System.Drawing.Size(53, 20);
            this.yearNumericUpDown.TabIndex = 1;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.yearNumericUpDown.ValueChanged += new System.EventHandler(this.yearNumericUpDown_ValueChanged);
            // 
            // dayNumericUpDown
            // 
            this.dayNumericUpDown.Location = new System.Drawing.Point(6, 20);
            this.dayNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayNumericUpDown.Name = "dayNumericUpDown";
            this.dayNumericUpDown.ReadOnly = true;
            this.dayNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.dayNumericUpDown.TabIndex = 0;
            this.dayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(740, 17);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(89, 13);
            this.distanceLabel.TabIndex = 8;
            this.distanceLabel.Text = "Дистанция (км):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(743, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(424, 80);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 39);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(313, 80);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 39);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // startTimeGroupBox
            // 
            this.startTimeGroupBox.Controls.Add(this.secondsStartTimeNumericUpDown);
            this.startTimeGroupBox.Controls.Add(this.minutesStartTimeNumericUpDown);
            this.startTimeGroupBox.Controls.Add(this.hoursStartTimeNumericUpDown);
            this.startTimeGroupBox.Location = new System.Drawing.Point(416, 18);
            this.startTimeGroupBox.Name = "startTimeGroupBox";
            this.startTimeGroupBox.Size = new System.Drawing.Size(156, 55);
            this.startTimeGroupBox.TabIndex = 4;
            this.startTimeGroupBox.TabStop = false;
            this.startTimeGroupBox.Text = "Время старта";
            // 
            // secondsStartTimeNumericUpDown
            // 
            this.secondsStartTimeNumericUpDown.Location = new System.Drawing.Point(105, 20);
            this.secondsStartTimeNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.secondsStartTimeNumericUpDown.Name = "secondsStartTimeNumericUpDown";
            this.secondsStartTimeNumericUpDown.ReadOnly = true;
            this.secondsStartTimeNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.secondsStartTimeNumericUpDown.TabIndex = 2;
            // 
            // minutesStartTimeNumericUpDown
            // 
            this.minutesStartTimeNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.minutesStartTimeNumericUpDown.Location = new System.Drawing.Point(55, 20);
            this.minutesStartTimeNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.minutesStartTimeNumericUpDown.Name = "minutesStartTimeNumericUpDown";
            this.minutesStartTimeNumericUpDown.ReadOnly = true;
            this.minutesStartTimeNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.minutesStartTimeNumericUpDown.TabIndex = 1;
            // 
            // hoursStartTimeNumericUpDown
            // 
            this.hoursStartTimeNumericUpDown.Location = new System.Drawing.Point(6, 20);
            this.hoursStartTimeNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hoursStartTimeNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hoursStartTimeNumericUpDown.Name = "hoursStartTimeNumericUpDown";
            this.hoursStartTimeNumericUpDown.ReadOnly = true;
            this.hoursStartTimeNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.hoursStartTimeNumericUpDown.TabIndex = 0;
            this.hoursStartTimeNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // endTimeGroupBox
            // 
            this.endTimeGroupBox.Controls.Add(this.secondsEndTimeNumericUpDown);
            this.endTimeGroupBox.Controls.Add(this.minutesEndTimeNumericUpDown);
            this.endTimeGroupBox.Controls.Add(this.hoursEndTimeNumericUpDown);
            this.endTimeGroupBox.Location = new System.Drawing.Point(578, 18);
            this.endTimeGroupBox.Name = "endTimeGroupBox";
            this.endTimeGroupBox.Size = new System.Drawing.Size(156, 55);
            this.endTimeGroupBox.TabIndex = 3;
            this.endTimeGroupBox.TabStop = false;
            this.endTimeGroupBox.Text = "Время финиша";
            // 
            // secondsEndTimeNumericUpDown
            // 
            this.secondsEndTimeNumericUpDown.Location = new System.Drawing.Point(105, 20);
            this.secondsEndTimeNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsEndTimeNumericUpDown.Name = "secondsEndTimeNumericUpDown";
            this.secondsEndTimeNumericUpDown.ReadOnly = true;
            this.secondsEndTimeNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.secondsEndTimeNumericUpDown.TabIndex = 2;
            // 
            // minutesEndTimeNumericUpDown
            // 
            this.minutesEndTimeNumericUpDown.Location = new System.Drawing.Point(55, 20);
            this.minutesEndTimeNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesEndTimeNumericUpDown.Name = "minutesEndTimeNumericUpDown";
            this.minutesEndTimeNumericUpDown.ReadOnly = true;
            this.minutesEndTimeNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.minutesEndTimeNumericUpDown.TabIndex = 1;
            // 
            // hoursEndTimeNumericUpDown
            // 
            this.hoursEndTimeNumericUpDown.Location = new System.Drawing.Point(6, 20);
            this.hoursEndTimeNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursEndTimeNumericUpDown.Name = "hoursEndTimeNumericUpDown";
            this.hoursEndTimeNumericUpDown.ReadOnly = true;
            this.hoursEndTimeNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.hoursEndTimeNumericUpDown.TabIndex = 0;
            this.hoursEndTimeNumericUpDown.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Фамилия:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(109, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToDeleteRows = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDataGridView.Location = new System.Drawing.Point(0, 154);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.ReadOnly = true;
            this.reportDataGridView.RowHeadersVisible = false;
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(843, 335);
            this.reportDataGridView.TabIndex = 2;
            this.reportDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.reportDataGridView_KeyUp);
            // 
            // actionButton
            // 
            this.actionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionButton.Location = new System.Drawing.Point(0, 489);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(843, 26);
            this.actionButton.TabIndex = 3;
            this.actionButton.Text = "Результаты";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Txt files(*.txt)|*.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Txt files(*.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 515);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Marathon results";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.dateGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.startTimeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secondsStartTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesStartTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursStartTimeNumericUpDown)).EndInit();
            this.endTimeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secondsEndTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesEndTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursEndTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox endTimeGroupBox;
        private System.Windows.Forms.NumericUpDown secondsEndTimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown minutesEndTimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown hoursEndTimeNumericUpDown;
        private System.Windows.Forms.GroupBox startTimeGroupBox;
        private System.Windows.Forms.NumericUpDown secondsStartTimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown minutesStartTimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown hoursStartTimeNumericUpDown;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox dateGroupBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown dayNumericUpDown;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem raceAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raceBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raceCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageTimeToolStripMenuItem;
    }
}

