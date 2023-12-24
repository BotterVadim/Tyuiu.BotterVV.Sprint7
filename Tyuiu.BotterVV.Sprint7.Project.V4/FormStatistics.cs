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
using System.Data;
using Tyuiu.BotterVV.Sprint7.Project.V4.Lib;

namespace Tyuiu.BotterVV.Sprint7.Project.V4
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string chitpath = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint7\Tyuiu.BotterVV.Sprint7.Project.V4\bin\Debug\Читатели.csv";
        string bookspath = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint7\Tyuiu.BotterVV.Sprint7.Project.V4\bin\Debug\Книги.csv";

        public static string[,] LoadFromFileData(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayvalues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayvalues[r, c] = line[c];
                }
            }

            return arrayvalues;
        }

        private void buttonStatisticClose_BVV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMaxPrice_BVV_Click(object sender, EventArgs e)
        {
            string[,] databooks = LoadFromFileData(bookspath);
            textBoxMaxPrice_BVV.Text = Convert.ToString(ds.MaxPrice(databooks));
        }

        private void buttonSrednPrice_BVV_Click(object sender, EventArgs e)
        {
            string[,] databooks = LoadFromFileData(bookspath);
            textBoxSrednPrice_BVV.Text = Convert.ToString(ds.SrednPrice(databooks));
        }

        private void buttonClearMaxPrice_BVV_Click(object sender, EventArgs e)
        {
            textBoxMaxPrice_BVV.Text = "";
        }

        private void buttonClearSrednPrice_BVV_Click(object sender, EventArgs e)
        {
            textBoxSrednPrice_BVV.Text = "";
        }

        private void buttonMinYearBook_BVV_Click(object sender, EventArgs e)
        {
            string[,] databooks = LoadFromFileData(bookspath);
            textBoxMinYearBook_BVV.Text = Convert.ToString(ds.MinYearBook(databooks));
        }

        private void buttonClearMinYearBook_BVV_Click(object sender, EventArgs e)
        {
            textBoxMinYearBook_BVV.Text = "";
        }
    }
}
