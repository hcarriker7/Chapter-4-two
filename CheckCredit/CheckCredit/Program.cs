using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchPrice;
            string purchString;

            Write("Please enter a purchase price for an item ");
            purchString = ReadLine();
            purchPrice = Convert.ToInt32(purchString);

            if (purchPrice < 5000)
            {
                Write("Approved! ");
            }
            if (purchPrice > 5000)
            {
                Write("ERROR ");
            }
        }
    }
}
