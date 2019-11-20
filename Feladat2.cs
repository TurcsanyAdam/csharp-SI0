using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat2
    {
        public static void Getlowest()
        {
            int[] nums = new int[3];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Enter a number here: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(nums);
            Array.Reverse(nums);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
