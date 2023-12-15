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
        public DataTable dataBase(string path)
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

            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string[] headers = reader.ReadLine().Split(';');
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] rows = reader.ReadLine().Split(';');
                    DataRow row = bookdatabase.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        row[i] = rows[i];
                    }
                    bookdatabase.Rows.Add(row);
                }

            }
            return bookdatabase;
        }
    }
}
