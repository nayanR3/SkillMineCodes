using System;

namespace ArrayFolder
{
    /*Q2. Count odd element from array*/
    class OddElementCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("\nEnter array elements");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            fun (arr);
        }

        public static void fun(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) c++;
            }
            System.Console.WriteLine("\nOdd element count " + c);
        }
    }
}
