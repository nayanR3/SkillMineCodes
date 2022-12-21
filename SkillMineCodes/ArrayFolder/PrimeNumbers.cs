using System;

namespace ArrayFolder
{
    /*Q10. Prime no's of array*/
    class PrimeNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Fun (a);
        }

        public static void Fun(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                bool f = true;
                for (int j = 2; j * j <= a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        f = false;
                    }
                }
                if (f == true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
