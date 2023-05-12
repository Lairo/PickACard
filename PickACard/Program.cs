using System;

namespace PickACard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("Pick how many cards you would like to draw.");
            //    string answer = Console.ReadLine();
            //    int.TryParse(answer, out int number);
            //    PickCards.PrintNumber(number);
            //}

            Random random = new Random();

            double[] randomDoubles = new double[20];

            for(int i = 0; i < randomDoubles.Length; i++ )
            {
                double value = random.NextDouble();
                randomDoubles[i] = value;

            }
            for (int i = 0; i < 21; i++)
            {
                foreach (double value in randomDoubles)
                {

                    Console.WriteLine(i + " " + value);

                }
            }
        }
    }
}
