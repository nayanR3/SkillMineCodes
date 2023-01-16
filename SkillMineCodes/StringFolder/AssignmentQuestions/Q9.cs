using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    public class Q9
    {
        //9. Write a C# program to count total number of vowels and consonants in a string.
        static void Main(string[] args)
        {
            string s = "hello world";
            fnc (s);
        }

        public static void fnc(string s)
        {
            s = s.ToLower();
            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (
                    s[i] == 'a' ||
                    s[i] == 'e' ||
                    s[i] == 'i' ||
                    s[i] == 'o' ||
                    s[i] == 'u'
                )
                    vowels++;
                else
                    consonants++;
            }
            Console.WriteLine(vowels + " vowels and " + consonants + " consonants");
        }
    }
}
