using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Questions
{
    public class MaxInRowCol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of columns");
            int col = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Matrix element");
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine($"enter {i + 1} row");
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            display (arr);
            max (arr);
        }

        public static void max(int[,] arr)
        {
            Console.WriteLine("\nMax Element in each row");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = arr[i, 0];
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine($"Max element in {i} row is {max}");
            }
        }

        public static void display(int[,] arr)
        {
            Console.WriteLine("\nDisplay Matrix");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.Write(arr[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
