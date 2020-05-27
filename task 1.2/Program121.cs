using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате.";
            text = text + " ";

            double sum = 0;
            int count = 0;
            int start = 0;
            string s;
            int fin = 0;

            int k = 0;
            foreach (char ch in text)
            {
                if (ch == '.' || ch == ',' || ch == '!' || ch == '?' || ch == ':' || ch == ';')
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

            double answer = (sum - k) / count;

            Console.WriteLine("answer: " + answer);
        }
    }
}
