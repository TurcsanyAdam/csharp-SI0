using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI0
{
    class Feladat13
    {
        public static string Month(string month)
        {
            if (month == "March" || month == "April" || month == "May")
            {
                return "Spring";
            }
            else if (month == "June" || month == "July" || month == "August")
            {
                return "Summer";
            }
            else if (month == "September" || month == "October" || month == "November")
            {
                return "Autumn";
            }
            else if (month == "December" || month == "January" || month == "February")
            {
                return "Winter";
            }
            else
            {
                return "Not valid month ";
            }
        }
    }
}
