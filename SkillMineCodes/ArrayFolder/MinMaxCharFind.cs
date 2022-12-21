using System;

namespace ArrayFolder
{
    /*Q5. Find min-max from character array*/
    class MinMaxCharFind
    {
        class MinMaxChar
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter size of array");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter Characters");
                char[] ch = new char[n];
                for (int i = 0; i < n; i++)
                {
                    ch[i] = Convert.ToChar(Console.ReadLine());
                }
                fun (ch);
            }

            public static void fun(char[] ch)
            {
                int max = Convert.ToInt32(ch[0]);
                int min = Convert.ToInt32(ch[0]);
                for (int i = 0; i < ch.Length; i++)
                {
                    int c = Convert.ToInt32(ch[i]);
                    if (max < c)
                    {
                        max = c;
                    }
                    if (min > c)
                    {
                        min = c;
                    }
                }
                Console.WriteLine((char) min + " " + (char) max);
            }
        }
    }
}
