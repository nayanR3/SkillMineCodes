using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Loop
{


    /*wap to print value between 1 to 10*/
    class OneToTen
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
                System.Console.WriteLine(i);
        }
    }


    /*wap to print value between 75 to 61*/
    class ValueBetween
    {
        public static void Main(string[] args)
        {
            for (int i = 75; i >= 61; i--)
                System.Console.WriteLine(i);
        }
    }


    /*wap to print sum between 1 to 10*/
    class OneToTenSum
    {
        public static void Main(string[] args)
        {
            int s = 0;
            for (int i = 1; i <= 10; i++)
                s += i;
            System.Console.WriteLine(s);
        }
    }


    /*wap to print odd numbers between 120 to 81*/
    class OddBetween
    {
        public static void Main(string[] args)
        {
            for (int i = 120; i >= 81; i--)
                if (i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
        }
    }


    /*wap to count odd numbers between 1 to 10*/
    class CountOddBetween
    {
        public static void Main(string[] args)
        {
            int c = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    c++;
                }
            }
            System.Console.WriteLine(c);
        }
    }


    /*table of given number*/
    class Table
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                System.Console.WriteLine(n + " * " + i + " = " + (n * i));
        }
    }


    /*sum of factor of given numbe*/
    class SumFactor
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    s += i;
            }
            System.Console.WriteLine(s);
        }
    }


    /*number divisible by 3 & 5 between 1 to 50*/
    class DivisibleBy3And5
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());

            var check = n % 5 == 0 && n % 3 == 0 ? true : false;
            System.Console.WriteLine(check);
        }
    }
}
