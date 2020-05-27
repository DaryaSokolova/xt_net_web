using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rand.Next(-20, 20);
                    Console.WriteLine("arr[" + i + "," + j + "]= " + arr[i, j]);
                }
            }

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum = sum + arr[i, j];
                    }
                }
            }
            Console.WriteLine("answer: " + sum);
        }
    }
}
