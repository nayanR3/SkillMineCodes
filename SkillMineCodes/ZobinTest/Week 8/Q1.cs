using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.ZobinTest.Week_8
{
    // check number is co-prime or not (gcd calculate)
    public class Q
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int ans = fnc(a, b);
            if (ans == 1)
                System.Console.WriteLine("Co-Prime");
            else
                System.Console.WriteLine("Not Co-Prime");
        }

        public static int fnc(int a, int b)
        {
            if (a == b) return a;

            if (a > b) return fnc(a - b, b);

            return fnc(a, b - a);
        }
    }

    public class Q1
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            fnc (a, b);
        }

        static void fnc(int a, int b)
        {
            bool f = true;
            for (int i = 2; i < Math.Max(a, b); i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    f = false;
                    break;
                }
            }

            if (f == true)
                System.Console.WriteLine("Co-Prime");
            else
                System.Console.WriteLine("Not Co-Prime");
        }
    }
}
