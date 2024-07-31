using System;

namespace Fibonacci
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Serie Fibonacci del 1 al 50:");

            while (c <= 50)
            {
                Console.Write(c + " ");

                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
