using System;

namespace HackerEarth_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char[] result;
            input = Console.ReadLine();
            result = input.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLower(input, i))
                {
                    result[i] = char.ToUpper(result[i]);
                }
                else
                {
                    result[i] = char.ToLower(result[i]);
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
