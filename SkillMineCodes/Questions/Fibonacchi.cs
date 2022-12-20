using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Questions
{
    public class Fibonacchi
    {
        public static void Main(string[] args)
        {
            Console.Write("Enetr number : ");
            int n = int.Parse(Console.ReadLine());

            fib(n);
        }

        public static void fib(int n)
        {
            int a = 0, b = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                int c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
