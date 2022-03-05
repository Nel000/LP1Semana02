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
                    // Draw pyramid
                    for (int i = 1; i <= lines; i++)
                    {
                        // Print spaces before asterisks
                        for (int j = lines; j >= 1; j-- )
                            Console.Write(" ");
                        // Print asterisks
                        for (int k = 1; k <= i; k++)
                            Console.Write("*");

                        // Go to new line
                        Console.Write("\n");
                        lines--;
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
