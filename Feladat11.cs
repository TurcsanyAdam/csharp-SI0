using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat11
    {
        public static bool Divbynine(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                sum += a % 10;
                a = a / 10;
            }

            if (sum % 9 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
