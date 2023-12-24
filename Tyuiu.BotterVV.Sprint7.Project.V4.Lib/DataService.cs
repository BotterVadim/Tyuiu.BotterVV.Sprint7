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
            int minyear = 10000000;
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
