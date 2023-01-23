using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.ZobinTest.Week_9
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            fnc(s);
        }
        public static void fnc(string s)
        {
            int i=0,j=s.Length-1;
            bool f=true;

            while(i<j){
                if(s[i]!=s[j]){
                    f=false;
                    break;
                }
                i++;
                j--;
            }

            if(f==true)
            System.Console.WriteLine("Palindrome");
            else
            System.Console.WriteLine("Not Palindrome");
        }
    }
}