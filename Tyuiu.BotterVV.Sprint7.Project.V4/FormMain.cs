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
        public string databasebooksopenpath;
        DataService ds = new DataService();

        private void открытьБазуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog databaseopenbooks = new OpenFileDialog();
            databaseopenbooks.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";
            DialogResult resultdatabasebooks = databaseopenbooks.ShowDialog();
            databasebooksopenpath = databaseopenbooks.FileName;

            if (resultdatabasebooks == DialogResult.OK)
            {
                dataGridViewDataBase_BVV.DataSource = ds.dataBasebooks(databasebooksopenpath);
                panelDataBase_BVV.Enabled = true;
                panelDataBase_BVV.Visible = true;

            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил: студент группы ПКТб-23-2, Боттер Вадим Валерьевич", "Сведения о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSearch_BVV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewDataBase_BVV.RowCount; i++)
            {
                dataGridViewDataBase_BVV.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewDataBase_BVV.ColumnCount; j++)
                {
                    if (dataGridViewDataBase_BVV.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridViewDataBase_BVV.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_BVV.Text))
                        {
                            dataGridViewDataBase_BVV.Rows[i].Cells[j].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void открытьБазуДанныхЧитателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog databaseopen = new OpenFileDialog();
            databaseopen.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";
            DialogResult resultdatabase = databaseopen.ShowDialog();
            databaseopenpath = databaseopen.FileName;

            if (resultdatabase == DialogResult.OK)
            {
                dataGridViewDataBase_BVV.DataSource = ds.dataBase(databaseopenpath);
                panelDataBase_BVV.Enabled = true;
                panelDataBase_BVV.Visible = true;
            }
        }
    }
}