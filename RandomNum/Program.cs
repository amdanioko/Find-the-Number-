using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomNum
{
    class Program
    {
        public static int SelectedNum = 0;
        public static Random rand = new Random();
        public static bool GameOver = false;

        static void Main(string[] args)
        {
            SelectedNum = rand.Next(1, 10001); 
            int userNum = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 1000");
                userNum = Convert.ToInt32(Console.ReadLine());
                GuessNumber(userNum);
            }

            while (GameOver == false);
        }

        public static void GuessNumber(int userNum)
        {
            if (userNum < SelectedNum)
                Console.WriteLine("Too low, Try again.");
            else if (userNum > SelectedNum)
                Console.WriteLine("Too high. Try again");
            else
            {
                Console.WriteLine("You got it!");

            }
        }
    }
}
