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

            // Auxiliary variables
            int i, j, k;

            // Introductory message
            Console.WriteLine("Insert a number of lines for a triangle");
            
            // Run program while exit conditions are not met
            do
            {
                // Get input from user and convert to INT
                sLines = Console.ReadLine();
                lines = Convert.ToInt32(sLines);
            
                // Execute rest of program if lines are equal or bigger than 2
                if (lines >= 2)
                {
                    // Draw pyramid
                    for (i = 1; i <= lines; i++)
                    {
                        // Print spaces before asterisks
                        for (j = 1; j <= lines - i; j++)
                            Console.Write(" ");
                        // Print asterisks
                        for (k = 1; k <= 2 * i - 1; k++)
                            Console.Write("*");

                        // Go to new line
                        Console.WriteLine();
                    }

                    // End program
                    exit = true;
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
