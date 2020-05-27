using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";
            text = text + " ";

            int sum = 0;
            int count = 0;
            int start = 0;
            string s;
            int fin=0;

            int k = 0;
            foreach (char ch in text)
            {
                if (char.IsUpper(ch))
                {
                    k++;
                }
            }

            while (fin != text.Length - 1)
            {
                fin = text.IndexOf(' ', start + 1);
                s = text.Substring(start + 1, fin - start - 1);
                sum = sum + s.Length;
                if (start == 0)
                {
                    sum++;
                }
                count++;
                start = fin;
            }
            double answer = count-k;

            Console.WriteLine("answer: " + answer);
        }
    }
}
