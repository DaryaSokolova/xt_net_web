using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
                i++;
            }

            Console.WriteLine("answer: " + sum);
        }
    }
}
