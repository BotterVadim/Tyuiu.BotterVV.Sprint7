﻿using System;
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
            dataGridViewDataBase_BVV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewDataBase_BVV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            radioButtonSaveBook_BVV.Enabled = true;
            radioButtonSaveBook_BVV.Checked = true;
            radioButtonSaveReaders_BVV.Enabled = false;
            radioButtonSaveReaders_BVV.Checked = false;

            if (resultdatabasebooks == DialogResult.OK)
            {
                panelDataBase_BVV.Dock = DockStyle.Fill;
                dataGridViewDataBase_BVV.DataSource = ds.dataBasebooks(databasebooksopenpath);
                panelDataBase_BVV.Enabled = true;
                panelDataBase_BVV.Visible = true;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
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

            dataGridViewDataBase_BVV.DataSource = ds.dataBase(databaseopenpath);
            radioButtonSaveReaders_BVV.Enabled = true;
            radioButtonSaveReaders_BVV.Checked = true;
            radioButtonSaveBook_BVV.Enabled = false;
            radioButtonSaveBook_BVV.Checked = false;

            if (resultdatabase == DialogResult.OK)
            {
                panelDataBase_BVV.Dock = DockStyle.Fill;
                dataGridViewDataBase_BVV.DataSource = ds.dataBase(databaseopenpath);
                panelDataBase_BVV.Enabled = true;
                panelDataBase_BVV.Visible = true;
            }
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.Enabled = true;
            formStatistics.ShowDialog();
        }

        private void buttonSearch_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_BVV.ToolTipTitle = "Поиск по файлу";
        }

        private void textBoxFilter_BVV_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = ds.dataBase(databaseopenpath).DefaultView;
            dataView.RowFilter = "Название LIKE '" + textBoxFilter_BVV.Text + "%'";
            dataGridViewDataBase_BVV.DataSource = dataView;
        }

        private void radioButtonSaveReaders_BVV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSaveReaders_BVV.Checked == true)
            {
                buttonSaveCSVReaders_BVV.Visible = true;
                buttonSaveCSVBooks_BVV.Visible = false;
            }
        }

        private void radioButtonSaveBook_BVV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSaveBook_BVV.Checked == true)
            {
                buttonSaveCSVBooks_BVV.Visible = true;
                buttonSaveCSVReaders_BVV.Visible = false;
            }
        }

        private void buttonSaveCSVReaders_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_BVV.ToolTipTitle = "Сохранить CSV файл";
        }

        private void buttonSaveCSVBooks_BVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_BVV.ToolTipTitle = "Сохранить CSV файл";
        }
    }
}