using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N= ");
            string str = Console.ReadLine();
            int N = int.Parse(str);
            int k = 1;
            for (int i1 = 0; i1 < N; i1++)
            { 
                for (int i = 0; i < k; i++)
                {
                    for (int j = 1; j < N - i; j++)
                    {
                        Console.Write(' ');
                    }

                    for (int j = k - 2 * i; j <= k; j++)
                    {
                        Console.Write('*');

                    }

                    Console.WriteLine();
                }
                k++;
            }
        }
    }
}
