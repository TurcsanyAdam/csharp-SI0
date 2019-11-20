using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat20
    {
        public static void Moneycounter(int money)
        {
            int[] denoms = new int[6] { 50, 25, 10, 5, 2, 1 };
            

            foreach (int i in denoms)
            {
                int counter = money / i;
                money -= counter * i;

                Console.WriteLine("You will need " + Convert.ToString(counter) + " from " + Convert.ToString(i));

            }
        }
    }
}
