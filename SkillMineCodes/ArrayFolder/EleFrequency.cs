using System;

namespace ArrayFolder
{
    /*Q.Frequency of given element.*/
    class EleFrequency
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(System.Console.ReadLine());
            frequency (a, x);
        }

        public static void frequency(int[] a, int x)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++) if (a[i] == x) count++;

            Console.WriteLine("Frequency of " + x + " is " + count);
        }
    }
}
