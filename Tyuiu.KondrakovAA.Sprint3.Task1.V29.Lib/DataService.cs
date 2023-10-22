using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KondrakovAA.Sprint3.Task1.V29.Lib
{
    public class DataService : ISprint3Task1V29
    {
        public double GetMultiplySeries(double x, int start, int stop)
        {
            double series = 1;

            while (start <= stop)
            {
                series = series * ((Math.Pow(x, 2) * start) + 2);
                start += 1;
            }

            return series;
        }
    }
}
