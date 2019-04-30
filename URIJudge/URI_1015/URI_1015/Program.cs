using System;

namespace URI_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, result;
            string[] input1, input2;

            input1 = Console.ReadLine().Split(' ');
            input2 = Console.ReadLine().Split(' ');
            
            double.TryParse(input1[0], out x1);
            double.TryParse(input1[1], out y1);
            double.TryParse(input2[0], out x2);
            double.TryParse(input2[1], out y2);

            result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(result.ToString("F4"));
        }
    }
}
