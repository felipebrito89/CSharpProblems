using System;
using System.Linq;

namespace hackerEarth_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, r, k, result;
            int[] num;

            num = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            l = num[0];
            r = num[1];
            k = num[2];

            result = 0;

            for (int i = l; i <= r; i++)
            {
                if (i % k == 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
