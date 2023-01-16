using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    // 3. Write a C# program to count occurrences of a character in given string.
    public class Q3
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            str = str.Replace(" ", string.Empty);

            sol1 (str);
            //sol2 (str);
        }

        public static void sol1(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }

            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }
        }

        public static void sol2(string s)
        {
            string newS = s.ToLower();
            char[] ca = new char[26];

            for (int i = 0; i < newS.Length; i++)
            {
                char c = newS[i];
                ca[c - 'a']++;
            }

            for (int i = 0; i < ca.Length; i++)
            {
                if (ca[i] > 0)
                {
                    System.Console.WriteLine(ca[i + 'a']);
                }
            }
        }
    }
}
