using System;
using System.Collections;
using System.Text;

namespace SkillMineCodes
{
    public class Program
    {
        static void Main()
        {
            int[] arr = { 12, 4, 2, 10, 5, 1 };
            int n = 16;

            int sum = arr[0];
            int start = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                sum = sum + arr[i];

                while (sum > n && start <= i - 1)
                {
                    sum = sum - arr[start];

                    start++;
                }

                if (sum == n)
                {
                    Console.WriteLine("Continuous sub array of whose sum is " + n);

                    for (int j = start; j <= i; j++)
                    {
                        Console.WriteLine(arr[j] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }

    }

}
