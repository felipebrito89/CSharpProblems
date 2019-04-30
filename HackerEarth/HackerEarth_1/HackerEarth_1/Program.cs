using System;
using System.Collections.Generic;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int i, k, divisor;
            int num = 0;
            string primos = "";
            while (num <= 0 || num > 1000)
            {
                Int32.TryParse(Console.ReadLine(), out num);
            }
            for (i = 1; i <= num; i++)
            {
                divisor = 0;
                for (k = 1; k <= i; k++)
                {
                    if ((i % k) == 0)
                    {
                        divisor++;
                    }
                }
                if (divisor == 2)
                {
                    numbers.Add(i);
                }
            }

            foreach (int n in numbers)
            {
                primos = primos + (n.ToString() + " ");
            }

            Console.WriteLine(primos);
        }
    }
}
