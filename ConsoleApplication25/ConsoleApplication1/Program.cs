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
            Console.WriteLine("Podaj oznaczenie temperatury, K-Kelvin, C-Celsjusz, F-Fahrenheit");
            ConsoleKeyInfo klawisz = Console.ReadKey();
            char znak = klawisz.KeyChar;
            Console.WriteLine(Environment.NewLine+"Podaj wartość liczbą temperatury");
            double wartosc = Convert.ToDouble(Console.ReadLine());
            if (znak == 'K')
            {
                Console.WriteLine("Temp w C = {0}", wartosc-273.15);
                Console.WriteLine("Temp w F = {0}", 9*(wartosc - 273.15)/5+32);
            }
            else if (znak == 'C')
            {
                Console.WriteLine("Celsjusz");
            }
            else if (znak == 'F')
            {
                Console.WriteLine("Fahrenheit");
            }

            Console.ReadKey();
        }
    }
}
