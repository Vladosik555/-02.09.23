using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c;
            Console.WriteLine("Введите первое число");
            string numberone = Console.ReadLine();//вводим на экран первое число
            Console.WriteLine("Введите второе число");
            string numbertwo = Console.ReadLine();//вводим на экран второе число
            bool a = double.TryParse(numberone, out _);//проверяем, можно ли перевести первое число
            bool b = double.TryParse(numbertwo, out _);//проверяем можно ли перевести второе число
            c = numberone;
            numberone = numbertwo;
            numbertwo = c;//поменяли значения чисел
            if (a && b)//если две переменные оказались числа, то код меняет числа местами
            {
                Console.WriteLine("Ответ  " + numberone);
                Console.WriteLine("       " + numbertwo);
            }
            else// если хоть одна переменная оказалась строкой, то код выдает ошибку
                Console.WriteLine("Нельзя вводить строки!!!");//ошибка
            Console.ReadKey();
        }
    }
}
