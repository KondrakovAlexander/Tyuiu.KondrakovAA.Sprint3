using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KondrakovAA.Sprint3.Review.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int start, int stop)
        {
            double[] valueArray;
            int len = (stop - start) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = start; x <= stop; x++)
            {
                y = Math.Round(Math.Cos(x) + (4 * x)/ 2 - Math.Sin(x) * (3 * x), 2);
                valueArray[count] = y;
                count++; 
            }
            return valueArray;
        }
    }
}
