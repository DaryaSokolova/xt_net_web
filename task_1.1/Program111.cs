using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.Write("a= ");
            string str = Console.ReadLine();
            bool result = int.TryParse(str, out A);
            if (result)
            {
                A = int.Parse(str);
            }

            Console.Write("b= ");
            str = Console.ReadLine();
            result = int.TryParse(str, out B);
            if (result)
            {
                B = int.Parse(str);
            }

            if (A <= 0 | B <= 0)
            {
                Console.WriteLine("incorrect input");
            }

            else
            {
                int square = A * B;
                Console.WriteLine("Answer: " + square);
            }
        }
    }
}
