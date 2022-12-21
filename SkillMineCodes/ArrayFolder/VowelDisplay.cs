using System;

namespace ArrayFolder
{
    /*Q3. Display vowel from the array*/
    class DisplayVowel
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
            System.Console.WriteLine("\nVowel characters in array : ");
            for (int i = 0; i < ch.Length; i++)
            {
                char c = ch[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    Console.WriteLine (c);
                }
            }
        }
    }
}
