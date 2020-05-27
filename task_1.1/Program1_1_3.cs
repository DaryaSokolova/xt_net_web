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

            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < N-i; j++)
                {
                    Console.Write(' ');
                }
               
                for (int j = N-2*i; j <= N; j++)
                {
                    Console.Write('*');
                    
                }

                Console.WriteLine();

            }
        }
    }
}
