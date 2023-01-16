using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    public class Q10
    {
        // 10. Write a C# program to find reverse of a string.
        static void Main(string[] args)
        {
            string s = "hello";
            fnc (s);
        }

        public static void fnc(string s)
        {
            StringBuilder sb = new StringBuilder();
            for(int i =s.Length-1; i>=0; i--){
                sb.Append(s[i]);
            }
            System.Console.WriteLine(sb.ToString());
        }
    }
}