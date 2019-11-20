using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat5
    {
        public static void Calculator()
        {
            Console.Write("Enter a number here: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number here: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string sum = Convert.ToString(num1 + num2);
            string sub = Convert.ToString(num1 - num2);
            string mult = Convert.ToString(num1 * num2);
            string div = Convert.ToString(num1 / num2);

            Console.WriteLine("The sum of the numbers is: " + sum);
            Console.WriteLine("The minus of the numbers is: " + sub);
            Console.WriteLine("The product of the numbers is: " + mult);
            Console.WriteLine("The quotient of the numbers is: " + div);

        }
    }
}
