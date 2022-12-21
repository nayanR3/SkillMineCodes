using System;
using System.Collections;

namespace ArrayFolder
{
    public class SeparateEvenOdd
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", a));
            fun (a);
        }

        public static void fun(int[] a)
        {
            ArrayList odd = new ArrayList();
            ArrayList even = new ArrayList();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even.Add(a[i]);
                }
                else
                {
                    odd.Add(a[i]);
                }
            }

            foreach (int i in odd)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (int i in even)
            {
                Console.Write(i + " ");
            }
        }
    }
}
