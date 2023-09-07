using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запишите значение х в радианах");
            double x , y ;//задаем переменные
            x = double. Parse(Console.ReadLine());//конвертируем строку
            y = Math.Cos(x);//записываем уравнение
            Console.WriteLine(y);//отображаем на экран ответ
            Console.ReadKey();  
        }
    }
}
