
namespace Project.V4.App
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
            this.panelFind_BVV = new System.Windows.Forms.Panel();
            this.dataGridViewDataBase_BVV = new System.Windows.Forms.DataGridView();
            this.menuStrip_BVV.SuspendLayout();
            this.panelFind_BVV.SuspendLayout();
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
            this.параметрыToolStripMenuItem.Image = global::Project.V4.App.Properties.Resources.cog;
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // функционалToolStripMenuItem
            // 
            this.функционалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.открытьБазуДанныхToolStripMenuItem});
            this.функционалToolStripMenuItem.Image = global::Project.V4.App.Properties.Resources.book;
            this.функционалToolStripMenuItem.Name = "функционалToolStripMenuItem";
            this.функционалToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.функционалToolStripMenuItem.Text = "Функционал";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Image = global::Project.V4.App.Properties.Resources.magnifier;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.поискToolStripMenuItem.Text = "Поиск...";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // открытьБазуДанныхToolStripMenuItem
            // 
            this.открытьБазуДанныхToolStripMenuItem.Name = "открытьБазуДанныхToolStripMenuItem";
            this.открытьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.открытьБазуДанныхToolStripMenuItem.Text = "Открыть базу данных...";
            this.открытьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.открытьБазуДанныхToolStripMenuItem_Click);
            // 
            // panelFind_BVV
            // 
            this.panelFind_BVV.Controls.Add(this.dataGridViewDataBase_BVV);
            this.panelFind_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFind_BVV.Enabled = false;
            this.panelFind_BVV.Location = new System.Drawing.Point(0, 24);
            this.panelFind_BVV.Name = "panelFind_BVV";
            this.panelFind_BVV.Size = new System.Drawing.Size(800, 426);
            this.panelFind_BVV.TabIndex = 1;
            this.panelFind_BVV.Visible = false;
            // 
            // dataGridViewDataBase_BVV
            // 
            this.dataGridViewDataBase_BVV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDataBase_BVV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewDataBase_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBase_BVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataBase_BVV.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDataBase_BVV.Name = "dataGridViewDataBase_BVV";
            this.dataGridViewDataBase_BVV.ReadOnly = true;
            this.dataGridViewDataBase_BVV.Size = new System.Drawing.Size(800, 426);
            this.dataGridViewDataBase_BVV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFind_BVV);
            this.Controls.Add(this.menuStrip_BVV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_BVV;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.menuStrip_BVV.ResumeLayout(false);
            this.menuStrip_BVV.PerformLayout();
            this.panelFind_BVV.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelFind_BVV;
        private System.Windows.Forms.DataGridView dataGridViewDataBase_BVV;
    }
}

