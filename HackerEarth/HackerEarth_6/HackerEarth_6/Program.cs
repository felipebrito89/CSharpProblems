using System;

namespace HackerEarth_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fat;

            fat = 1;
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 2; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}
