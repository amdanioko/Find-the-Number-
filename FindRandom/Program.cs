using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 1001);
            int count = 1;

            Console.WriteLine("Guess a number.");
            while (true)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > randomNum)
                {
                    Console.WriteLine("Too big. Try again");
                    count++;
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Too small. Try again");
                    count++;

                }
                else if (guess == randomNum)
                {
                    Console.WriteLine("That's correct you found the number in N tries!");
                    Console.WriteLine($" This is your number of tries{count}");

                }
            }
        }
    }
}
//Use an instance of Random to select a "seet" number between 1 and 1000 inclusive.
//Prompt the user to guess the secret number.
//If the user enters a number larger than the secret, output "Too big.  Try again.", then return to step 2.
//If the user enters a number smaller than the secret, output "Too small.  Try again.", then return to step 2.
//If the user enters the correct number, output "That's correct!  You found the number in just N tries!", where N is the number of guesses that the user entered.  The program then finishes.