using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.StringFolder.AssignmentQuestions
{
    // 11. Write a C# program to reverse order of words in a given string.
    public class Q11
    {
        static void Main(string[] args)
        {
            string s = "Hey how are you";
            fnc (s);
        }

        public static void fnc(string s)
        {
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                rev(words[i]);
            }
        }

        public static void rev(string word)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=word.Length-1; i>=0; i--){
                sb.Append(word[i]);
            }
            System.Console.Write(sb.ToString()+" ");
        }
    }
}
