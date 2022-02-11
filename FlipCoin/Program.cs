using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            const int HEAD = 1;
            const int TAIL = 0;

            Random random = new Random();
            int flipCheck = random.Next(0, 2);
            if (flipCheck == HEAD)
            {
                Console.WriteLine("HEAD wins");
            }
            else
            {
                Console.WriteLine("TAIL wins");

            }

        }
    }
}
