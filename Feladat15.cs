using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat15
    {
        public static void LanguageHi()
        {
            Console.Write("Do you speak English? (Yes/No) ");
            string english = Console.ReadLine();

            string heart = "\u2665";

            if (english == "Yes")
            {
                Console.WriteLine("Hello User " + heart);
            }

            Console.Write("Do you speak Hungarian? (Yes/No) ");
            string hungarian = Console.ReadLine();

            if (hungarian == "Yes")
            {
                Console.WriteLine("Szavasz felhasználó " + heart);
            }

            Console.Write("Do you speak Spanish? (Yes/No) ");
            string spanish = Console.ReadLine();

            if (spanish == "Yes")
            {
                Console.WriteLine("Hola User " + heart);
            }      

        }
    }
}
