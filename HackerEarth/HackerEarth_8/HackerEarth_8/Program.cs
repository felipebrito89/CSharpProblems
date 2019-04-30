using System;

namespace HackerEarth_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, L, W, H;
            string[] input;
            int.TryParse(Console.ReadLine(), out L);
            int.TryParse(Console.ReadLine(), out N);

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split(' ');

                int.TryParse(input[0], out W);
                int.TryParse(input[1], out H);

                if (W < L || H < L)
                {
                    Console.WriteLine("UPLOAD ANOTHER");
                }
                else if (W == H)
                {
                    Console.WriteLine("ACCEPTED");
                }
                else
                {
                    Console.WriteLine("CROP IT");
                }
            }
        }
    }
}
