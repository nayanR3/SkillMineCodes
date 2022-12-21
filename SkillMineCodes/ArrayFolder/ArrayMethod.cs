using System;

namespace SkillMineCodes.ArrayQuestions
{
    public class ArrayMethod
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 21, 11, 98, 8, 3, 2003, 24, 12, 20, 26, 1, 97 };
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            System.Console.WriteLine("\nSorted Array");
            Array.Sort (arr);
            System.Console.WriteLine(string.Join(" ", arr));

            System.Console.WriteLine(value: "\nReverse Array");
            Array.Reverse (arr);
            System.Console.WriteLine(string.Join(" ", arr));

            System.Console.WriteLine("\nFind first grater value than 50");
            int r1 = Array.Find(arr, ele => ele > 50);
            System.Console.WriteLine (r1);

            System.Console.WriteLine("\nFind all grater value than 10");
            int[] r2 = Array.FindAll(arr, ele => ele > 10);
            System.Console.WriteLine(string.Join(" ", r2));
        }
    }
}
