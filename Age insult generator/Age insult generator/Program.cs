using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Age_insult_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string agestring;
            string yesString;
            int yes;

            Write("Welcome to the famous Age Insult Generator!");
            Write("Please enter your age");
            agestring = ReadLine();
            age = Convert.ToInt32(agestring);

            if (age < 18)
            {
                Write("You are a minor, hahahahaha.");
            }
            else if (age >= 18 && age < 25)
            {
                Write("You should be in college or done with college by now. Do not be a dead beat.");
            }
            else if (age >= 25 && age < 32)
            {
                Write("Do you have a job? 1 for yes 2 for no");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                    Write("Good for you.");
                else
                    Write("Get a job hippie");
            }
            else if (age >= 32 && age < 42)
            {
                Write("Are you in a relationship? If not, looks like we know who's gonna die alone");
            }
            else if (age >= 42 && age < 52)
            {
                Write("Wow you're getting old. Look at how many gray hairs you have.");
            }
            else if (age >= 52 && age < 62)
            {
                Write("Better start thinking about retirement you old fart");
            }
            else if (age >= 62)
            {
                Write("Youre practically dead. You make Nelson Mandela look like a child.");
            }   



        }
    }
}
