using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    // Write a C# program to find first occurrence of a character in a given string.
    public class Q2
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            char c = 'l';
            sol (str, c);
        }

        public static void sol(string s, char c)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) count++;
            }
            System.Console.WriteLine (count);
        }
    }
}
