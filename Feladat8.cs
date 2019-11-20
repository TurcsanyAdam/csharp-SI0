using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat8
    {
        public static string Cuboid(int a, int b, int c)
        {
            double diagonal2 = Math.Sqrt(a * a + b * b + c * c);
            double diagonal1 = Math.Sqrt(a * a + b * b);

            string result = "Diagonal of cuboid: " + Convert.ToString(diagonal1) + " Body diagonal: " + Convert.ToString(diagonal2);

            return result;
        }
    }
}
