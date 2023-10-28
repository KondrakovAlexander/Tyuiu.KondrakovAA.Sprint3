using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KondrakovAA.Sprint3.Task4.V18.Lib
{
    public class DataService : ISprint3Task4V18
    {
        public double Calculate(int start, int stop)
        {
            double y = 0;
            for (int x = start; x <= stop; x++){
                if (x == 0) 
                {
                    break;
                }
                y += Math.Tan(x);
            }
            return y;
        }
    }
}
