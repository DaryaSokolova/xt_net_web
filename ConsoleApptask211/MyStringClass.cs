﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask211
{
    class MyStringClass
    {
        private char[] chars;
        public MyStringClass(string string1)
        {
            chars = string1.ToCharArray();
        }
        public int Length
        {
            get
            {
                return chars.Length;
            }
        }
        public static int Compare(MyStringClass strA, MyStringClass strB)
        {

            if (strA.Length < strB.Length) 
            { 
                return -1; 
            }

            if (strA.Length > strB.Length)
            {
                return 1;
            }

            for (int i = 0; i < strA.Length; i++)
            {
                if (strA.chars[i] < strB.chars[i])
                {
                    return -1;
                }

                else
                {
                    if (strA.chars[i] > strB.chars[i])
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }
        public MyStringClass Concat(MyStringClass strB)
        {
            char[] temp = new char[chars.Length + strB.Length];
            int i = 0;

            foreach (char ch in chars)
            {
                temp[i] = ch;
                i++;
            }

            foreach (char ch in strB.chars)
            {
                temp[i] = ch;
                i++;
            }

            return new MyStringClass(ToString(temp));
        }
        public string ToString(char[] chrs)
        {
            string stringA = new string(chrs);
            return stringA;
        }
        public int IndexOf(char temp)
        {
            int i = 0;

            foreach (char chr in chars)
            {
                if (chr == temp)
                {
                    return i;
                }

                i++;
            }
            return -1;
        }
        public int LastIndexOf(char temp)
        {
            for (int i = chars.Length - 1; i > 0; i--)
            {
                if (chars[i] == temp)
                {
                    return i;
                }
            }

            return -1;
        }
        public char[] ToCharArray(string stringA)
        {
            char[] array = stringA.ToCharArray();
            return array;
        }
        public MyStringClass Substring(int index, int indexLast)
        {
            char[] temp = new char[indexLast-index+1];
            int count = 0;

            for (int i = 0; i< Length; i++)
            {
                if ((i >= index) && (i <= indexLast))
                {
                    temp[count++] = chars[i];
                }
            }

            return new MyStringClass(ToString(temp));
        }

        public MyStringClass Remove(int index, int count)
        {
            char[] temp = new char[Length - count];
            int k = 0;

            for (int i = 0; i < Length; i++)
            {
                if ((i < index)||(i > index+count-1))
                {
                    temp[k++] = chars[i];
                }
            }

            return new MyStringClass(ToString(temp));
        }

        public char[] ToArray()
        {
            char[] arr = chars;
            return arr; 
        }
    }
}
