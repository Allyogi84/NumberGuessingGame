using System;

namespace NumberGuessingGame
{
    public class Program
    {
        private const int V = 100;

        public static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, V);
            bool win = false;

            do
            {
                Console.Write("Guess a number in between 0 and 100: ");
                String s = Console.ReadLine();
                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too high! Guess lower...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too Low! Guess higher...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to finish");
            Console.ReadKey(true)
        }
    }
}