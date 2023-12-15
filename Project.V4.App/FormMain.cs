using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project.V4.Lib;

namespace Project.V4.App
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public string databaseopenpath;
        DataService ds = new DataService(); 
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: студент группы ПКТб-23-2, Боттер Вадим Валерьевич", "Сведения о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void открытьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog databaseopen = new OpenFileDialog();
            databaseopen.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";
            DialogResult resultdatabase = databaseopen.ShowDialog();
            databaseopenpath = databaseopen.FileName;

            if (resultdatabase == DialogResult.OK)
            {
                panelFind_BVV.Visible = true;
                panelFind_BVV.Enabled = true;

                dataGridViewDataBase_BVV.DataSource = ds.dataBase(databaseopenpath);
            }
        }
    }
}
