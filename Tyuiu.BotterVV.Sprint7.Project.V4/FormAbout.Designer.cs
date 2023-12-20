
namespace Tyuiu.BotterVV.Sprint7.Project.V4
{
    partial class FormAbout
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
            this.labelAbout_BVV = new System.Windows.Forms.Label();
            this.buttonAbout_BVV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAbout_BVV
            // 
            this.labelAbout_BVV.AutoSize = true;
            this.labelAbout_BVV.Location = new System.Drawing.Point(12, 55);
            this.labelAbout_BVV.Name = "labelAbout_BVV";
            this.labelAbout_BVV.Size = new System.Drawing.Size(261, 91);
            this.labelAbout_BVV.TabIndex = 0;
            this.labelAbout_BVV.Text = "Разработчик: Боттер В.В.\r\nГруппа: ПКТб-23-2\r\n\r\nПроект разработан в рамках изучени" +
    "я языка C#\r\n\r\nТюменский индустриальный университет (c) 2023\r\nВысшая школа цифров" +
    "ых технологий (c) 2023\r\n";
            // 
            // buttonAbout_BVV
            // 
            this.buttonAbout_BVV.Location = new System.Drawing.Point(346, 198);
            this.buttonAbout_BVV.Name = "buttonAbout_BVV";
            this.buttonAbout_BVV.Size = new System.Drawing.Size(126, 51);
            this.buttonAbout_BVV.TabIndex = 1;
            this.buttonAbout_BVV.Text = "Закрыть";
            this.buttonAbout_BVV.UseVisualStyleBackColor = true;
            this.buttonAbout_BVV.Click += new System.EventHandler(this.buttonAbout_BVV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonAbout_BVV);
            this.Controls.Add(this.labelAbout_BVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout_BVV;
        private System.Windows.Forms.Button buttonAbout_BVV;
    }
}