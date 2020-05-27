using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string First  = "написать программу, которая";
            string Second = "описание";
            string answer = " ";

            foreach (char ch in First)
                if (!Second.Contains(ch))
                    answer += ch;
                else
                {
                    answer += ch;
                    answer += ch;
                }
            Console.WriteLine("answer: " + answer);
        }
    }
}
