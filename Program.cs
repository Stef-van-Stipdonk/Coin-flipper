using System;

namespace Coin_flipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of your choice: ");

            string enterNumber = Console.ReadLine();
            try
            {
                Convert.ToInt32(enterNumber);

            }
            catch
            {
                Console.WriteLine("Error while converting to int");
            }

        }
    }
}
