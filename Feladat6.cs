using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat6
    {
        public static bool Trueorfalse()
        {
            Console.Write("Enter true or false here: ");
            bool a = Convert.ToBoolean(Console.ReadLine());

            if (a == true) 
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
