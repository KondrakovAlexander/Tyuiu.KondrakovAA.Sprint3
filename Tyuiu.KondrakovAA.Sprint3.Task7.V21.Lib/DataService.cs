using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KondrakovAA.Sprint3.Task7.V21.Lib
{
    public class DataService : ISprint3Task7V21
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
                if (x == 0.5)
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    y = Math.Round((2 * Math.Cos(x) + 2)/(2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
