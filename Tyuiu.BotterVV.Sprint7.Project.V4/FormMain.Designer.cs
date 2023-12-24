
namespace Tyuiu.BotterVV.Sprint7.Project.V4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip_BVV = new System.Windows.Forms.MenuStrip();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функционалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБазуДанныхЧитателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDataBase_BVV = new System.Windows.Forms.Panel();
            this.dataGridViewDataBaseReaders_BVV = new System.Windows.Forms.DataGridView();
            this.dataGridViewDataBase_BVV = new System.Windows.Forms.DataGridView();
            this.labelSearch_BVV = new System.Windows.Forms.Label();
            this.textBoxSearch_BVV = new System.Windows.Forms.TextBox();
            this.toolTipButtons_BVV = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSaveCSVBooks_BVV = new System.Windows.Forms.Button();
            this.buttonSaveCSVReaders_BVV = new System.Windows.Forms.Button();
            this.labelFilter_BVV = new System.Windows.Forms.Label();
            this.saveFileDialog_BVV = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonSaveReaders_BVV = new System.Windows.Forms.RadioButton();
            this.radioButtonSaveBook_BVV = new System.Windows.Forms.RadioButton();
            this.comboBoxFilterReaders_BVV = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterBooks_BVV = new System.Windows.Forms.ComboBox();
            this.groupBoxFilterSearch_BVV = new System.Windows.Forms.GroupBox();
            this.buttonSortUbyvanie_BVV = new System.Windows.Forms.Button();
            this.buttonSortVozrast_BVV = new System.Windows.Forms.Button();
            this.textBoxFilterSearch_BVV = new System.Windows.Forms.TextBox();
            this.menuStrip_BVV.SuspendLayout();
            this.panelDataBase_BVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBaseReaders_BVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_BVV)).BeginInit();
            this.groupBoxFilterSearch_BVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_BVV
            // 
            this.menuStrip_BVV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem,
            this.функционалToolStripMenuItem});
            this.menuStrip_BVV.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_BVV.Name = "menuStrip_BVV";
            this.menuStrip_BVV.Size = new System.Drawing.Size(984, 24);
            this.menuStrip_BVV.TabIndex = 0;
            this.menuStrip_BVV.Text = "menuStrip1";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.параметрыToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.cog;
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.information;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // функционалToolStripMenuItem
            // 
            this.функционалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьБазуДанныхToolStripMenuItem,
            this.открытьБазуДанныхЧитателейToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.функционалToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.book;
            this.функционалToolStripMenuItem.Name = "функционалToolStripMenuItem";
            this.функционалToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.функционалToolStripMenuItem.Text = "Функционал";
            // 
            // открытьБазуДанныхToolStripMenuItem
            // 
            this.открытьБазуДанныхToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.book_open;
            this.открытьБазуДанныхToolStripMenuItem.Name = "открытьБазуДанныхToolStripMenuItem";
            this.открытьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.открытьБазуДанныхToolStripMenuItem.Text = "Открыть базу данных книг...";
            this.открытьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.открытьБазуДанныхToolStripMenuItem_Click);
            // 
            // открытьБазуДанныхЧитателейToolStripMenuItem
            // 
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.book_addresses;
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Name = "открытьБазуДанныхЧитателейToolStripMenuItem";
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Text = "Открыть базу данных читателей...";
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Click += new System.EventHandler(this.открытьБазуДанныхЧитателейToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.chart_line;
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // panelDataBase_BVV
            // 
            this.panelDataBase_BVV.Controls.Add(this.dataGridViewDataBaseReaders_BVV);
            this.panelDataBase_BVV.Controls.Add(this.dataGridViewDataBase_BVV);
            this.panelDataBase_BVV.Enabled = false;
            this.panelDataBase_BVV.Location = new System.Drawing.Point(812, 395);
            this.panelDataBase_BVV.Name = "panelDataBase_BVV";
            this.panelDataBase_BVV.Size = new System.Drawing.Size(134, 59);
            this.panelDataBase_BVV.TabIndex = 1;
            this.panelDataBase_BVV.Visible = false;
            // 
            // dataGridViewDataBaseReaders_BVV
            // 
            this.dataGridViewDataBaseReaders_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBaseReaders_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataBaseReaders_BVV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDataBaseReaders_BVV.Name = "dataGridViewDataBaseReaders_BVV";
            this.dataGridViewDataBaseReaders_BVV.RowHeadersVisible = false;
            this.dataGridViewDataBaseReaders_BVV.Size = new System.Drawing.Size(134, 59);
            this.dataGridViewDataBaseReaders_BVV.TabIndex = 1;
            // 
            // dataGridViewDataBase_BVV
            // 
            this.dataGridViewDataBase_BVV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDataBase_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBase_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataBase_BVV.Enabled = false;
            this.dataGridViewDataBase_BVV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDataBase_BVV.Name = "dataGridViewDataBase_BVV";
            this.dataGridViewDataBase_BVV.RowHeadersVisible = false;
            this.dataGridViewDataBase_BVV.Size = new System.Drawing.Size(134, 59);
            this.dataGridViewDataBase_BVV.TabIndex = 0;
            this.dataGridViewDataBase_BVV.Visible = false;
            // 
            // labelSearch_BVV
            // 
            this.labelSearch_BVV.AutoSize = true;
            this.labelSearch_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.labelSearch_BVV.Location = new System.Drawing.Point(214, 6);
            this.labelSearch_BVV.Name = "labelSearch_BVV";
            this.labelSearch_BVV.Size = new System.Drawing.Size(39, 13);
            this.labelSearch_BVV.TabIndex = 3;
            this.labelSearch_BVV.Text = "Поиск";
            // 
            // textBoxSearch_BVV
            // 
            this.textBoxSearch_BVV.Location = new System.Drawing.Point(259, 3);
            this.textBoxSearch_BVV.Name = "textBoxSearch_BVV";
            this.textBoxSearch_BVV.Size = new System.Drawing.Size(188, 20);
            this.textBoxSearch_BVV.TabIndex = 2;
            this.textBoxSearch_BVV.TextChanged += new System.EventHandler(this.textBoxSearch_BVV_TextChanged);
            // 
            // toolTipButtons_BVV
            // 
            this.toolTipButtons_BVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // buttonSaveCSVBooks_BVV
            // 
            this.buttonSaveCSVBooks_BVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveCSVBooks_BVV.Location = new System.Drawing.Point(883, 2);
            this.buttonSaveCSVBooks_BVV.Name = "buttonSaveCSVBooks_BVV";
            this.buttonSaveCSVBooks_BVV.Size = new System.Drawing.Size(89, 21);
            this.buttonSaveCSVBooks_BVV.TabIndex = 7;
            this.buttonSaveCSVBooks_BVV.Text = "Сохранить файл";
            this.toolTipButtons_BVV.SetToolTip(this.buttonSaveCSVBooks_BVV, "Сохранить базу данных читателей...");
            this.buttonSaveCSVBooks_BVV.UseVisualStyleBackColor = true;
            this.buttonSaveCSVBooks_BVV.Visible = false;
            this.buttonSaveCSVBooks_BVV.Click += new System.EventHandler(this.buttonSaveCSVBooks_BVV_Click);
            this.buttonSaveCSVBooks_BVV.MouseEnter += new System.EventHandler(this.buttonSaveCSVBooks_BVV_MouseEnter);
            // 
            // buttonSaveCSVReaders_BVV
            // 
            this.buttonSaveCSVReaders_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveCSVReaders_BVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveCSVReaders_BVV.Location = new System.Drawing.Point(883, 2);
            this.buttonSaveCSVReaders_BVV.Name = "buttonSaveCSVReaders_BVV";
            this.buttonSaveCSVReaders_BVV.Size = new System.Drawing.Size(89, 21);
            this.buttonSaveCSVReaders_BVV.TabIndex = 8;
            this.buttonSaveCSVReaders_BVV.Text = "Сохранить файл";
            this.toolTipButtons_BVV.SetToolTip(this.buttonSaveCSVReaders_BVV, "Сохранить базу данных читателей...");
            this.buttonSaveCSVReaders_BVV.UseVisualStyleBackColor = true;
            this.buttonSaveCSVReaders_BVV.Visible = false;
            this.buttonSaveCSVReaders_BVV.Click += new System.EventHandler(this.buttonSaveCSVReaders_BVV_Click);
            this.buttonSaveCSVReaders_BVV.MouseEnter += new System.EventHandler(this.buttonSaveCSVReaders_BVV_MouseEnter);
            // 
            // labelFilter_BVV
            // 
            this.labelFilter_BVV.AutoSize = true;
            this.labelFilter_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.labelFilter_BVV.Location = new System.Drawing.Point(469, 5);
            this.labelFilter_BVV.Name = "labelFilter_BVV";
            this.labelFilter_BVV.Size = new System.Drawing.Size(47, 13);
            this.labelFilter_BVV.TabIndex = 5;
            this.labelFilter_BVV.Text = "Фильтр";
            this.labelFilter_BVV.Visible = false;
            // 
            // radioButtonSaveReaders_BVV
            // 
            this.radioButtonSaveReaders_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSaveReaders_BVV.AutoSize = true;
            this.radioButtonSaveReaders_BVV.Enabled = false;
            this.radioButtonSaveReaders_BVV.Location = new System.Drawing.Point(733, 5);
            this.radioButtonSaveReaders_BVV.Name = "radioButtonSaveReaders_BVV";
            this.radioButtonSaveReaders_BVV.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSaveReaders_BVV.TabIndex = 9;
            this.radioButtonSaveReaders_BVV.TabStop = true;
            this.radioButtonSaveReaders_BVV.Text = "Читатели";
            this.radioButtonSaveReaders_BVV.UseVisualStyleBackColor = true;
            this.radioButtonSaveReaders_BVV.CheckedChanged += new System.EventHandler(this.radioButtonSaveReaders_BVV_CheckedChanged);
            // 
            // radioButtonSaveBook_BVV
            // 
            this.radioButtonSaveBook_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSaveBook_BVV.AutoSize = true;
            this.radioButtonSaveBook_BVV.Enabled = false;
            this.radioButtonSaveBook_BVV.Location = new System.Drawing.Point(822, 5);
            this.radioButtonSaveBook_BVV.Name = "radioButtonSaveBook_BVV";
            this.radioButtonSaveBook_BVV.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSaveBook_BVV.TabIndex = 10;
            this.radioButtonSaveBook_BVV.TabStop = true;
            this.radioButtonSaveBook_BVV.Text = "Книги";
            this.radioButtonSaveBook_BVV.UseVisualStyleBackColor = true;
            this.radioButtonSaveBook_BVV.CheckedChanged += new System.EventHandler(this.radioButtonSaveBook_BVV_CheckedChanged);
            // 
            // comboBoxFilterReaders_BVV
            // 
            this.comboBoxFilterReaders_BVV.FormattingEnabled = true;
            this.comboBoxFilterReaders_BVV.Items.AddRange(new object[] {
            "Номер читательского билета",
            "ФИО",
            "Адрес читателя",
            "Телефон читателя",
            "Дата выдачи книги читателю",
            "Дата сдачи книги читателем"});
            this.comboBoxFilterReaders_BVV.Location = new System.Drawing.Point(522, 2);
            this.comboBoxFilterReaders_BVV.Name = "comboBoxFilterReaders_BVV";
            this.comboBoxFilterReaders_BVV.Size = new System.Drawing.Size(194, 21);
            this.comboBoxFilterReaders_BVV.TabIndex = 11;
            this.comboBoxFilterReaders_BVV.Visible = false;
            this.comboBoxFilterReaders_BVV.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterReaders_BVV_SelectedIndexChanged);
            // 
            // comboBoxFilterBooks_BVV
            // 
            this.comboBoxFilterBooks_BVV.FormattingEnabled = true;
            this.comboBoxFilterBooks_BVV.Items.AddRange(new object[] {
            "Автор",
            "Название",
            "Год издания",
            "Цена",
            "Новое издание",
            "Краткая аннотация"});
            this.comboBoxFilterBooks_BVV.Location = new System.Drawing.Point(522, 2);
            this.comboBoxFilterBooks_BVV.Name = "comboBoxFilterBooks_BVV";
            this.comboBoxFilterBooks_BVV.Size = new System.Drawing.Size(194, 21);
            this.comboBoxFilterBooks_BVV.TabIndex = 12;
            this.comboBoxFilterBooks_BVV.Visible = false;
            this.comboBoxFilterBooks_BVV.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterBooks_BVV_SelectedIndexChanged);
            // 
            // groupBoxFilterSearch_BVV
            // 
            this.groupBoxFilterSearch_BVV.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxFilterSearch_BVV.Controls.Add(this.buttonSortUbyvanie_BVV);
            this.groupBoxFilterSearch_BVV.Controls.Add(this.buttonSortVozrast_BVV);
            this.groupBoxFilterSearch_BVV.Controls.Add(this.textBoxFilterSearch_BVV);
            this.groupBoxFilterSearch_BVV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxFilterSearch_BVV.Location = new System.Drawing.Point(0, 530);
            this.groupBoxFilterSearch_BVV.Name = "groupBoxFilterSearch_BVV";
            this.groupBoxFilterSearch_BVV.Size = new System.Drawing.Size(984, 31);
            this.groupBoxFilterSearch_BVV.TabIndex = 13;
            this.groupBoxFilterSearch_BVV.TabStop = false;
            // 
            // buttonSortUbyvanie_BVV
            // 
            this.buttonSortUbyvanie_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonSortUbyvanie_BVV.Location = new System.Drawing.Point(855, 6);
            this.buttonSortUbyvanie_BVV.Name = "buttonSortUbyvanie_BVV";
            this.buttonSortUbyvanie_BVV.Size = new System.Drawing.Size(106, 23);
            this.buttonSortUbyvanie_BVV.TabIndex = 2;
            this.buttonSortUbyvanie_BVV.Text = "По убыванию";
            this.buttonSortUbyvanie_BVV.UseVisualStyleBackColor = true;
            this.buttonSortUbyvanie_BVV.Visible = false;
            this.buttonSortUbyvanie_BVV.Click += new System.EventHandler(this.buttonSortUbyvanie_BVV_Click);
            // 
            // buttonSortVozrast_BVV
            // 
            this.buttonSortVozrast_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonSortVozrast_BVV.Location = new System.Drawing.Point(733, 6);
            this.buttonSortVozrast_BVV.Name = "buttonSortVozrast_BVV";
            this.buttonSortVozrast_BVV.Size = new System.Drawing.Size(106, 23);
            this.buttonSortVozrast_BVV.TabIndex = 1;
            this.buttonSortVozrast_BVV.Text = "По возрастанию";
            this.buttonSortVozrast_BVV.UseVisualStyleBackColor = true;
            this.buttonSortVozrast_BVV.Visible = false;
            this.buttonSortVozrast_BVV.Click += new System.EventHandler(this.buttonSortVozrast_BVV_Click);
            // 
            // textBoxFilterSearch_BVV
            // 
            this.textBoxFilterSearch_BVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxFilterSearch_BVV.Location = new System.Drawing.Point(259, 8);
            this.textBoxFilterSearch_BVV.Name = "textBoxFilterSearch_BVV";
            this.textBoxFilterSearch_BVV.Size = new System.Drawing.Size(457, 20);
            this.textBoxFilterSearch_BVV.TabIndex = 0;
            this.textBoxFilterSearch_BVV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxFilterSearch_BVV_MouseClick);
            this.textBoxFilterSearch_BVV.TextChanged += new System.EventHandler(this.textBoxFilterSearch_BVV_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBoxFilterSearch_BVV);
            this.Controls.Add(this.comboBoxFilterBooks_BVV);
            this.Controls.Add(this.comboBoxFilterReaders_BVV);
            this.Controls.Add(this.radioButtonSaveBook_BVV);
            this.Controls.Add(this.radioButtonSaveReaders_BVV);
            this.Controls.Add(this.buttonSaveCSVReaders_BVV);
            this.Controls.Add(this.buttonSaveCSVBooks_BVV);
            this.Controls.Add(this.labelFilter_BVV);
            this.Controls.Add(this.labelSearch_BVV);
            this.Controls.Add(this.textBoxSearch_BVV);
            this.Controls.Add(this.panelDataBase_BVV);
            this.Controls.Add(this.menuStrip_BVV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_BVV;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект: Библиотека | Вариант 4 | Боттер В.В.";
            this.menuStrip_BVV.ResumeLayout(false);
            this.menuStrip_BVV.PerformLayout();
            this.panelDataBase_BVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBaseReaders_BVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_BVV)).EndInit();
            this.groupBoxFilterSearch_BVV.ResumeLayout(false);
            this.groupBoxFilterSearch_BVV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_BVV;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функционалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьБазуДанныхToolStripMenuItem;
        private System.Windows.Forms.Panel panelDataBase_BVV;
        private System.Windows.Forms.DataGridView dataGridViewDataBase_BVV;
        private System.Windows.Forms.Label labelSearch_BVV;
        private System.Windows.Forms.TextBox textBoxSearch_BVV;
        private System.Windows.Forms.ToolStripMenuItem открытьБазуДанныхЧитателейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipButtons_BVV;
        private System.Windows.Forms.Label labelFilter_BVV;
        private System.Windows.Forms.Button buttonSaveCSVBooks_BVV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_BVV;
        private System.Windows.Forms.Button buttonSaveCSVReaders_BVV;
        private System.Windows.Forms.RadioButton radioButtonSaveReaders_BVV;
        private System.Windows.Forms.RadioButton radioButtonSaveBook_BVV;
        private System.Windows.Forms.ComboBox comboBoxFilterReaders_BVV;
        private System.Windows.Forms.ComboBox comboBoxFilterBooks_BVV;
        private System.Windows.Forms.GroupBox groupBoxFilterSearch_BVV;
        private System.Windows.Forms.TextBox textBoxFilterSearch_BVV;
        private System.Windows.Forms.Button buttonSortUbyvanie_BVV;
        private System.Windows.Forms.Button buttonSortVozrast_BVV;
        private System.Windows.Forms.DataGridView dataGridViewDataBaseReaders_BVV;
    }
}

