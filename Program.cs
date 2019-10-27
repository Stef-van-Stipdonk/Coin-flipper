using System;

namespace Coin_flipper
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number of your choice: ");
            try
            {
                int intNumb = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("This is not a number");
            }

            Random r = new Random();

            int ranNumb = r.Next(1, 2);

            Console.WriteLine(ranNumb);
        }
    }
}
