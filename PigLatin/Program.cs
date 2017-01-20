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




            Console.WriteLine("what is your favorite animal");
            string favoriteAnimal = Console.ReadLine();

            char One = favoriteAnimal[0];
            char Two = favoriteAnimal[1];
            char three = favoriteAnimal[2];

            List<char> consanents = new List<char>
            {
                'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z',
            };

            List<string> vowels = new List<string>
            {
                "a", "e", "i", "o", "u", "y"
            };

            if (consanents.Contains(One) && consanents.Contains(Two))                      
            {
                string newFavoriteAnimal = favoriteAnimal.Remove(0, 1) + One + Two + "ay";
                Console.WriteLine(newFavoriteAnimal);
                Console.ReadLine();
            }

        }
    }
}


/*
  {
            Console.WriteLine("Do you like Cats or Dogs?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("what color is your house?");
            string houseColor = Console.ReadLine();

            Console.WriteLine("Becuase you have a love for " +
                              favoriteAnimal +
                              ", then of course your house would be the color "
                              + houseColor +
                              "!");

            Console.WriteLine("Now, time for a test:");
            Console.Write("What is Greenville's three digit area code? ");
            int areaCode = int.Parse(Console.ReadLine());

            if (areaCode == 864)
            {
                if (favoriteAnimal == "Cats" || favoriteAnimal == "cats")
                {
                    char firstLetter = favoriteAnimal.ToLower()[0];
                    char secondLetter = favoriteAnimal[1];
                    char thirdLetter = favoriteAnimal[2];
                    char fourthLetter = favoriteAnimal[3];
                    string one = "I'm so glad you like";

                    Console.WriteLine($" {one} {secondLetter}{thirdLetter}{fourthLetter}{firstLetter}ay!");               
                }

                else if (favoriteAnimal == "Dogs" || favoriteAnimal == "dogs")
                {
                    char firstLetter = favoriteAnimal.ToLower()[0];
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
 */
