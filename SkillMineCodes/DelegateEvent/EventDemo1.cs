using System;

namespace SkillMineCodes.DelegateEvent
{
    // declaration of delegate
    public delegate int Myd1(int n1, int n2);

    public class Code
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    public class Helper
    {
        public event Myd1 Addition;

        public event Myd1 Subtraction;

        public event Myd1 Multiplication;

        public int M1(int a, int b)
        {
            return Addition(a, b); // raise an event
        }

        public int M2(int a, int b)
        {
            return Subtraction(a, b);
        }

        public int M3(int a, int b)
        {
            return Multiplication(a, b);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Code c = new Code();
            Helper h = new Helper();
            h.Addition += new Myd1(c.Add);
            h.Subtraction += new Myd1(c.Sub);
            h.Multiplication += new Myd1(c.Multiply);

            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("Select option");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    int sum = h.M1(a, b);
                    Console.WriteLine (sum);
                    break;
                case 2:
                    int m = h.M2(a, b);
                    Console.WriteLine (m);
                    break;
                case 3:
                    int sub = h.M3(a, b);
                    Console.WriteLine (sub);
                    break;
                default:
                    Console.WriteLine("No output");
                    break;
            }
        }
    }
}
