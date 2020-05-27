using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i=0; i<10; i++)
            {
                arr[i] = rand.Next(-20, 20);
                Console.Write(arr[i]+ " ");
            }

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i]>=0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("answer: " +sum);
        }
    }
}
