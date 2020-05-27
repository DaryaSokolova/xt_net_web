using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, ,] arr;
            arr = new int[5, 5, 5];

            Random rand = new Random();

            for (int i1=0; i1<5; i1++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    for (int i3=0; i3 < 5; i3++)
                    {
                        arr[i1, i2, i3] = rand.Next(-20, 20);
                        Console.WriteLine("arr[" + i1 + "," + i2 + ","+ i3 + "]= " + arr[i1, i2, i3] + " ");
                    }
                }
            }

            Console.WriteLine();

            for (int i1 = 0; i1 < 5; i1++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    for (int i3 = 0; i3 < 5; i3++)
                    {
                        arr[i1, i2, i3] = (arr[i1, i2, i3] > 0) ? 0 : arr[i1, i2, i3];
                        Console.WriteLine("arr[" + i1 + "," + i2 + "," + i3 + "]= " + arr[i1, i2, i3] + " ");
                    }
                }
            }
        }
    }
}
