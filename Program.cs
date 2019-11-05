using System;

namespace Coin_flipper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Amount of coins to flip - in string
            string flipAmount;
            // Amount of coins to flip - converted to int
            int flipAmountInt;
            // Random number
            var rng = new Random();
            // Chances
            string chances;
            // chances but to double
            double chancesDouble = 0.5;
            // Correct enter
            bool correct = true;
            // How many heads have been flipped
            int heads = 0;
            // How many tails have been flipped
            int tails = 0;
            // Current streak
            int streak = 0;
            // Longest head streak
            int headStreak = 0;
            // Longest tail streak
            int tailStreak = 0;
            // streak is heads
            int streakIsHeads = 0;

            Console.WriteLine("How many coins do you want to flip?");
            flipAmount = Console.ReadLine();
            flipAmountInt = Convert.ToInt32(flipAmount);
            Console.Clear();
            while (correct)
            {
                try
                {
                    Console.WriteLine("What are the chances?");
                    Console.WriteLine("If you enter 0.3 heads will have a 30% chance of winning and tails has 70%");
                    Console.WriteLine("Enter a number:");
                    chances = Console.ReadLine();
                    chancesDouble = Convert.ToDouble(chances);
                    if (chancesDouble < 1 && chancesDouble > 0)
                    {
                        correct = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Enter a number between 0.0 and 1.0");
                    }
                }
                catch
                {
                    Console.WriteLine("Oops something went wrong, please make sure you enter a number like this => 0.1\nMake sure the number is between 0.0 and 1");
                }
            }



            for (int i = 0; i < flipAmountInt; i++)
            {
                if (rng.NextDouble() < chancesDouble)
                {
                    if (streakIsHeads != 0)
                    {
                        streak = 0;
                    }
                    streakIsHeads = 1;
                    heads++;
                    streak++;
                    if (streak > headStreak)
                    {
                        headStreak = streak;
                    }
                }
                else
                {
                    if (streakIsHeads != 1)
                    {
                        streak = 0;
                    }
                    streakIsHeads = 0;
                    tails++;
                    streak++;
                    if (streak > tailStreak)
                    {
                        tailStreak = streak;
                    }
                }
            }

            double tailChance = 1 - chancesDouble;
            Console.Clear();
            Console.WriteLine("Heads had a " + chancesDouble + " chance to win");
            Console.WriteLine("Tails had a " + tailChance + " chance to win");
            Console.WriteLine("\nHeads has been flipped: " + heads);
            Console.WriteLine("Tails has been flipped: " + tails);
            if (tailStreak > headStreak)
            {
                Console.WriteLine("\nThe longest streak belongs to tails: " + tailStreak);
            }
            else
            {
                Console.WriteLine("\nThe longest streak belongs to heads: " + headStreak);
            }
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
        }
    }
}
