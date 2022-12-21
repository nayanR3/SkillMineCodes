using System;

namespace ArrayFolder
{
    /*Q3.WAP to merge 2 array into single array but third array doesn't content duplicate elements.*/
    class MergeTwoArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());
            int[] a1 = new int[n];
            int[] a2 = new int[n];

            Console.WriteLine("\nEnter 1st Array element");
            for (int i = 0; i < n; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEnter 2nd Array element");
            for (int i = 0; i < n; i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
            }
            fun (a1, a2);
        }

        public static void fun(int[] a1, int[] a2)
        {
            // merge array
            int n = a1.Length + a2.Length;
            int[] A = new int[n];

            for (int i = 0; i < n / 2; i++)
            {
                A[i] = a1[i];
            }
            for (int i = n / 2; i < n; i++)
            {
                A[i] = a2[i - (n / 2)];
            }

            // sorting
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int t = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = t;
                    }
                }
            }
            Console.WriteLine("Sorted Array");
            Console.WriteLine(string.Join(" ", A));

            // remove duplicates
            int[] temp = new int[A.Length];
            int c = 0;
            for (int i = 0; i < n - 1; i++)
            if (A[i] != A[i + 1]) temp[c++] = A[i];

            temp[c++] = A[n - 1];

            // Modify original array
            for (int i = 0; i < c; i++) A[i] = temp[i];

            Console.WriteLine("Unique Array");
            for (int i = 0; i < c; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
