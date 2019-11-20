using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat19
    {
        public static void Coffee()
        {
            int coffeePrice = 100;

            Console.Write("Would you like double? (Yes/No) ");
            string doubleCoffee = Console.ReadLine();

            Console.Write("Would you like cream? (Yes/No) ");
            string creamCoffee = Console.ReadLine();

            Console.Write("Would you like a cup? (Yes/No) ");
            string cupCoffee = Console.ReadLine();

            if (doubleCoffee == "Yes")
            {
                coffeePrice += 20;
            }
            if (creamCoffee == "Yes")
            {
                coffeePrice += 50;
            }
            if (cupCoffee == "Yes")
            {
                coffeePrice -= 10;
            }

            Console.WriteLine("Your coffee will cost: " + Convert.ToString(coffeePrice));
        }
    }
}
