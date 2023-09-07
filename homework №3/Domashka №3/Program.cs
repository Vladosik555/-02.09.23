using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double radius = Convert.ToDouble(Console.ReadLine());//конвертируем стороку
            double length = 2 * 3.14 * radius;//находим длину окружности
            double square = 3.14 * radius * radius;//находим радиус окружности
            Console.WriteLine(length);//выводим на экран значение радиуса
            Console.WriteLine(square);//выводим на экран значение площади
            Console.ReadKey();
        }
    }
}
