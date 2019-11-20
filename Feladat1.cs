using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat1
    {
        public static string Circle()
        {
            Console.Write("Enter a radius here: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;

            string circum = Convert.ToString(2 * r * pi);
            string area = Convert.ToString(r * r * pi);
            string result = "The circumference of the circe: " + circum + " The area of the circle: " + area;

            return result;
        }
        public static string Sphere()
        {
            Console.Write("Enter a radius here: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;

            string surface = Convert.ToString(r * r * 4 * pi);
            string volume = Convert.ToString(4 * pi / 3 * r * r * r);
            string result = "The surface of the sphere: " + surface + " The volume of the sphere: " + volume;

            return result;
        }
    }
}
