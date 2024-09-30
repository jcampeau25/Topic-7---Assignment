using System.Diagnostics;

namespace Topic_7___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool play;
            int points = 3;
            string start;


            Console.WriteLine("Welcome to Josh's Dice Game");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("We will flip a coin. If you guess what the coin will land on, you will get a point");
            Console.WriteLine("but if you guess incorrectly you will lose a point.");
            Console.WriteLine("When you are done playing you can quit by entering q or quit instead of making a guess");
            Console.WriteLine("Would you like to play the dice game? If so, please type yes");
            start = Console.ReadLine();

            if (start.ToLower() == "yes")
            {

                start = Console.ReadLine();
                if (start.ToLower() == "yes")
                    play = true;
              

            }
            else
                play = false;
            Console.WriteLine("Ok, have a good day!");
            
            {

            }
;
               
        }
    }
}
