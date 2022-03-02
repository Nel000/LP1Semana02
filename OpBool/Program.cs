using System;

namespace OpBool
{
    class Program
    {
        static void Main(string[] args)
        {
            float f1 = 1.4f;
            float f2 = -13.7f;
            bool b1 = true;
            bool b2 = false;
            bool x = true;

            // 1)
            // x = true && false;
            // x = false

            // 2)
            // x = !true || false;
            // x = false

            // 3)
            // x = true ^b2;
            // x = true

            // 4)
            // x &= f2 < f1;
            // x = true

            // 5)
            // x ^= !(f2 != f1);
            // x = true

            // 6)
            // x |= !true ^ b1;
            // x = 

            // 7)
            x = b1 && b2 && !(f1 >= f2);
            // x = 

            // 8)
            // x &= b1 ^ b2 ^ (f1 == f2);
            // x = 

            // 9)
            // x ^= !(b1 || b2);
            // x = 
            
            Console.WriteLine(x);
        }
    }
}
