using System;

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, h, m, s;
            int.TryParse(Console.ReadLine(), out n);

            h = (n / 3600);
            n = n % 3600;
            m = (n / 60);
            n = n % 60;
            s = n;

            Console.WriteLine(h + ":" + m + ":" + s);
        }
    }
}
