using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineProject.Array
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

            Toggle t = new Toggle();
            System.Console.WriteLine(t.ToggleCase(ch));
        }

        public char[] ToggleCase(char[] ch)
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
