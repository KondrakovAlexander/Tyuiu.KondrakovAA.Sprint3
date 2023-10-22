using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KondrakovAA.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string str)
        {
            char resp = '1';
            foreach (char c in str) {
                if (char.IsDigit(c))
                {
                    resp = c;
                }
            }
            return (int) Char.GetNumericValue(resp);
        }
    }
}
