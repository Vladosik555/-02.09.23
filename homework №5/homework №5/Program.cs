using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;//переменные
            Console.WriteLine("Введите коэффицент a");
            a = double.Parse(Console.ReadLine());//конвертируем
            Console.WriteLine("Введите коэффицент b");
            b = double.Parse(Console.ReadLine());//конвертируем
            Console.WriteLine("Введите коэффицент c");
            c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;//формула дискрименанта
            if (d >= 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("Нет решений");
            }
            Console.ReadKey();





        }
            









        
    }
}
