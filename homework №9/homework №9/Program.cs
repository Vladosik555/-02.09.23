using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу печенья");
            double pricecookie = Convert.ToDouble(Console.ReadLine());//конвертируем
            double cookie = 200 * pricecookie;//цена печенья
            Console.WriteLine("Введите массу конфет");
            double pricecandies = Convert.ToDouble(Console.ReadLine());//конвертируем
            double candies = 310 * pricecandies;//цена конфет 
            Console.WriteLine("Введите массу яблок");
            double priceapple = Convert.ToDouble(Console.ReadLine());//конвертируем
            double apple = 125 * priceapple;//цена яблок
            Console.WriteLine(cookie + candies + apple);//складываем все цены
            Console.ReadKey();  
            
            

        }
    }
}
