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
            string favoriteAnimal = Console.ReadLine().ToLower();

            char One = favoriteAnimal[0];
            char Two = favoriteAnimal[1];
            char three = favoriteAnimal[2];

            List<char> consanents = new List<char>
            {
                'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z',
            };

            List<char> vowels = new List<char>
            {
                'a', 'e', 'i', 'o', 'u', 'y'
            };

            if (consanents.Contains(One) && consanents.Contains(Two))
            {
                string newFavoriteAnimal = favoriteAnimal.Remove(0,2);
                string bird = newFavoriteAnimal + One + Two + "ay";
                Console.WriteLine(bird);
                Console.ReadLine();
            }

            else if (vowels.Contains(One))
            {
                string cat = favoriteAnimal + "way";
                Console.WriteLine(cat);
                Console.ReadLine();
            }

            else if (consanents.Contains(One) && vowels.Contains(Two))
            {
                string bear = favoriteAnimal.Remove(0, 1);
                string dog = bear + "ay";
                Console.WriteLine(dog);
                Console.ReadLine();
            }

        }
    }
}

