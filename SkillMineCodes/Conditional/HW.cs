using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Conditional
{

    /*wap to check given no is negative, positive or zero.*/
    class NPZero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                System.Console.WriteLine("zero");
            }
            else
            {
                var check = n > 0 ? "Positive" : "Negative";
                System.Console.WriteLine(check);
            }
        }
    }


    /*wap to check given no is divisible by 3 or 9*/
    class DivisibleBy3or9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            var check = n % 3 == 0 && n % 9 == 0 ? "Divisible by both" : "Not divisible by both";
            System.Console.WriteLine(check);
        }
    }


    /*Day number*/
    class DayNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
                System.Console.WriteLine("Monday");
            else if (n == 2)
                System.Console.WriteLine("Tuesday");
            else if (n == 3)
                System.Console.WriteLine("Wednesday");
            else if (n == 4)
                System.Console.WriteLine("Thursday");
            else if (n == 5)
                System.Console.WriteLine("Friday");
            else if (n == 6)
                System.Console.WriteLine("Saturday");
            else if (n == 7)
                System.Console.WriteLine("Sunday");
        }
    }


    /*find max between three number*/
    class max
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
                System.Console.WriteLine(a + " is greater than " + b + " and " + c);
            else if (b > a && b > c)
                System.Console.WriteLine(b + " is greater than " + a + " and " + c);
            else
                System.Console.WriteLine(c + " is greater than " + a + " and " + b);
        }
    }


    /*percentage find*/
    class percentage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter Marks");
            int Maths = int.Parse(Console.ReadLine());
            int Physics = int.Parse(Console.ReadLine());
            int Chemistry = int.Parse(Console.ReadLine());
            int Biology = int.Parse(Console.ReadLine());

            double per = (Maths + Physics + Chemistry + Biology) * 100 / 400;
            System.Console.WriteLine(per);

            if (per >= 90)
                System.Console.WriteLine("Distinction");
            else if (per >= 75)
                System.Console.WriteLine("First-class");
            else if (per >= 60)
                System.Console.WriteLine("Second-class");
            else if (per >= 40)
                System.Console.WriteLine("Third-class");
            else
                System.Console.WriteLine("Fail");
        }

    }


    /*choose operation*/
    class MathsOperation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter no's");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Chooises :\n 1: +\n 2: -\n 3: *\n 4: /\n");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    System.Console.WriteLine(n + " + " + m + " = " + (n + m));
                    break;

                case '-':
                    System.Console.WriteLine(n + " - " + m + " = " + (n - m));
                    break;

                case '*':
                    System.Console.WriteLine(n + " * " + m + " = " + (n * m));
                    break;

                case '/':
                    System.Console.WriteLine(n + " / " + m + " = " + (n / m));
                    break;

                default:
                    System.Console.WriteLine("Invalid");
                    break;
            }
        }

    }


    /*vowel check*/
    class VowelCheck
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter character");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'e':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'i':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'o':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'u':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'A':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'E':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'I':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'O':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                case 'U':
                    System.Console.WriteLine(ch + " is vowel");
                    break;
                default:
                    System.Console.WriteLine("invalid");
                    break;
            }
        }

    }


    /*checked even-odd*/
    class EvenOdd
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            var check = n % 2 == 0 ? "Even" : "Odd";
            System.Console.WriteLine(check);
        }
    }
}
