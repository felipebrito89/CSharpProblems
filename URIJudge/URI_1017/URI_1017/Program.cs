using System;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, t;
            float result;

            int.TryParse(Console.ReadLine(), out t);
            int.TryParse(Console.ReadLine(), out d);

            result = (d * t) / 12f;

            Console.WriteLine(result.ToString("N3"));
        }
    }
}
