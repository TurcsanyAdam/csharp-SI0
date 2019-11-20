using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat17
    {
        public static void Month()
        {
            Console.Write("Enter month index here: ");
            int month = Convert.ToInt32(Console.ReadLine());
            if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("Spring");
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("Summer");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("Autumn");
            }
            else if (month == 12 || month == 1 || month == 2)
            {
                Console.WriteLine("Winter");
            }
            else
            {
                Console.WriteLine("Not valid month ");
            }
        }
    }
}
