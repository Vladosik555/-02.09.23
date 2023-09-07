using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            for (int i = 0; i < 4; i++) {//берем 4 числа
                Console.WriteLine(rand.Next(-1000, 1001));}//задаем промежуток
            Console.ReadKey();

        }
    }
}
