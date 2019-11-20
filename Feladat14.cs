using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat14
    {
        public static void Financialresult()
        {
            Console.Write("Enter income here: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter expenditure here: ");
            double exp = Convert.ToDouble(Console.ReadLine());

            double result = income - exp;

            if (result > 0)
            {
                Console.WriteLine("Income was higher then expenditure this year!");
                Console.WriteLine(result);
            }
            else if (result < 0)
            {
                Console.WriteLine("Income was lower then expenditure this year!");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Income was equal to the expenditure this year!");
                Console.WriteLine(result);
            }
        }
    }
}
