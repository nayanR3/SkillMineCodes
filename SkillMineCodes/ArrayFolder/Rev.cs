using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 5, 10, 43, 8, 15, 20 };

        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        Console.WriteLine(max);
    }
}
