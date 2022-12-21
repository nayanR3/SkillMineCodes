using System;

namespace ArrayFolder
{
    internal class Toggle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] ch = new char[n];
            for (int i = 0; i < n; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            System.Console.WriteLine(ToggleCase(ch));
        }

        public static char[] ToggleCase(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                    ch[i] = (char)(ch[i] + 'a' - 'A');
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                    ch[i] = (char)(ch[i] + 'A' - 'a');
            }
            return ch;
        }
    }
}
