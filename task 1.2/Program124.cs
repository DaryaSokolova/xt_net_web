using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!";
            text = text + " ";
            Console.WriteLine(text);

            int start = 0;
            string s;
            int fin = 0;

            int k = 0;
            foreach (char ch in text)
            {
                if (char.IsUpper(ch))
                {
                    k++;
                }
            }

            while (fin != text.Length - 2)
            {
                fin = text.IndexOf('.', start + 2);
                if (fin == -1)
                {
                    fin = text.IndexOf('!', start + 2);
                    if (fin == -1)
                    {
                        fin = text.IndexOf('?', start + 2);
                    }
                }
                if (start == 0)
                {
                    s = text.Substring(start, fin - start + 2);
                }
                else
                {
                    s = text.Substring(start + 2, fin - start);
                }
                char[] chars = s.ToCharArray();
                chars[0] = char.ToUpper(chars[0]);
                s = new string(chars);
                Console.Write(s);
                start = fin;
            }
        }
    }
}
