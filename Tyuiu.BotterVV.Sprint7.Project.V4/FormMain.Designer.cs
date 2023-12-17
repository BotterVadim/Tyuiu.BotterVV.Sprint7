
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip_BVV = new System.Windows.Forms.MenuStrip();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функционалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБазуДанныхЧитателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDataBase_BVV = new System.Windows.Forms.Panel();
            this.dataGridViewDataBase_BVV = new System.Windows.Forms.DataGridView();
            this.labelSearch_BVV = new System.Windows.Forms.Label();
            this.textBoxSearch_BVV = new System.Windows.Forms.TextBox();
            this.buttonSearch_BVV = new System.Windows.Forms.Button();
            this.menuStrip_BVV.SuspendLayout();
            this.panelDataBase_BVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_BVV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_BVV
            // 
            this.menuStrip_BVV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem,
            this.функционалToolStripMenuItem});
            this.menuStrip_BVV.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_BVV.Name = "menuStrip_BVV";
            this.menuStrip_BVV.Size = new System.Drawing.Size(800, 24);
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
            this.поискToolStripMenuItem,
            this.открытьБазуДанныхToolStripMenuItem,
            this.открытьБазуДанныхЧитателейToolStripMenuItem});
            this.функционалToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.book;
            this.функционалToolStripMenuItem.Name = "функционалToolStripMenuItem";
            this.функционалToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.функционалToolStripMenuItem.Text = "Функционал";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.magnifier;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.поискToolStripMenuItem.Text = "Поиск...";
            // 
            // открытьБазуДанныхToolStripMenuItem
            // 
            this.открытьБазуДанныхToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.book_open;
            this.открытьБазуДанныхToolStripMenuItem.Name = "открытьБазуДанныхToolStripMenuItem";
            this.открытьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.открытьБазуДанныхToolStripMenuItem.Text = "Открыть базу данных произведений...";
            this.открытьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.открытьБазуДанныхToolStripMenuItem_Click);
            // 
            // открытьБазуДанныхЧитателейToolStripMenuItem
            // 
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Image = global::Tyuiu.BotterVV.Sprint7.Project.V4.Properties.Resources.book_addresses;
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Name = "открытьБазуДанныхЧитателейToolStripMenuItem";
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Text = "Открыть базу данных читателей...";
            this.открытьБазуДанныхЧитателейToolStripMenuItem.Click += new System.EventHandler(this.открытьБазуДанныхЧитателейToolStripMenuItem_Click);
            // 
            // panelDataBase_BVV
            // 
            this.panelDataBase_BVV.Controls.Add(this.dataGridViewDataBase_BVV);
            this.panelDataBase_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataBase_BVV.Enabled = false;
            this.panelDataBase_BVV.Location = new System.Drawing.Point(0, 24);
            this.panelDataBase_BVV.Name = "panelDataBase_BVV";
            this.panelDataBase_BVV.Size = new System.Drawing.Size(800, 426);
            this.panelDataBase_BVV.TabIndex = 1;
            this.panelDataBase_BVV.Visible = false;
            // 
            // dataGridViewDataBase_BVV
            // 
            this.dataGridViewDataBase_BVV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDataBase_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBase_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataBase_BVV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDataBase_BVV.Name = "dataGridViewDataBase_BVV";
            this.dataGridViewDataBase_BVV.ReadOnly = true;
            this.dataGridViewDataBase_BVV.RowHeadersVisible = false;
            this.dataGridViewDataBase_BVV.Size = new System.Drawing.Size(800, 426);
            this.dataGridViewDataBase_BVV.TabIndex = 0;
            // 
            // labelSearch_BVV
            // 
            this.labelSearch_BVV.AutoSize = true;
            this.labelSearch_BVV.BackColor = System.Drawing.SystemColors.Control;
            this.labelSearch_BVV.Location = new System.Drawing.Point(214, 6);
            this.labelSearch_BVV.Name = "labelSearch_BVV";
            this.labelSearch_BVV.Size = new System.Drawing.Size(42, 13);
            this.labelSearch_BVV.TabIndex = 3;
            this.labelSearch_BVV.Text = "Поиск:";
            // 
            // textBoxSearch_BVV
            // 
            this.textBoxSearch_BVV.Location = new System.Drawing.Point(262, 3);
            this.textBoxSearch_BVV.Name = "textBoxSearch_BVV";
            this.textBoxSearch_BVV.Size = new System.Drawing.Size(206, 20);
            this.textBoxSearch_BVV.TabIndex = 2;
            // 
            // buttonSearch_BVV
            // 
            this.buttonSearch_BVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch_BVV.Location = new System.Drawing.Point(474, 3);
            this.buttonSearch_BVV.Name = "buttonSearch_BVV";
            this.buttonSearch_BVV.Size = new System.Drawing.Size(75, 18);
            this.buttonSearch_BVV.TabIndex = 4;
            this.buttonSearch_BVV.Text = "Искать";
            this.buttonSearch_BVV.UseVisualStyleBackColor = true;
            this.buttonSearch_BVV.Click += new System.EventHandler(this.buttonSearch_BVV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch_BVV);
            this.Controls.Add(this.labelSearch_BVV);
            this.Controls.Add(this.textBoxSearch_BVV);
            this.Controls.Add(this.panelDataBase_BVV);
            this.Controls.Add(this.menuStrip_BVV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_BVV;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.menuStrip_BVV.ResumeLayout(false);
            this.menuStrip_BVV.PerformLayout();
            this.panelDataBase_BVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_BVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_BVV;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функционалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьБазуДанныхToolStripMenuItem;
        private System.Windows.Forms.Panel panelDataBase_BVV;
        private System.Windows.Forms.DataGridView dataGridViewDataBase_BVV;
        private System.Windows.Forms.Label labelSearch_BVV;
        private System.Windows.Forms.TextBox textBoxSearch_BVV;
        private System.Windows.Forms.Button buttonSearch_BVV;
        private System.Windows.Forms.ToolStripMenuItem открытьБазуДанныхЧитателейToolStripMenuItem;
    }
}

