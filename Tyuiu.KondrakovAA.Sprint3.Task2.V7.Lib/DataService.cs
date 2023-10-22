using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KondrakovAA.Sprint3.Task2.V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
    public double GetSumSeries(int start, int stop)
        {
            double series = 0;
            do
            {
                series = series + Math.Pow((1/(Math.Sin(start))), 2);
                start += 1;
            } while (start <= stop);
            return series;
        }
    }
}
