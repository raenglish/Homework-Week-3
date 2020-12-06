using System;

namespace RachaelHomeworkWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Cat's first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your cat's last name?");
            string lastName = Console.ReadLine();
            Cat yourCat = new Cat(firstName, lastName);
            Console.WriteLine($"I hope you know how many pets {yourCat.getCatName()} enjoys! Let's play a game!");
            bool isFinishedPlaying = false;
            while(!isFinishedPlaying)
            {
                yourCat.petTheCat();
                Console.WriteLine("Would you like to play again? (yes/no)");
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput == "yes")
                {
                    yourCat = new Cat(firstName, lastName);
                } else
                {
                    isFinishedPlaying = true;
                }
            }
            
            Console.ReadLine();
        }
    }
}
