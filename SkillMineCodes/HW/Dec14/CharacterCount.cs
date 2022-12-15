using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.HW.Dec14
{
    public class CharacterCount
    {
        public static void Main(string[] args)
        {
            String s = "nayanRnn";
            char[] chArr = s.ToCharArray();
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());
            fun(chArr, ch);
        }

        public static void fun(char[] chArr, char ch)
        {
            int c = 0;
            for (int i = 0; i < chArr.Length; i++)
            {
                if (chArr[i] == ch)
                {
                    c++;
                }
            }
            Console.WriteLine($"Count of {ch} char is {c}");
        }
    }
}
