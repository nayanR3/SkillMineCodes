using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    // 8. Write a C# program to toggle case of each character of a string.
    public class Q8
    {
        static void Main(string[] args)
        {
            string s = "hellOOOO world";
            fnc (s);
        }

        public static void fnc(string s)
        {
            char[] ss = s.ToCharArray();
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i] >= 'a' && ss[i] <= 'z')
                {
                    ss[i] = (char)(ss[i] - 'a' + 'A');
                }
                else if (ss[i] >= 'A' && ss[i] <= 'Z')
                {
                    ss[i] = (char)(ss[i] - 'A' + 'a');
                }
            }
            Console.WriteLine(string.Join("", ss));
        }
    }
}
