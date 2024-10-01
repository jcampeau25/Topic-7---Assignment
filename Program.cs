using System.Diagnostics;

namespace Topic_7___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            int points, coin;
            string start, guess;
            Random generator = new Random();
            play = true;
            points = 3;
            Console.WriteLine("Welcome to Josh's Dice Game");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("We will flip a coin. If you guess what the coin will land on, you will get a point");
            Console.WriteLine("but if you guess incorrectly you will lose a point.");
            Console.WriteLine("When you are done playing you can quit by entering q or quit instead of making a guess");

            while (play)
            {
;

                coin = generator.Next(2);
                Console.WriteLine();
                Console.WriteLine("You have " + points + " points");
                Console.WriteLine("Heads (H) or Tails (T) to guess or Quit(Q) to quit");
                guess = Console.ReadLine();
                if (guess.ToLower() == "quit" || guess.ToLower() == "q")
                    play = false;

                else if (coin == 0 && guess.ToLower() == "heads" || coin == 0 && guess.ToLower() == "h")
                {
                    Console.WriteLine("Correct!");
                    points += 1;
                }
                else if (coin == 1 && guess.ToLower() == "tails" || coin == 1 && guess.ToLower() == "t")
                {
                    Console.WriteLine("Correct!");
                    points += 1;
                }
                else
                {
                    Console.WriteLine("Sorry that is incorrect");
                    points -= 1;

                    if (points == 0)
                    {
                        Console.WriteLine("You are out of points! Game Over");
                        play = false;

                    }
                }
                }

            {
                Console.WriteLine("Thanks for playing");

            }
;
               
        }
    }
}
