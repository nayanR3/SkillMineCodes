using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.OOPS
{
    internal class RefOutParam
    {

        // Using Ref Keyword
        /*static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;   // b-> a
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before call the method a={a} , b={b}");
            Swap(ref a, ref b); // referecne  / address
            Console.WriteLine($"after call the method a={a} , b={b}");
        }*/



        // Using Out Keyword
        /*static void Calc(int a, int b, out int sum, out int sub, out int multiply)
        {
            sum = a + b;
            sub = a - b;
            multiply = a * b;
        }
        static void Main(string[] args)
        {
            int a = 15, b = 10, sum, sub, mul;
            Calc(a, b, out sum, out sub, out mul);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);

            Console.WriteLine();

            int x = 10, y = 5;
            Calc(x, y, out sum, out sub, out mul);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);

        }*/



        // Using Param Keyword
        /*static void AcceptNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            AcceptNames("Amol", "Kishor");
            AcceptNames("Amol", "Kishor", "Ajay");
            AcceptNames("Amol", "Kishor", "Suraj", "Rohan");

        }*/


    }
}
