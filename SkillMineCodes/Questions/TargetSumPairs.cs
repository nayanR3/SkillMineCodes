using System;
using System.Collections.Generic;

namespace SkillMineCodes.Questions
{
    public class Pairs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter array size");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnetr array element");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEneter target sum");
            int k = int.Parse(Console.ReadLine());
            pairsFinder (arr, k);
        }

        public static void pairsFinder(int[] arr, int k)
        {
            // sort array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Pair of sum {k}");
            int
                l = 0,
                h = arr.Length - 1;
            while (l < h)
            {
                if (arr[l] + arr[h] > k)
                {
                    h--;
                }
                else if (arr[l] + arr[h] < k)
                {
                    l++;
                }
                else
                {
                    Console.WriteLine($"{arr[l]} + {arr[h]} = {k}");
                    l++;
                    h--;
                }
            }
        }
    }
}
