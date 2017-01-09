using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you like Cats or Dogs?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("what color is your house?");
            string houseColor = Console.ReadLine();

            Console.WriteLine("Becuase you have a love for " +
                              favoriteAnimal +
                              " then of course your house would be the color "
                              + houseColor +
                              "!");

            Console.WriteLine("Now, time for a test:");
            Console.Write("What is Greenville's three digit area code? ");
            int areaCode = int.Parse(Console.ReadLine());

            if (areaCode == 864)
            {
                if (favoriteAnimal == "Cats")
                {
                    char firstLetter = favoriteAnimal[0];
                    char secondLetter = favoriteAnimal[1];
                    char thirdLetter = favoriteAnimal[2];
                    char fourthLetter = favoriteAnimal[3];

                    Console.WriteLine($"Im so glad you like {secondLetter}{thirdLetter}{fourthLetter}{firstLetter}ay!");
                }

                else if (favoriteAnimal == "Dogs")
                {
                    char firstLetter = favoriteAnimal[0];
                    char secondLetter = favoriteAnimal[1];
                    char thirdLetter = favoriteAnimal[2];
                    char fourthLetter = favoriteAnimal[3];

                    Console.WriteLine("" + $"{secondLetter}{thirdLetter}{fourthLetter}{firstLetter}ay, are way more hyper than cats");
                }

                else
                {
                    Console.WriteLine("you did not answer the first question orrectlycay!");
                }
            }
            else
            {
                Console.WriteLine("That is not GVL's area code");
            }

            Console.ReadLine();

        }
    }
}
