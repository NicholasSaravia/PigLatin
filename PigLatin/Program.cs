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
                string newFavoriteAnimal = favoriteAnimal.Remove(0,2);
                string cat = newFavoriteAnimal + One + Two + "ay";
                Console.WriteLine(cat);
                Console.ReadLine();
            }

            else if (vowels.Contains(One.ToString()))
            {
                string vowelway = favoriteAnimal + "way";
                Console.WriteLine(vowelway);
                Console.ReadLine();
            }

            else if (consanents.Contains(One) && vowels.Contains(Two.ToString()))
            {
                string owelvay = favoriteAnimal.Remove(0) + "ay";
                Console.WriteLine(owelvay);
                Console.ReadLine();
            }

        }
    }
}

