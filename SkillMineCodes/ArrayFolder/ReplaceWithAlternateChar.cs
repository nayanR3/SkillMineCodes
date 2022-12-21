using System;

namespace ArrayFolder
{
    /*Q6. Replace with Alternate character*/
    class ReplaceWithAlternateChar
    {
        static void Main(string[] args)
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
            for (int i = 0; i < ch.Length; i++)
            {
                char c = ch[i];

                if (c == 'y')
                {
                    Console.WriteLine(c + "+2 = " + "a");
                }
                else if (c == 'z')
                {
                    Console.WriteLine(c + "+2 = " + "b");
                }
                else if (c >= 'a' || c <= 'x')
                {
                    int v = Convert.ToInt32(c);
                    Console.WriteLine(c + "+2 = " + Convert.ToChar(c + 2));
                }
            }
        }
    }
}
