using System;

namespace FlipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flip Coin Simulator");

            FlipCoin();

        }


        public static int FlipCoin()
        {
            //constant
            const int HEAD = 0;
            const int TAIL = 1;
            
            //declaration
            int headCount = 0;
            int tailCount = 0;


            while (headCount < 21 && tailCount < 21)
            {

                Random random = new Random();
                int flipCheck = random.Next(0, 2);
                if (flipCheck == HEAD)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
                else if (flipCheck == TAIL)
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
            }
            Console.WriteLine($"Head {headCount}");
            Console.WriteLine($"Tail {tailCount}");


            if (headCount >= 21)
            {
                Console.WriteLine($"head won by {headCount - tailCount}");
            }
            else if (tailCount >= 21)
            {
                Console.WriteLine($"tail won by {tailCount - headCount}");

            }
            else if (headCount == tailCount)
            {
                Console.WriteLine("tie");

            }


            return 0;
        }
    }
}