using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print max and min values for multiple types
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(char.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // Print positive and negative infinity and NaN values for float and double types
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.PositiveInfinity / float.PositiveInfinity);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            // Overflow and underflow multiple integral types
            short sMax = short.MaxValue, sMin = short.MinValue;
            int iMax = int.MaxValue, iMin = int.MinValue;
            Console.WriteLine((short) (sMax + 1));
            Console.WriteLine((short) (sMin - 1));
            Console.WriteLine((int) (iMax + 1));
            Console.WriteLine((int) (iMin - 1));

            // Print result of overflow in real types
            float f1 = 2 * float.MaxValue, f2 = float.MaxValue + 1;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }
    }
}
