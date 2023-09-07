using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание номер 6. Пункт А");
            int a = 1, b = 2, c = 3, d;
            d = b;
            b = c;
            c = d;
            Console.WriteLine("b присваивает значение c");
            Console.WriteLine(b);
            Console.WriteLine(c);
            a = 1;
            b = 2;
            c = 3;
            int e;
            e = a;
            a = b;
            b = e;
            Console.WriteLine("a присваивает значение b");
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = 1;
            b = 2;
            c = 3;
            int f;
            f = c;
            c = a;
            a = f;
            Console.WriteLine("c присваивает значение a");
            Console.WriteLine(c);
            Console.WriteLine(a);

            Console.WriteLine("Задание номер 6. Пункт Б");
            Console.WriteLine("");
            a = 1;
            b = 2;
            c = 3;
            int g;
            g = b;
            b = a;
            a = g;
            Console.WriteLine("b присваивает значение a");
            Console.WriteLine(b);
            Console.WriteLine(a);
            a = 1;
            b = 2;
            c = 3;
            int h;
            h = c;
            c = b;
            b = h;
            Console.WriteLine("c присваивает значение b");
            Console.WriteLine(c);
            Console.WriteLine(b);
            a = 1;
            b = 2;
            c = 3;
            int i;
            i = c;
            c = a;
            a = i;
            Console.WriteLine("a присваивает значание c");
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
