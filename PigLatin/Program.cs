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
            Console.WriteLine("what is your favorie food?");
            string favoriteFood = Console.ReadLine();

            Console.WriteLine("what color is your house?");
            string houseColor = Console.ReadLine();

            Console.WriteLine("Becuase your favorite food is " + favoriteFood + " then of course your house would be the color " + houseColor);

            Console.WriteLine("Now let me ask you this: ");
            Console.Write("What is the first three digits of your area code?");
            int areaCode = int.Parse(Console.ReadLine());



            if (areaCode == 864)
            {
                Console.WriteLine("");

            }

            Console.ReadLine();

        }
    }
}
