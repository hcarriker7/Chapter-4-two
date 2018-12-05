using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double GPA;
            double admScore;
            string gpaString;
            string admString;

            Write("Please enter GPA ");
            gpaString = ReadLine();
            GPA = Convert.ToDouble(gpaString);

            Write("Please enter admission test score ");
            admString = ReadLine();
            admScore = Convert.ToInt32(admString);

            if (GPA >= 3.0 && admScore >= 60)
            {
                Write("Accept");
            }
            if (GPA <= 3.0 && admScore >= 80)
            {
                Write("Accept");
            }
            else
            {
                Write("Reject");
            }
        }
    }
}
