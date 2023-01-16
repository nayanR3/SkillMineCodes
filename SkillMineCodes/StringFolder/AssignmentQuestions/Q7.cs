using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    //7. Write a C# program to trim trailing white space characters in a string.
    public class Q7
    {
        static void Main(string[] args)
        {
            string s = "       hello     ";
            fnc(s);
        }
        public static void fnc(string s){
            s=s.TrimEnd;
            System.Console.WriteLine(s);
        }
    }
}