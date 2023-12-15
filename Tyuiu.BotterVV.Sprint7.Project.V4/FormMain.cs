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
using Tyuiu.BotterVV.Sprint7.Project.V4.Lib;

namespace Tyuiu.BotterVV.Sprint7.Project.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public string databaseopenpath;
        DataService ds = new DataService();

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
                panelDataBase_BVV.Visible = true;
                panelDataBase_BVV.Enabled = true;

                dataGridViewDataBase_BVV.DataSource = ds.dataBase(databaseopenpath);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: студент группы ПКТб-23-2, Боттер Вадим Валерьевич", "Сведения о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}