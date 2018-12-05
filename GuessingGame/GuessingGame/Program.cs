using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            string guessString;
            int guess;
            string result = null;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            Write("Choose a number between 1-10   ");
            guessString = ReadLine();
            guess = Convert.ToInt32(guessString);

            if (guess < max && guess >= min)
            {
                if (randomNumber == guess)
                {
                    result = "You win, you guessed " + randomNumber;
                }
                else if (guess > randomNumber)
                {
                    result = "You guessed too high";
                }
                else if (guess < randomNumber)
                {
                    result = "You guessed too low";
                }
            }
            else
                result = "Error";
            WriteLine(result);
        }
    }
}
