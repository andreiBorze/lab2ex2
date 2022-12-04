using System;

namespace lab2ex2
{
    /* Ex 2: Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va afisa factorialul unui numar n, n fiind citit de la tastatura. \n");

            long nr;
            Console.WriteLine("Introduceti un numar:");
            bool success = long.TryParse(Console.ReadLine(), out nr);

            if (success)
            {
                Console.WriteLine("Factorial: " + getFactorial(nr));
            }
            else
            {
                Console.WriteLine(" Atentie! Ai introdus si litere!");
            }
        }

        private static long getFactorial(long nr)
        {
            var fac = 1;

           for(var i = 1; i <= nr; i++)
           {
                fac = fac * i;
           }

            return fac;
        }
    }
}
