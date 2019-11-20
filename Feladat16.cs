using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat16
    {
        public static void Password()
        {
            string password = "kutya";
            int guessCount = 0;
            int guessLimit = 3;

            while (guessCount < guessLimit)
            {
                Console.Write("Enter a password here: ");
                string guessedPass = Console.ReadLine();
                guessCount++;
                if(guessedPass == password)
                {
                    Console.WriteLine("Acces granted!");
                    break;
                }
                else if(guessCount == guessLimit)
                {
                    Console.WriteLine("Guess limit reached, access denied! ");
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }

        }
    }
}
