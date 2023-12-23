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
            saveFileDialog_BVV.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";
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
            databaseopenbooks.Title = "Открыть базу данных книг";
            DialogResult resultdatabasebooks = databaseopenbooks.ShowDialog();
            databasebooksopenpath = databaseopenbooks.FileName;
            radioButtonSaveBook_BVV.Enabled = true;
            radioButtonSaveBook_BVV.Checked = true;
            radioButtonSaveReaders_BVV.Enabled = false;
            radioButtonSaveReaders_BVV.Checked = false;
            labelFilter_BVV.Visible = true;
            comboBoxFilterReaders_BVV.Visible = false;
            comboBoxFilterBooks_BVV.Visible = true;

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
            databaseopen.Title = "Открыть базу данных читателей";
            DialogResult resultdatabase = databaseopen.ShowDialog();
            databaseopenpath = databaseopen.FileName;

            dataGridViewDataBase_BVV.DataSource = ds.dataBase(databaseopenpath);
            radioButtonSaveReaders_BVV.Enabled = true;
            radioButtonSaveReaders_BVV.Checked = true;
            radioButtonSaveBook_BVV.Enabled = false;
            radioButtonSaveBook_BVV.Checked = false;
            labelFilter_BVV.Visible = true;
            comboBoxFilterReaders_BVV.Visible = true;
            comboBoxFilterBooks_BVV.Visible = false;

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

        private void buttonSaveCSVReaders_BVV_Click(object sender, EventArgs e)
        {
            saveFileDialog_BVV.FileName = "OutPutЧитатели.csv";
            saveFileDialog_BVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_BVV.ShowDialog();

            string pathreaders = saveFileDialog_BVV.FileName;

            FileInfo fileInfo = new FileInfo(pathreaders);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathreaders);
            }

            int rows = dataGridViewDataBase_BVV.RowCount;
            int columns = dataGridViewDataBase_BVV.ColumnCount;

            string strreaders = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns)
                    {
                        strreaders = strreaders + dataGridViewDataBase_BVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        strreaders = strreaders + dataGridViewDataBase_BVV.Rows[i].Cells[j].Value;                    
                    }
                }
                File.AppendAllText(pathreaders, strreaders + Environment.NewLine, Encoding.Default);
                strreaders = "";
            }
        }

        private void buttonSaveCSVBooks_BVV_Click(object sender, EventArgs e)
        {
            saveFileDialog_BVV.FileName = "OutPutКниги.csv";
            saveFileDialog_BVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_BVV.ShowDialog();

            string pathbooks = saveFileDialog_BVV.FileName;

            FileInfo fileInfo = new FileInfo(pathbooks);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathbooks);
            }

            int rows = dataGridViewDataBase_BVV.RowCount;
            int columns = dataGridViewDataBase_BVV.ColumnCount;

            string strbooks = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns)
                    {
                        strbooks = strbooks + dataGridViewDataBase_BVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        strbooks = strbooks + dataGridViewDataBase_BVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(pathbooks, strbooks + Environment.NewLine, Encoding.Default);
                strbooks = "";
            }
        }

        private void comboBoxFilterBooks_BVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilterSearch_BVV.Text = "Поиск по столбцу: " + comboBoxFilterBooks_BVV.Text + "...";
            textBoxFilterSearch_BVV.ForeColor = Color.Gray;
        }

        private void textBoxFilterSearch_BVV_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFilterSearch_BVV.Text = "";
        }

        private void comboBoxFilterReaders_BVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilterSearch_BVV.Text = "Поиск по столбцу: " + comboBoxFilterReaders_BVV.Text + "...";
            textBoxFilterSearch_BVV.ForeColor = Color.Gray;
        }
    }
}   