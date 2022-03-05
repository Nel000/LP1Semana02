using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bool for exit condition
            bool exit = false;

            // Variables to store number of lines
            int lines;
            string sLines;

            // Introductory message
            Console.WriteLine("Insert a number of lines for a triangle");
            
            // Run program while exit conditions are not met
            do
            {
                // Get input from user and convert to INT
                sLines = Console.ReadLine();
                lines = int.Parse(sLines);
            
                // Execute rest of program if lines are equal or bigger than 2
                if (lines >= 2)
                {
                    
                }
                else
                {
                    // Request a number bigger than 1
                    Console.WriteLine("Please insert a number bigger that 1");
                }
            } while (!exit);
            
        }
    }
}
