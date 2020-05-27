using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int min =   10000;
            int max = - 10000;
            arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(20);
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                min = (arr[i] < min) ? arr[i] : min;
                max = (arr[i] > max) ? arr[i] : max;
            }
            Console.WriteLine("min= " + min + ", max= " + max);
            for (int j = 0; j < 2 * arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int transition = -1;
                    if (arr[i] > arr[i + 1])
                    {
                        transition = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = transition;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }  
        }
    }
}
