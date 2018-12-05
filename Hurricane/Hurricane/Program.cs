using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string windString;
            int wind;

            Write("Please enter the hurricane's wind speed MPH   ");
            windString = ReadLine();
            wind = Convert.ToInt32(windString);

            if (wind < 74)
            {
                Write("It is not a hurricane ");
            }
            if (wind >= 74 && wind < 94)
            {
                Write("It is a category 1 hurricane ");
            }    
            if (wind >= 94 && wind < 111)
            {
                Write("It is a category 2 hurricane ");
            }
            if (wind >= 111 && wind < 130)
            {
                Write("It is a category 3 hurricane ");
            }
            if (wind >= 130 && wind < 157)
            {
                Write("It is a category 4 hurricane ");
            }
            if (wind >= 157)
            {
                Write("It is a category 5 hurricane ");
            }
            



        }
    }
}
