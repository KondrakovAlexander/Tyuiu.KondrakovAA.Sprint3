using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KondrakovAA.Sprint3.Task0.V27.Lib
{
    public class DataService : ISprint3Task0V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            int i;

            double sumSeries = 0;

            for (i = startValue; i <= stopValue; i++)
            {

                sumSeries = sumSeries + Math.Pow(4 / (Math.Pow(i, 5)), 2);
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
