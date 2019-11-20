using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat4
    {
        public static bool Isnegative()
        {
            Console.WriteLine("Enter a number here: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
