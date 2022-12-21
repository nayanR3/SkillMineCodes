using System;

namespace ArrayFolder
{
    /*Q7. Display even index element*/
    class DisplayEvenIndex
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("\nEnter values");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Fun (a);
        }

        public void Fun(int[] a)
        {
            for (int i = 0; i < a.Length; i += 2)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
