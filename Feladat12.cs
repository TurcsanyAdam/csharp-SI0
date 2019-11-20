using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat12
    {
        public static int Digitcount(int a)
        {
            int count = 0;
            while (a != 0)
            {
                count++;
                a = a / 10;
            }

            return count;
        }
    }
}
