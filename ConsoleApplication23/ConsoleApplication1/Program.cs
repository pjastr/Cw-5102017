using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            //int[] liczby = new int[3];
            //liczby[0] = a;
            //liczby[1] = b;
            //liczby[2] = c;

            //Console.WriteLine("\nNawjwiększa liczba to: {0}",liczby.Max());
            //Console.WriteLine("\nNajmniejsza liczba to: {0}", liczby.Min());

            Console.WriteLine("Max: {0}", Math.Max(Math.Max(a, b), c));
            Console.WriteLine("Min: {0}", Math.Min(Math.Min(a, b), c));
            Console.ReadKey();
        }
    }
}
