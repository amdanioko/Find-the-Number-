using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 6);
            int count = 1;

            Console.WriteLine("Guess the Secret Number:");

            while (true)
            {
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNumber)

                {
                    Console.WriteLine("Too large.Try again");
                    count++;
                } else if (guess < randomNumber)
                    count++;

                { Console.WriteLine("Too small.Try again");
                    count++;

            } else if (guess == randomNumber) 
            
            {
                Console.WriteLine("Thats correct you found the number!");
                Console.WriteLine($"This is your number of tries{count}");
            }


          
            }
        }
    }
}
