using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NumberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string numberstring;

            Write("Welcome to the Number Picker");
            Write("Please pick a number 1 2 3");
            numberstring = ReadLine();
            number = Convert.ToInt32(numberstring);

            if (number == 1)
            {
                Write("Haha you lose");
            }
            if (number == 2)
            {
                Write("Yay! I win!");
            }
            if (number == 3)
            {
                Write("Haha you lose");
            }
            else
            {
                Write("Error");
            }

        }
    }
}
