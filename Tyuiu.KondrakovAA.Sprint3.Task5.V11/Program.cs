using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KondrakovAA.Sprint3.Task5.V11.Lib;

namespace Tyuiu.KondrakovAA.Sprint3.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Кондраков А. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Кондраков А.А | СМАРТб-23-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите начало первого ряда: ");
            int start1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец первого ряда: ");
            int end1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите начало второго ряда: ");
            int start2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец второго ряда: ");
            int end2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(start1, start2, end1, end2, x));
            Console.ReadKey();
        }
    }
}
