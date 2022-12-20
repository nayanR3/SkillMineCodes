using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Questions
{
    public class MoveZero
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
            Console.WriteLine("Original Array");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            LeftMove(arr);
            RightMove(arr);
        }

        public static void LeftMove(int[] arr)
        {
            Console.WriteLine("\n\nLeft shift");
            int startIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = i; j > startIndex; j--)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    startIndex++;
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void RightMove(int[] arr)
        {
            Console.WriteLine("\nright shift");
            int startIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    for (int j = i; j > startIndex; j--)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    startIndex++;
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
