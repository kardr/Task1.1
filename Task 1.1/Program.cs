using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double S;
            Console.WriteLine("Введите первый член прогресии b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель q:");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число членов прогресии a:");
            int a = Convert.ToInt32(Console.ReadLine());

            S = (b * (Math.Pow(q, a) - b)) / (q - b);
            Console.WriteLine("Сумма членов геометрической прогресии: " + S);
            Console.ReadKey();
        }
    }
}
