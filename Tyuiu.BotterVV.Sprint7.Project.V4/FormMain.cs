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
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

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
            dataGridViewDataBaseReaders_BVV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewDataBaseReaders_BVV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDataBaseReaders_BVV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public string databaseopenpath;
        public string databasebooksopenpath;
        DataService ds = new DataService();

        public DataTable dataBasebooks(string pathbooks)
        {
            DataTable bookdatabase = new DataTable("Библиотека");

            DataColumn author;
            author = new DataColumn("Автор", typeof(String));
            DataColumn bookname;
            bookname = new DataColumn("Название", typeof(String));
            DataColumn yearbook;
            yearbook = new DataColumn("Год издания", typeof(Int32));
            DataColumn bookprice;
            bookprice = new DataColumn("Цена", typeof(Double));
            DataColumn newedition;
            newedition = new DataColumn("Новое издание", typeof(String));
            DataColumn shortannotation;
            shortannotation = new DataColumn("Краткая аннотация", typeof(String));

            bookdatabase.Columns.AddRange(new DataColumn[] { author, bookname, yearbook, bookprice, newedition, shortannotation });

            try
            {
                DataRow row = null;
                string[] bookValues = null;
                string[] book = File.ReadAllLines(pathbooks, Encoding.Default);
                for (int i = 0; i < book.Length; i++)
                {
                    if (!String.IsNullOrEmpty(book[i]))
                    {
                        bookValues = book[i].Split(';');
                        row = bookdatabase.NewRow();
                        row["Автор"] = bookValues[0];
                        row["Название"] = bookValues[1];
                        row["Год издания"] = int.Parse(bookValues[2]);
                        row["Цена"] = int.Parse(bookValues[3]);
                        row["Новое издание"] = bookValues[4];
                        row["Краткая аннотация"] = bookValues[5];
                        bookdatabase.Rows.Add(row);
                    }
                }
            }
            catch
            {
            }
            return bookdatabase;
        }

        public DataTable dataBase(string path)
        {
            DataTable database = new DataTable("Читательские билеты");

            DataColumn numberbileta;
            numberbileta = new DataColumn("Номер читательского билета", typeof(Int32));
            DataColumn fiochitatel;
            fiochitatel = new DataColumn("ФИО", typeof(String));
            DataColumn address;
            address = new DataColumn("Адрес читателя", typeof(String));
            DataColumn phonenumber;
            phonenumber = new DataColumn("Телефон читателя", typeof(Int64));
            DataColumn datevidachabook;
            datevidachabook = new DataColumn("Дата выдачи книги читателю", typeof(DateTime));
            DataColumn datesdachabook;
            datesdachabook = new DataColumn("Дата сдачи книги читателем", typeof(DateTime));

            database.Columns.AddRange(new DataColumn[] { numberbileta, fiochitatel, address, phonenumber, datevidachabook, datesdachabook });

            try
            {
                DataRow row = null;
                string[] chitValues = null;
                string[] chit = File.ReadAllLines(path, Encoding.Default);
                for (int i = 0; i < chit.Length; i++)
                {
                    if (!String.IsNullOrEmpty(chit[i]))
                    {
                        chitValues = chit[i].Split(';');
                        row = database.NewRow();
                        row["Номер читательского билета"] = int.Parse(chitValues[0]);
                        row["ФИО"] = chitValues[1];
                        row["Адрес читателя"] = chitValues[2];
                        row["Телефон читателя"] = int.Parse(chitValues[3]);
                        row["Дата выдачи книги читателю"] = DateTime.Parse(chitValues[4]);
                        row["Дата сдачи книги читателем"] = DateTime.Parse(chitValues[5]);
                        database.Rows.Add(row);
                    }
                }
            }
            catch
            {
            }
            return database;
        }

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
            buttonSortUbyvanie_BVV.Visible = true;
            buttonSortVozrast_BVV.Visible = true;

            if (resultdatabasebooks == DialogResult.OK)
            {
                panelDataBase_BVV.Dock = DockStyle.Fill;
                dataGridViewDataBase_BVV.DataSource = dataBasebooks(databasebooksopenpath);
                panelDataBase_BVV.Enabled = true;
                panelDataBase_BVV.Visible = true;
                dataGridViewDataBaseReaders_BVV.Enabled = false;
                dataGridViewDataBaseReaders_BVV.Visible = false;
                dataGridViewDataBase_BVV.Enabled = true;
                dataGridViewDataBase_BVV.Visible = true;
                dataGridViewDataBase_BVV.Rows[0].Cells[0].Selected = false;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void открытьБазуДанныхЧитателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog databaseopen = new OpenFileDialog();
            databaseopen.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";
            databaseopen.Title = "Открыть базу данных читателей";
            DialogResult resultdatabase = databaseopen.ShowDialog();
            databaseopenpath = databaseopen.FileName;

            radioButtonSaveReaders_BVV.Enabled = true;
            radioButtonSaveReaders_BVV.Checked = true;
            radioButtonSaveBook_BVV.Enabled = false;
            radioButtonSaveBook_BVV.Checked = false;
            labelFilter_BVV.Visible = true;
            comboBoxFilterReaders_BVV.Visible = true;
            comboBoxFilterBooks_BVV.Visible = false;
            buttonSortUbyvanie_BVV.Visible = true;
            buttonSortVozrast_BVV.Visible = true;

            if (resultdatabase == DialogResult.OK)
            {
                panelDataBase_BVV.Dock = DockStyle.Fill;
                dataGridViewDataBaseReaders_BVV.DataSource = dataBase(databaseopenpath);
                panelDataBase_BVV.Enabled = true;
                panelDataBase_BVV.Visible = true;
                dataGridViewDataBase_BVV.Enabled = false;
                dataGridViewDataBase_BVV.Visible = false;
                dataGridViewDataBaseReaders_BVV.Enabled = true;
                dataGridViewDataBaseReaders_BVV.Visible = true;
                dataGridViewDataBaseReaders_BVV.Rows[0].Cells[0].Selected = false;
            }
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.Enabled = true;
            formStatistics.ShowDialog();
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

            int rows = dataGridViewDataBaseReaders_BVV.RowCount;
            int columns = dataGridViewDataBaseReaders_BVV.ColumnCount;

            string strreaders = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns)
                    {
                        strreaders = strreaders + dataGridViewDataBaseReaders_BVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        strreaders = strreaders + dataGridViewDataBaseReaders_BVV.Rows[i].Cells[j].Value;                    
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

        private void textBoxSearch_BVV_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewDataBase_BVV.Enabled == true)
            {

                string searchValue = textBoxSearch_BVV.Text.ToLower();

                dataGridViewDataBase_BVV.CurrentCell = null;
                foreach (DataGridViewRow row in dataGridViewDataBase_BVV.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool found = false;

                    for (int j = 0; j < dataGridViewDataBase_BVV.Columns.Count; j++)
                    {
                        if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                        {
                            found = true;
                            break;
                        }
                    }

                    row.Visible = found;
                }
            }
            if (dataGridViewDataBaseReaders_BVV.Enabled == true)
            {
                string searchValue = textBoxSearch_BVV.Text.ToLower();

                dataGridViewDataBaseReaders_BVV.CurrentCell = null;
                foreach (DataGridViewRow row in dataGridViewDataBaseReaders_BVV.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool found = false;

                    for (int j = 0; j < dataGridViewDataBaseReaders_BVV.Columns.Count; j++)
                    {
                        if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                        {
                            found = true;
                            break;
                        }
                    }

                    row.Visible = found;
                }
            }
        }

        BindingSource bindingSourceBooks = new BindingSource();
        BindingSource bindingSourceReaders = new BindingSource();
        private void textBoxFilterSearch_BVV_TextChanged(object sender, EventArgs e)
        {
            bindingSourceReaders.DataSource = dataBase(databaseopenpath);
            bindingSourceBooks.DataSource = dataBasebooks(databasebooksopenpath);
            dataGridViewDataBase_BVV.DataSource = bindingSourceBooks;
            dataGridViewDataBaseReaders_BVV.DataSource = bindingSourceReaders;

            if (comboBoxFilterBooks_BVV.Text == "Автор")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Автор...")
                {
                    bindingSourceBooks.Filter = string.Format("[{0}] LIKE '%{1}%'", "Автор", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBase_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBase_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBase_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBase_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBase_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBase_BVV.Columns[0].Selected = true;
            }
            if (comboBoxFilterBooks_BVV.Text == "Название")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Название...")
                {
                    bindingSourceBooks.Filter = string.Format("[{0}] LIKE '%{1}%'", "Название", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBase_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBase_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBase_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBase_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBase_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBase_BVV.Columns[1].Selected = true;
            }
            if (comboBoxFilterBooks_BVV.Text == "Год издания")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Год издания...")
                {
                    bindingSourceBooks.Filter = string.Format("convert([Год издания], 'System.String') Like '%{0}%' ", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBase_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBase_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBase_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBase_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBase_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBase_BVV.Columns[2].Selected = true;
            }
        
            if (comboBoxFilterBooks_BVV.Text == "Цена")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Цена...")
                {
                    bindingSourceBooks.Filter = string.Format("convert([Цена], 'System.String') Like '%{0}%' ", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBase_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBase_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBase_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBase_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBase_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBase_BVV.Columns[3].Selected = true;
            }
            if (comboBoxFilterBooks_BVV.Text == "Новое издание")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Новое издание...")
                {
                    bindingSourceBooks.Filter = string.Format("[{0}] LIKE '%{1}%'", "Новое издание", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBase_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBase_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBase_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBase_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBase_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBase_BVV.Columns[4].Selected = true;
            }

            if (comboBoxFilterBooks_BVV.Text == "Краткая аннотация")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Краткая аннотация...")
                {
                    bindingSourceBooks.Filter = string.Format("[{0}] LIKE '%{1}%'", "Краткая аннотация", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBase_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBase_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBase_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBase_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBase_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBase_BVV.Columns[5].Selected = true;
            }

            if (comboBoxFilterReaders_BVV.Text == "Номер читательского билета")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Номер читательского билета...")
                {
                    bindingSourceReaders.Filter = string.Format("convert([Номер читательского билета], 'System.String') Like '%{0}%' ", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBaseReaders_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBaseReaders_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBaseReaders_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBaseReaders_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBaseReaders_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBaseReaders_BVV.Columns[0].Selected = true;
            }
            if (comboBoxFilterReaders_BVV.Text == "ФИО")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: ФИО...")
                {
                    bindingSourceReaders.Filter = string.Format("[{0}] LIKE '%{1}%'", "ФИО", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBaseReaders_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBaseReaders_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBaseReaders_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBaseReaders_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBaseReaders_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBaseReaders_BVV.Columns[1].Selected = true;
            }
            if (comboBoxFilterReaders_BVV.Text == "Адрес читателя")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Адрес читателя...")
                {
                    bindingSourceReaders.Filter = string.Format("[{0}] LIKE '%{1}%'", "Адрес читателя", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBaseReaders_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBaseReaders_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBaseReaders_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBaseReaders_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBaseReaders_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBaseReaders_BVV.Columns[2].Selected = true;
            }
            if (comboBoxFilterReaders_BVV.Text == "Телефон читателя")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Телефон читателя...")
                {
                    bindingSourceReaders.Filter = string.Format("convert([Телефон читателя], 'System.String') Like '%{0}%' ", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBaseReaders_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBaseReaders_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBaseReaders_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBaseReaders_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBaseReaders_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBaseReaders_BVV.Columns[3].Selected = true;
            }
            if (comboBoxFilterReaders_BVV.Text == "Дата выдачи книги читателю")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Дата выдачи книги читателю...")
                {
                    bindingSourceReaders.Filter = string.Format("convert([Дата выдачи книги читателю],'System.String') Like '%{0}%'", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBaseReaders_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBaseReaders_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBaseReaders_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBaseReaders_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBaseReaders_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBaseReaders_BVV.Columns[4].Selected = true;
            }

            if (comboBoxFilterReaders_BVV.Text == "Дата сдачи книги читателем")
            {
                if (textBoxFilterSearch_BVV.Text != "Поиск по столбцу: Дата сдачи книги читателем...")
                {
                    bindingSourceReaders.Filter = string.Format("convert([Дата сдачи книги читателем],'System.String') Like '%{0}%'", textBoxFilterSearch_BVV.Text);
                }
                foreach (DataGridViewColumn c in dataGridViewDataBaseReaders_BVV.Columns)
                {
                    for (int i = 0; i < dataGridViewDataBaseReaders_BVV.ColumnCount; i++)
                    {
                        for (int j = 0; j < dataGridViewDataBaseReaders_BVV.RowCount; j++)
                        {
                            if (dataGridViewDataBaseReaders_BVV[i, j].Value != null)
                            {
                                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                                c.Selected = false;
                            }
                        }
                    }
                }
                dataGridViewDataBaseReaders_BVV.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                dataGridViewDataBaseReaders_BVV.Columns[5].Selected = true;
            }
        }

        private void buttonSortVozrast_BVV_Click(object sender, EventArgs e)
        {
            if (comboBoxFilterBooks_BVV.Text == "Автор")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[0], ListSortDirection.Ascending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Название")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[1], ListSortDirection.Ascending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Год издания")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[2], ListSortDirection.Ascending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Цена")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[3], ListSortDirection.Ascending);
            }  
            if (comboBoxFilterBooks_BVV.Text == "Новое издание")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[4], ListSortDirection.Ascending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Краткая аннотация")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[5], ListSortDirection.Ascending);
            }  
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBoxFilterReaders_BVV.Text == "Номер читательского билета")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[0], ListSortDirection.Ascending);
            }
            if (comboBoxFilterReaders_BVV.Text == "ФИО")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[1], ListSortDirection.Ascending);
            }
            if (comboBoxFilterReaders_BVV.Text == "Адрес читателя")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[2], ListSortDirection.Ascending);
            }
            if (comboBoxFilterReaders_BVV.Text == "Телефон читателя")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[3], ListSortDirection.Ascending);
            }
            if (comboBoxFilterReaders_BVV.Text == "Дата выдачи книги читателю")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[4], ListSortDirection.Ascending);
            }
            if (comboBoxFilterReaders_BVV.Text == "Дата сдачи книги читателем")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[5], ListSortDirection.Ascending);
            }
        }

        private void buttonSortUbyvanie_BVV_Click(object sender, EventArgs e)
        {
            if (comboBoxFilterBooks_BVV.Text == "Автор")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[0], ListSortDirection.Descending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Название")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[1], ListSortDirection.Descending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Год издания")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[2], ListSortDirection.Descending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Цена")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[3], ListSortDirection.Descending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Новое издание")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[4], ListSortDirection.Descending);
            }
            if (comboBoxFilterBooks_BVV.Text == "Краткая аннотация")
            {
                dataGridViewDataBase_BVV.Sort(dataGridViewDataBase_BVV.Columns[5], ListSortDirection.Descending);
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBoxFilterReaders_BVV.Text == "Номер читательского билета")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[0], ListSortDirection.Descending);
            }
            if (comboBoxFilterReaders_BVV.Text == "ФИО")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[1], ListSortDirection.Descending);
            }
            if (comboBoxFilterReaders_BVV.Text == "Адрес читателя")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[2], ListSortDirection.Descending);
            }
            if (comboBoxFilterReaders_BVV.Text == "Телефон читателя")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[3], ListSortDirection.Descending);
            }
            if (comboBoxFilterReaders_BVV.Text == "Дата выдачи книги читателю")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[4], ListSortDirection.Descending);
            }
            if (comboBoxFilterReaders_BVV.Text == "Дата сдачи книги читателем")
            {
                dataGridViewDataBaseReaders_BVV.Sort(dataGridViewDataBaseReaders_BVV.Columns[5], ListSortDirection.Descending);
            }
        }
    }
}