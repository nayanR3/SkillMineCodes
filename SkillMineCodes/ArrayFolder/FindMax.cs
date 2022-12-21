using System;

namespace SkillMineCodes.ArrayFolder
{
    internal class FindMax
    {
        public static void Max(int[] a)
        {
            int m = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (m < a[i])
                {
                    m = a[i];
                }
            }
            Console.WriteLine (m);
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Max (a);
        }
    }
}
