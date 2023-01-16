using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    // 4. Write a C# program to trim leading white space characters in a string.
    public class Q4
    {
        static void Main(string[] args)
        {
            string s = "       hello     ";
            fnc(s);
        }
        public static void fnc(string s){
            s=s.Trim();
            System.Console.WriteLine(s);
        }
    }
}