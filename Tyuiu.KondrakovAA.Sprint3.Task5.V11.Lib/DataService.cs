using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KondrakovAA.Sprint3.Task5.V11.Lib
{
    public class DataService : ISprint3Task5V11
    {
        public double GetSumSumSeries(int start1, int start2, int stop1, int stop2, int x) 
        {
            double result = 0;
            for (int i = start1; i <= stop1; i++) 
            {
                for (int k = start2; k <= stop2; k++) 
                {
                    result += Math.Sin(k) + x / 2;
                }
            }
            return result;
        } 
    }
}
