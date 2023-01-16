using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    // 5. Write a C# program to count total number of words in a string.
    public class Q5
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            fnc (s);
        }

        public static void fnc(string s)
        {
            char[] ch = s.ToCharArray();
            int c=0;
            for(int i=0; i<ch.Length; i++){
                if(ch[i]!=' ')
                c++;
            }
            System.Console.WriteLine(c);
        }
    }
}
