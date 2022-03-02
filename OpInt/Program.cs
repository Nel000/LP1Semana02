using System;

namespace OpInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 3;
            int i2 = 1;
            int i3 = -8;
            int x = 2;
            
            // 1)
            // x = i1 - i3;
            // 3 - 1 = 2

            // 2)
            // x = i3 / i1;
            // -8 / 3 = -2.66666... = -2

            // 3)
            // x += i2;
            // x = 2 + 1 = 3

            // 4)
            // x *= i1;
            // x = 2 * 3 = 6

            // 5)
            x %= i2 - 0b1001;
            // x = 2 % 1 - 9 = 
            
            Console.WriteLine(x);
        }
    }
}
