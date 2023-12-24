using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BotterVV.Sprint7.Project.V4.Lib;

namespace Tyuiu.BotterVV.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string pathbooks = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint7\Tyuiu.BotterVV.Sprint7.Project.V4\bin\Debug\Книги.csv";
        string pathreaders = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint7\Tyuiu.BotterVV.Sprint7.Project.V4\bin\Debug\Читатели.csv";
        public static string[,] LoadFromFileData(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line[c];
                }
            }

            return arrayValues;
        }

        [TestMethod]
        public void FileBooksCheckedExist()
        {
            string pathbooksout = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint7\Tyuiu.BotterVV.Sprint7.Project.V4\bin\Debug\OutPutКниги.csv";
            FileInfo fileInfo = new FileInfo(pathbooksout);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void FileReadersCheckedExist()
        {
            string pathreadersout = @"C:\Users\noph\source\repos\Tyuiu.BotterVV.Sprint7\Tyuiu.BotterVV.Sprint7.Project.V4\bin\Debug\OutPutЧитатели.csv";
            FileInfo fileInfo = new FileInfo(pathreadersout);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void MaxPriceCheck()
        {
            double wait = 299;
            double res = ds.MaxPrice(LoadFromFileData(pathbooks));
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void SrednPriceCheck()
        {
            double wait = 211;
            double res = ds.SrednPrice(LoadFromFileData(pathbooks));
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void MinYearBookCheck()
        {
            double wait = 1866;
            double res = ds.MinYearBook(LoadFromFileData(pathbooks));
            Assert.AreEqual(wait, res);
        }
    }
}
