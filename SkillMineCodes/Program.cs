using System;
using System.Text;

namespace SkillMineCodes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 21, 11, 98, 03, 08, 20, 34, 6 };
            Console.WriteLine("Original Array");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            fun(arr);
        }

        /*public static void fun(int[] arr)
        {
            int middle = arr.Length / 2;
            //Console.WriteLine(n);
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];


            for (int i = middle; i < arr.Length; i++)
            {
                arr1[i- middle] = arr[i];
            }

            for (int i = 0; i < middle; i++)
            {
                arr2[i] = arr[i];
            }

            Console.WriteLine();
            Console.WriteLine("\nHalf reverse array");
            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
            foreach (int i in arr2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }*/



        public static void fun(int[] arr)
        {
            Console.WriteLine();
            int middle = arr.Length/2;
            Console.WriteLine("Half size "+middle);

            for (int i = 0; i < middle; i++)
            {
                int temp = arr[i];
                arr[i] = arr[i + middle];
                arr[i + middle] = temp;
            }

            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}


