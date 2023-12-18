
namespace Tyuiu.BotterVV.Sprint7.Project.V4
{
    partial class FormStatistics
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
            this.buttonStatisticClose_BVV = new System.Windows.Forms.Button();
            this.textBoxMaxPrice_BVV = new System.Windows.Forms.TextBox();
            this.labelMaxPrice_BVV = new System.Windows.Forms.Label();
            this.buttonMaxPrice_BVV = new System.Windows.Forms.Button();
            this.dataGridViewDataBase_BVV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_BVV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStatisticClose_BVV
            // 
            this.buttonStatisticClose_BVV.Location = new System.Drawing.Point(619, 381);
            this.buttonStatisticClose_BVV.Name = "buttonStatisticClose_BVV";
            this.buttonStatisticClose_BVV.Size = new System.Drawing.Size(169, 57);
            this.buttonStatisticClose_BVV.TabIndex = 0;
            this.buttonStatisticClose_BVV.Text = "Закрыть";
            this.buttonStatisticClose_BVV.UseVisualStyleBackColor = true;
            this.buttonStatisticClose_BVV.Click += new System.EventHandler(this.buttonStatisticClose_BVV_Click);
            // 
            // textBoxMaxPrice_BVV
            // 
            this.textBoxMaxPrice_BVV.Location = new System.Drawing.Point(36, 61);
            this.textBoxMaxPrice_BVV.Multiline = true;
            this.textBoxMaxPrice_BVV.Name = "textBoxMaxPrice_BVV";
            this.textBoxMaxPrice_BVV.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxPrice_BVV.TabIndex = 1;
            // 
            // labelMaxPrice_BVV
            // 
            this.labelMaxPrice_BVV.AutoSize = true;
            this.labelMaxPrice_BVV.Location = new System.Drawing.Point(33, 32);
            this.labelMaxPrice_BVV.Name = "labelMaxPrice_BVV";
            this.labelMaxPrice_BVV.Size = new System.Drawing.Size(143, 13);
            this.labelMaxPrice_BVV.TabIndex = 2;
            this.labelMaxPrice_BVV.Text = "Максимальная цена книги";
            // 
            // buttonMaxPrice_BVV
            // 
            this.buttonMaxPrice_BVV.Location = new System.Drawing.Point(36, 97);
            this.buttonMaxPrice_BVV.Name = "buttonMaxPrice_BVV";
            this.buttonMaxPrice_BVV.Size = new System.Drawing.Size(100, 27);
            this.buttonMaxPrice_BVV.TabIndex = 3;
            this.buttonMaxPrice_BVV.Text = "Рассчитать";
            this.buttonMaxPrice_BVV.UseVisualStyleBackColor = true;
            this.buttonMaxPrice_BVV.Click += new System.EventHandler(this.buttonMaxPrice_BVV_Click);
            // 
            // dataGridViewDataBase_BVV
            // 
            this.dataGridViewDataBase_BVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBase_BVV.Location = new System.Drawing.Point(548, 12);
            this.dataGridViewDataBase_BVV.Name = "dataGridViewDataBase_BVV";
            this.dataGridViewDataBase_BVV.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewDataBase_BVV.TabIndex = 4;
            this.dataGridViewDataBase_BVV.Visible = false;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDataBase_BVV);
            this.Controls.Add(this.buttonMaxPrice_BVV);
            this.Controls.Add(this.labelMaxPrice_BVV);
            this.Controls.Add(this.textBoxMaxPrice_BVV);
            this.Controls.Add(this.buttonStatisticClose_BVV);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase_BVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStatisticClose_BVV;
        private System.Windows.Forms.TextBox textBoxMaxPrice_BVV;
        private System.Windows.Forms.Label labelMaxPrice_BVV;
        private System.Windows.Forms.Button buttonMaxPrice_BVV;
        private System.Windows.Forms.DataGridView dataGridViewDataBase_BVV;
    }
}