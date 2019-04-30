using System;

namespace HackerEarth_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string S, R;

            S = Console.ReadLine();

            char[] arr = S.ToCharArray();
            Array.Reverse(arr);
            R = new string(arr);

            if (S == R) Console.WriteLine("YES");
            else Console.WriteLine("NO");

            Console.ReadLine();

        }
    }
}
