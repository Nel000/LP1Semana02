using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2, c, d;

            // Increments 'a' and 'b', only updates after operation
            // a = 5 + 1; b = 2 + 1; c = 5 + 2
            c = a++ + b++;
            Console.WriteLine(c);

            // Decrements 'a' and 'b' before operation 
            // a = 6 - 1; b = 3 - 1; c = 5 + 2
            d = --a + --b;
            Console.WriteLine(d);
        }
    }
}
