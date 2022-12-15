using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.HW.Dec14
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            String s = "madam";
            char[] ch = s.ToCharArray();
            fun(ch);
        }

        public static void fun(char[] ch)
        {
            int i = 0, j = ch.Length - 1;
            bool flag = true;
            while (i < j)
            {
                while (ch[i] != ch[j])
                {
                    flag = false;
                    break;
                }
                i++;
                j--;
            }

            if (flag == true)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not a Palindrom");
            }
        }
    }
}
