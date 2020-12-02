using System;
using System.Collections.Generic;
using System.Text;

namespace RachaelHomeworkWeek3
{
    class Cat
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

        public Cat(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AcceptablePetQuantity = (new Random()).Next(1, 21);
        }

        public string getCatName()
        {
            return $"{FirstName} {LastName}";
        }

        public int acceptedNumberOfPets()
        {
            var desiredPets = new Random();
            return desiredPets.Next(1, 21);
        }

        public void petTheCat()
        {
            int x = 0;
            bool enough = false;
            do
            {
                Console.WriteLine($"Would you like to pet {getCatName()}? (yes/no)");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    
                    if (x <= AcceptablePetQuantity)
                    {
                        Console.WriteLine($"{getCatName()} really seems to be enjoying that.");
                        x++;
                        Console.WriteLine($"You have pet {getCatName()} {x} times");
                    }
                    else if (x > AcceptablePetQuantity)
                    {
                        Console.WriteLine($"OH SHIT BRO, I don't think {getCatName()} likes that very much!!");
                        Console.WriteLine("*Your hand has been ripped to shreds and you're bleeding all over the carpet*");
                        Console.WriteLine("You might want to get that checked out...");
                        enough = true;
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
