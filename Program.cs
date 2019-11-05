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
            // Random numer
            var rng = new Random();
            // Chances
            string chances;
            // Chances int
            decimal chancesDec = 0;
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

            // Console.WriteLine("What are the chances?");
            // Console.WriteLine("If you enter 0.3 heads will have a 30% chance of winning and tails has 70%");
            // Console.WriteLine("Enter a number:");
            // chances = Console.ReadLine();
            // chancesDec = decimal.Parse(chances);

            for (int i = 0; i < flipAmountInt; i++)
            {
                if (rng.NextDouble() < 0.5)
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
            Console.WriteLine("Heads has been flipped: " + heads);
            Console.WriteLine("Tails has been flipped: " + tails);
            if (tailStreak > headStreak)
            {
                Console.WriteLine("The longest streak belongs to tails: " + tailStreak);
            }
            else
            {
                Console.WriteLine("The longest streak belongs to heads: " + headStreak);
            }
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
        }
    }
}
