using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Tyuiu.BotterVV.Sprint7.Project.V4.Lib
{
    public class DataService
    {
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
            datevidachabook = new DataColumn("Дата выдачи книги читателю", typeof(Int32));
            DataColumn datesdachabook;
            datesdachabook = new DataColumn("Дата сдачи книги читателем", typeof(Int32));

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
                        row["Дата выдачи книги читателю"] = Double.Parse(chitValues[4]);
                        row["Дата сдачи книги читателем"] = Double.Parse(chitValues[5]);
                        database.Rows.Add(row);
                    }
                }
            }
            catch
            {

            }
            return database;
        }

        public double MaxPrice(string[,] path)
        {
            double maxprice = 0;
            for (int i = 0; i < path.GetLength(0); i++)
            {
                if (Convert.ToDouble(path[i, 3]) > maxprice)
                {
                    maxprice = Convert.ToDouble(path[i, 3]);
                }
            }
            return maxprice;
        }

        public double SrednPrice(string[,] path)
        {
            double price = 0;
            for (int i = 0; i < path.GetLength(0); i++)
            {
                price += Convert.ToDouble(path[i, 3]);
            }
            double srednprice = price / (path.GetLength(0));
            return srednprice;
        }

        public int MinYearBook(string[,] path)
        {
            int minyear = 100000000;
            for (int i = 0; i < path.GetLength(0); i++)
            {
                if (Convert.ToInt32(path[i, 2]) < minyear)
                {
                    minyear = Convert.ToInt32(path[i, 2]);
                }
            }
            return minyear;
        }
    }
}
