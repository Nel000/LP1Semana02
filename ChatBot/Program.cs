using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determines when the program should end
            bool exit;

            // Stores user question and possible program answers
            string question, answer;

            // Run cycle while exit is false
            do
            {
                switch (question)
                {
                    case "EXIT":
                        exit = true;
                        break;
                    case "What is your name?":

                        break;
                    case "What are you?":

                        break;
                    case "What is your purpose?":

                        break;
                    case "How will you achieve your goal?":

                        break;
                }
            } while (!exit);
        }
    }
}
