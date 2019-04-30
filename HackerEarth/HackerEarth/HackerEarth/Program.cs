using System;

namespace HackerEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            char[] SArray;
            int pos1, pos2;

            pos1 = 0;
            pos2 = 0;
            S = Console.ReadLine();

            SArray = S.ToCharArray();

            foreach (char item in SArray)
            {
                if (item == 'R')
                {
                    pos1++;
                }
                if (item == 'L')
                {
                    pos1--;
                }
                if (item == 'U')
                {
                    pos2++;
                }
                if (item == 'D')
                {
                    pos2--;
                }
            }

            Console.WriteLine(pos1 + " " + pos2);
        }
    }
}
