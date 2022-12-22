using System;

namespace SkillMineCodes.Loops.Do_While
{
    /*wap to print value between 1 to 10*/
    class OneToTen
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }


    /*wap to print value between 75 to 61*/
    class ValueBetween
    {
        static void Main(string[] args)
        {
            int i = 75;
            while (i >= 61)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }


    /*wap to print sum between 1 to 10*/
    class OneToTenSum
    {
        static void Main(string[] args)
        {
            int i = 1, s = 0;
            while (i <= 10)
            {
                s += i;
                i++;
            }
            Console.WriteLine(s);
        }
    }


    /*wap to print odd numbers between 120 to 81*/
    class OddBetween
    {
        static void Main(string[] args)
        {
            int i = 120;
            while (i >= 81)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
        }
    }


    /*wap to count odd numbers between 1 to 10*/
    class CountOddBetween
    {
        static void Main(string[] args)
        {
            int i = 1, c = 0;
            while (i <= 10)
            {
                if (i % 2 != 0)
                {
                    c++;
                }
                i++;
            }
            Console.WriteLine(c);
        }
    }


    /*table of given number*/
    class Table
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(n * i);
                i++;
            }
        }
    }


    /*sum of factor of given numbe*/
    class SumFactor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                    System.Console.WriteLine(i);
                i++;
            }
        }
    }


    /*number divisible by 3 & 5 between 1 to 50*/
    class DivisibleBy3And5
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 50)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    System.Console.WriteLine(i);
                i++;
            }
        }
    }
}
