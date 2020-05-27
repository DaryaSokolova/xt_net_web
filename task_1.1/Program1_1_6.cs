using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parameters: None");
            Console.WriteLine("Enter: ");
            Console.WriteLine("1: bold ");
            Console.WriteLine("2: italic ");
            Console.WriteLine("3: underline ");

            int b = 0;
            int i = 0;
            int u = 0;
            bool fl = true;

            while (fl == true)
            {
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        if (b == 1)
                        {
                            b = 0;
                            if (i == 1 && u == 1)
                            {
                                Console.WriteLine("Parameter: italic, underline");
                            }
                            else
                            {
                                if (i == 1 && u == 0)
                                {
                                    Console.WriteLine("Parameter: italic");
                                }
                                else
                                {
                                    if (i == 0 && u == 1)
                                    {
                                        Console.WriteLine("Parameter: underline");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Parameter: None");
                                    }
                                }
                            }
                        }
                        else
                        {
                            b = 1;
                            if (i == 1 && u == 1)
                            {
                                Console.WriteLine("Parameter: bold, italic, underline");
                            }
                            else
                            {
                                if (i == 1 && u == 0)
                                {
                                    Console.WriteLine("Parameter: bold, italic");
                                }
                                else
                                {
                                    if (i == 0 && u == 1)
                                    {
                                        Console.WriteLine("Parameter: bold, underline");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Parameter: bold");
                                    }
                                }
                            }
                        }

                        break;
                    case "2":
                        if (i == 1)
                        {
                            i = 0;
                            if (b == 1 && u == 1)
                            {
                                Console.WriteLine("Parameter: bold, underline");
                            }
                            else
                            {
                                if (b == 1 && u == 0)
                                {
                                    Console.WriteLine("Parameter: bold");
                                }
                                else
                                {
                                    if (b == 0 && u == 1)
                                    {
                                        Console.WriteLine("Parameter: underline");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Parameter: None");
                                    }
                                }
                            }
                        }
                        else
                        {
                            i = 1;
                            if (b == 1 && u == 1)
                            {
                                Console.WriteLine("Parameter: bold, italic, underline");
                            }
                            else
                            {
                                if (b == 1 && u == 0)
                                {
                                    Console.WriteLine("Parameter: bold, italic");
                                }
                                else
                                {
                                    if (b == 0 && u == 1)
                                    {
                                        Console.WriteLine("Parameter: italic, underline");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Parameter: italic");
                                    }
                                }
                            }
                        }

                        break;
                    case "3":
                        if (u == 1)
                        {
                            u = 0;
                            if (b == 1 && i == 1)
                            {
                                Console.WriteLine("Parameter: bold, italic");
                            }
                            else
                            {
                                if (b == 1 && i == 0)
                                {
                                    Console.WriteLine("Parameter: bold");
                                }
                                else
                                {
                                    if (b == 0 && i == 1)
                                    {
                                        Console.WriteLine("Parameter: italic");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Parameter: None");
                                    }
                                }
                            }
                        }
                        else
                        {
                            u = 1;
                            if (b == 1 && i == 1)
                            {
                                Console.WriteLine("Parameter: bold, italic, underline");
                            }
                            else
                            {
                                if (b == 1 && i == 0)
                                {
                                    Console.WriteLine("Parameter: bold, underline");
                                }
                                else
                                {
                                    if (b == 0 && i == 1)
                                    {
                                        Console.WriteLine("Parameter: italic, underline");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Parameter: underline");
                                    }
                                }
                            }
                        }

                        break;
                    default:
                        fl = false;
                        break;
                }
            }

        }
    }
}
