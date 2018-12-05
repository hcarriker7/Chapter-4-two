using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            string fahrString;

            Write("Please enter the fahrenheit at 10am");
            fahrString = ReadLine();
            fahrenheit = Convert.ToInt32(fahrString);
            celsius = fahrenheit - 32 * 5/9;
            Write("It was {0} celsius and {1} fahrenheit", celsius, fahrenheit);

            Write("Please enter the fahrenheit at 1pm");
            fahrString = ReadLine();
            fahrenheit = Convert.ToInt32(fahrString);
            celsius = fahrenheit - 32 * 5/9;
            Write("It was {0} celsius and {1} fahrenheit", celsius, fahrenheit);

            Write("Please enter the fahrenheit at 4pm");
            fahrString = ReadLine();
            fahrenheit = Convert.ToInt32(fahrString);
            celsius = fahrenheit - 32 * 5/9;
            Write("It was {0} celsius and {1} fahrenheit", celsius, fahrenheit);

            if (fahrenheit < 32)
            {
                Write("It is freezing");
            }
            if (fahrenheit > 100)
            {
                Write("It is hot outside");
            }

        }
    }
}
