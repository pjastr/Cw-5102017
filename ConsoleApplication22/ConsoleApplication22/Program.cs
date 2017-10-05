using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prawda = true;
            int zmienna = 5;
            Console.WriteLine(prawda);
            Console.WriteLine(!prawda);
            Console.WriteLine(true & false);
            Console.WriteLine(true | false);
            Console.WriteLine(5 < 2);
            Console.WriteLine(5 > 2);
            Console.WriteLine(zmienna == 2);
            Console.WriteLine(zmienna = 2);
            Console.WriteLine(5 != 2);
            Console.ReadKey();
        }
    }
}
