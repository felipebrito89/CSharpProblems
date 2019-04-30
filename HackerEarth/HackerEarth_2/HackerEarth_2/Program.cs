using System;

namespace HackerEarth_2
{
    class Program
    {
        public static void Main()
        {
            string str1, str2;
            int testCase;

            testCase = Int32.Parse(Console.ReadLine());

            for (int k = 0; k < testCase; k++)
            {
                str1 = Console.ReadLine();
                str2 = Console.ReadLine();

                int[] count1 = new int[26];
                int[] count2 = new int[26];

                for (int i = 0; i < str1.Length; i++)
                    count1[str1[i] - 'a']++;

                for (int i = 0; i < str2.Length; i++)
                    count2[str2[i] - 'a']++;

                int result = 0;
                for (int i = 0; i < 26; i++)
                    result += Math.Abs(count1[i] - count2[i]);
                Console.WriteLine(result);
            }

        }
    }
}
