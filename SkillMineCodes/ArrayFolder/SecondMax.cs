using Internal;
using System.Dynamic;
using System;

class Program
{
    static void Main(string[] args)
    {
        // int[] arr = new int[] { 5, 10, 3, 8, 15, 20 };

        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int num in arr)
        {
            if (num > max)
            {
                secondMax = max;
                max = num;
            }
            else if (num > secondMax && num != max)
            {
                secondMax = num;
            }
        }

        Console.WriteLine("Second maximum value is: " + secondMax);
    }
}
