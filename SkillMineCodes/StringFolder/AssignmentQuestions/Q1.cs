using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    //1. WAP to split string into 2 tokens where string is “HELLO$WORLD”
    public class Q1
    {
        static void Main(string[] args)
        {
            string str = "HELLO$WORLD";
            sol (str);
        }

        public static void sol(string s)
        {
            string[] arr = s.Split('$');
            System.Console.WriteLine(string.Join(" ",arr));
        }
    }
}
