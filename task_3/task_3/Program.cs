using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("Ведмідь прокинувся? Натисни 'y' якщо він ще спить, або натисни 'n' якщо він вже прокинувся.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "y")
                {
                    Console.WriteLine("──────▄▀▄─────▄▀▄");
                    Console.WriteLine("─────▄█░░▀▀▀▀▀░░█▄");
                    Console.WriteLine("─▄▄──█░░░░░░░░░░░█──▄▄");
                    Console.WriteLine("█▄▄█─█░░_░░┬░░_░░█─█▄▄█");

                }
                if (userInput.ToLower() == "n")

                {
                    Console.WriteLine("──────▄▀▄─────▄▀▄");
                    Console.WriteLine("─────▄█░░▀▀▀▀▀░░█▄");
                    Console.WriteLine("─▄▄──█░░░░░░░░░░░█──▄▄");
                    Console.WriteLine("█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█");
                }
                Console.WriteLine("Ти хочеш провірити знову? Натисни 'y' щоб продовжити, або будь яку іншу клавішу для виходу.");
                string playAgainInput = Console.ReadLine();
                Console.Clear();

                if (playAgainInput.ToLower() != "y")
                {
                    
                    break; 
                }
            }
        }
    }
}

