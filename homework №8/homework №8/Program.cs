using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            char number = a[a.Length - 1];
            a = a.Remove(2);
            Console.WriteLine(number + a);
            Console.ReadKey();
        }
    }
}
