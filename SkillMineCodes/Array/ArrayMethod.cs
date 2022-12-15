using System;
using System.Collections.ObjectModel;

namespace SkillMineCodes.Array
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
        }
    }
}
