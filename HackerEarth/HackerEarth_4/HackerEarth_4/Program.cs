using System;

namespace HackerEarth_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] A;
            double answer, modulo;

            int.TryParse(Console.ReadLine(), out N);
            A = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            modulo = Math.Pow(10, 9) + 7;

            answer = 1;
            for (int i = 0; i < N; i++)
            {
                answer = (answer * A[i]) % modulo;
            }

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
