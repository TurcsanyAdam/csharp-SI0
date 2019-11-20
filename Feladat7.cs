using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat7
    {
        public static int Middle()
        {
            Console.Write("Enter a number here: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number here: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int middle = (num1 + num2) / 2;

            return middle;
        }
    }
}
