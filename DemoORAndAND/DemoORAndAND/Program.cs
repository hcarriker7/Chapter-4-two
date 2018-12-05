using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoORAndAND
{
    class Program
    {
        static void Main(string[] args)
        {
            const int zone1 = 1, zone2 = 2;
            const int LOW_QUANTITY = 10;
            string inputString;
            int quantity;
            int deliveryZone;

            Write("Delivery is free for zone {0} or {1} ", zone1, zone2);
            Write("when the number of boxes is less than {0} ", LOW_QUANTITY);
            Write("Enter delivery zone ");
            inputString = ReadLine();
            deliveryZone = Convert.ToInt32(inputString);
            Write("Enter the number of boxes in the shipment");
            inputString = ReadLine();
            quantity = Convert.ToInt32(inputString);

            if((deliveryZone == zone1 || deliveryZone == zone2) && quantity < LOW_QUANTITY)
            {
                Write("Delivery is free");
            }
            else
            {
                Write("A delivery charge applies");
            }

        }
    }
}
