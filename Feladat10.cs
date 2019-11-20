using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat10
    {
        public static void Liter(int dl)
        {
            int hekto = dl / 100;

            dl = dl - hekto * 100;

            int liter = dl / 10;

            dl = dl - liter * 10;

            string result = "Hektoliter: " + Convert.ToString(hekto) + " Liter: " + Convert.ToString(liter) + " Deciliter: " + Convert.ToString(dl);

            Console.WriteLine(result);
        }

    }
}
