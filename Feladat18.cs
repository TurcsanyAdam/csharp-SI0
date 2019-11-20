using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat18
    {
        public static int Temperature()
        {
            int count = 0;
            int temperature = 0;
            int monthCount = 12;

            while (count < monthCount)
            {
                count++;
                Console.Write("Enter the temperature of month " + Convert.ToString(count) + ": ");                
                int monthTemp = Convert.ToInt32(Console.ReadLine());
                temperature += monthTemp;
            }

            return temperature / 12;
        }
    }
}
