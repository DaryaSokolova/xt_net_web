using System;
using System.Globalization;
//реализация без заданий со *
namespace homework
{
    class MyString
    {
        public char[] chars1;
        public char[] chars2;

        public string string1;
        public string string2;

        public void Conclusion()
        {
            СonversionToSym(string1, string2);
            for (int i = 0; i < chars1.Length; i++)
                Console.Write(chars1[i]);
            Console.WriteLine();
            for (int i = 0; i < chars2.Length; i++)
                Console.Write(chars2[i]);
            Console.WriteLine();
        }
        public void ComparisonConditions()
        {
            СonversionToSym(string1, string2);
            if (chars1.Length == chars2.Length) Comparison(chars1.Length);
            else
            {
                if (chars1.Length > chars2.Length) Comparison1(chars2.Length, chars2);
                else Console.WriteLine(-1);
            }
        }
        public void Comparison(int k)
        {
            int arg = 0;
            for (int i = 0; i < k; i++)
            {
                if (chars1[i] == chars2[i])
                {
                    arg++;
                }
            }
            if (arg == chars1.Length)
                Console.WriteLine(0);
            else Console.WriteLine(-1);
        }
        public void Comparison1(int k, char[] STR)
        {
            int arg = 0;
            for (int i = 0; i < k; i++)
            {
                if (chars1[i] == chars2[i])
                {
                    arg++;
                }
                else arg = 0;
            }
            if (arg == STR.Length) Console.WriteLine(1);
            else Console.WriteLine(-1);
        }
        public void Merger()
        {
            СonversionToSym(string1, string2);
            char[] chars3 = new char[chars1.Length + chars2.Length];
            for (int i = 0; i < chars1.Length; i++)
                chars3[i] = chars1[i];
            for (int i = 0; i < chars2.Length; i++)
                chars3[chars1.Length + i] = chars2[i];
            СonversionToString(chars3);
        }
        public void FirstSearchSymbols(char a)
        {
            СonversionToSym(string1, string2);
            int arg = 0;
            for (int i = 0; i < chars1.Length; i++)
                if (chars1[i] == a)
                {
                    arg++;
                    Console.WriteLine(i);
                    break;
                }
            if (arg == 0) Console.WriteLine(-1);
        }
        public void LastSearchSymbols(char a)
        {
            СonversionToSym(string1, string2);
            int arg = 0;
            int index = -1;
            for (int i = 0; i < chars1.Length; i++)
                if (chars1[i] == a)
                {
                    arg++;
                    index = i;
                }
            if (arg == 0) Console.WriteLine(-1);
            else Console.WriteLine(index);
        }
        public void СonversionToString(char[] chars)
        {
            string STRING = new string(chars);
            Console.WriteLine(STRING);
        }
        public void СonversionToSym(string STRING1, string STRING2)
        {
            chars1 = STRING1.ToCharArray();
            chars2 = STRING2.ToCharArray();
        }
        public void InsertRows(int k)
        {
            СonversionToSym(string1, string2);
            char[] chars3 = new char[chars1.Length + chars2.Length];
            int arg1 = 0; ;
            for (int i = 0; i < k; i++)
            {
                chars3[i] = chars1[i];
                arg1 = i;
            }
            arg1++;
            int arg2 = 0;
            while (arg2 < chars2.Length)
            {
                chars3[arg1] = chars2[arg2];
                arg1++;
                arg2++;
            }
            arg2 = k;
            while (arg1 < chars1.Length + chars2.Length)
            {
                chars3[arg1] = chars1[arg2];
                arg1++;
                arg2++;
            }
            СonversionToString(chars3);
        }
        public void CapitalLetters()
        {
            СonversionToSym(string1, string2);
            for (int i = 0; i < chars1.Length; i++)
            {
                chars1[i] = char.ToUpper(chars1[i]);
                Console.Write(chars1[i]);
            }
            Console.WriteLine();
        }
        public void LowerCase()
        {
            СonversionToSym(string1, string2);
            for (int i = 0; i < chars1.Length; i++)
            {
                chars1[i] = char.ToLower(chars1[i]);
                Console.Write(chars1[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString();
            str.string1 = "Дашу замучали экзамены.";
            str.string2 = "Завтра защита.";
            //вывод на экран
            str.Conclusion();
            //сравнение, аналог Compare
            str.ComparisonConditions();
            //конкатенация
            str.Merger();
            //аналог поиска первого вхождения заданного символа
            str.FirstSearchSymbols('а');
            //аналог поиска последнего вхождения заданного символа
            str.LastSearchSymbols('а');
            //аналог Insert
            str.InsertRows(1);
            //аналог ToUpper
            str.CapitalLetters();
            //аналог ToLower
            str.LowerCase();
            Console.ReadKey();
        }
    }
}