using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int headCount = 0;
            int tailCount = 0;

            // Main Program Logic
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            for (int i = 1; i <= 15; i++)
            {
                Random rnd = new Random();
                int flipCheck = rnd.Next(0, 2);
                if (flipCheck == 1)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
            }
            Console.WriteLine("Heads wins {0} times", headCount);
            Console.WriteLine("Tails wins {0} times", tailCount);

            Console.ReadLine();

        }
    }
}
