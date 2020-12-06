using System;
using System.Collections.Generic;
using System.Text;

namespace RachaelHomeworkWeek3
{
    public class Cat
    {
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }

        public int AcceptablePetQuantity { get; set; }
        int x = 0;
        int catmood = 0;
        public Cat(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AcceptablePetQuantity = (new Random()).Next(1, 11);
        }

        public string getCatName()
        {
            return $"{FirstName} {LastName}";
        }

        public void getCatMood()
        {
            if (catmood + 1 >= AcceptablePetQuantity)
            {
                Console.WriteLine($"{getCatName()} is looking feisty");
            }
            else if (catmood < AcceptablePetQuantity)
            {
                Console.WriteLine($"{getCatName()} seems to want more attention");
            }
       
            
        }

        public void giveCatTreat()
        {
            Console.WriteLine($" you give {getCatName()} a treat. They seem to forgive you.");
            

        }
        /*public void restartGame()
        {

        }
        */
        public void petTheCat()
        {

            bool enough = false;
            do
            {
                Console.WriteLine($"Would you like to pet {getCatName()}? (yes/no)");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {

                    if (x <= AcceptablePetQuantity)
                    {
                        x++;
                        Console.WriteLine($"You have pet {getCatName()} {x} times");
                        getCatMood();
                        catmood++;
                    }
                    else if (x > AcceptablePetQuantity)
                    {
                        Console.WriteLine($"{getCatName()} is angry at you and slaps your hand away.");
                        Console.WriteLine("Would you like to give them a treat? (yes/no)");
                        if (Console.ReadLine() == "yes")
                        {
                            giveCatTreat();
                           /* Console.WriteLine("You have been forgiven. Would you like to go for another round of pets? (yes/no)");
                            string playAgainAnswer= Console.ReadLine();
                            restartGame();*/
                            enough = true;
                        }
                        else
                        {
                            Console.WriteLine("You must now endure a day of shunning.");
                            enough = true;
                        }
                    }

                }
                else if (answer == "no" && x == AcceptablePetQuantity)
                {
                    Console.WriteLine($"{getCatName()} seemed to really enjoy that. You're the best!");
                    enough = true;
                }
                else if (answer == "no" && x < AcceptablePetQuantity)
                {
                    Console.WriteLine($"{getCatName()} seems upset that you stopped petting them... maybe you should go apologize.");
                    enough = true;
                }

            }
            while (enough == false);
        }
    }

}
