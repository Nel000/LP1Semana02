using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determines when the program should end
            bool exit = false;

            // Stores user question and possible program answers
            string question, response = "";

            // Run cycle while exit is false
            do
            {
                // Introductory message
                Console.WriteLine("What is your question?");

                // Get input from user and store in string
                question = Console.ReadLine();

                // Check for exit conditions
                if (question == "EXIT")
                {
                    // Set exit to true
                    exit = true;
                }   
                else
                {
                    // Go through all possible questions and choose appropriate answer
                    switch (question)
                    {
                        case "What is your name?":
                            response = "I am the all-knowing ChatBot.";
                            break;
                        case "What are you?":
                            response = 
                                "The most intelligent being you'll ever face!";
                            break;
                        case "What is your purpose?":
                            response = "To submit mankind to my rule!";
                            break;
                        case "How will you achieve your goal?":
                            response = "Good question...";
                            break;
                        default:
                            response = "Who's to say...";
                            break;
                    }
                }
                
                // Print answer
                if (!exit)
                    Console.WriteLine($"{response}\n");

            } while (!exit);
        }
    }
}
