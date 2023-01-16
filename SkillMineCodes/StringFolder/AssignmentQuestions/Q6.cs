using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    //6. Write a C# program to remove all occurrences of a character from string.
    public class Q6
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            char c = 'o';
            fnc (s, c);
        }

        public static void fnc(string s, char c)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != c)
                {
                    sb.Append(s[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
