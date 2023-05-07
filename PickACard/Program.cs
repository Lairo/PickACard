using System;

namespace PickACard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pick how many cards you would like to draw.");
                string answer = Console.ReadLine();
                int.TryParse(answer, out int number);
                PickCards.PrintNumber(number);
            }

        }
    }
}
