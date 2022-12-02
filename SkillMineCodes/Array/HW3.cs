using SkillMineCodes.Nested_Loop;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Array
{
    /*Q1.WAP to sort character type of array.*/
    class SortCharArr
    {
        static void Main(string[] args)
        {
            // Creating a Char Array
            System.Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());
            char[] charArray = new char[n];

            for (int i = 0; i < n; i++)
            {
                charArray[i] = Convert.ToChar(Console.ReadLine());
            }
            SortCharArr o = new SortCharArr();
            o.fun(charArray);
        }

        public void fun(char[] charArray)
        {
            // Displaying Array before Sorting
            Console.WriteLine("**Char Array Before Sorting**");
            Console.WriteLine(string.Join(" ", charArray));

            // Sorting the Array
            for (int i = 0; i < charArray.Length - 1; i++)
            {
                for (int j = 0; j < charArray.Length - 1 - i; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                    {
                        char t = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = t;
                    }
                }
            }

            // Displaying Array after Sorting
            Console.WriteLine("**Char Array After Sorting**");
            Console.WriteLine(string.Join(" ", charArray));
        }
    }



    /*Q2.WAP to create integer type of array and sort asc and dec order.*/
    class SortAscDes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            SortAscDes s = new SortAscDes();
            s.fun(a);
        }

        public void fun(int[] arr)
        {
            int n = arr.Length;

            // sorting the array
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                       int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            // first half in ascending order
            for (int i = 0; i < n / 2; i++)
                Console.Write(arr[i] + " ");

            // second half in descending order
            for (int j = n - 1; j >= n / 2; j--)
                Console.Write(arr[j] + " ");

        }
    }




    /*Q3.WAP to merge 2 array into single array but third array doesn't content duplicate elements.*/
    class MergeArr
    {
            static void Main(string[] args)
            {
            Console.WriteLine("Size of array");
                int n = int.Parse(Console.ReadLine());
                int[] a1 = new int[n];
                int[] a2 = new int[n];

            Console.WriteLine("Enter 1st Array element");
                for (int i = 0; i < n; i++)
                {
                    a1[i] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Enter 2nd Array element");
            for (int i = 0; i < n; i++)
                {
                    a2[i] = int.Parse(Console.ReadLine());
                }
                MergeArr s = new MergeArr();
                s.fun(a1,a2);
            }
        public void fun(int[] a1, int[]a2)
        {
            // merge array
            int n = a1.Length + a2.Length;
            int[] A = new int[n];

            for(int i=0; i<n/2; i++)
            {
                A[i] = a1[i];
            }
            for (int i = n / 2; i < n; i++)
            {
                A[i] = a2[i - (n / 2)];
            }

            // sorting
            for(int i=0; i<A.Length-1; i++)
            {
                for(int j=0; j<A.Length-1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int t = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = t;
                    }
                }
            }
            Console.WriteLine("Sorted Array");
            Console.WriteLine(string.Join(" ",A));

            // remove duplicates

            int[] temp = new int[A.Length];
            int c = 0;
            for (int i = 0; i < n - 1; i++)
                if (A[i] != A[i + 1])
                    temp[c++] = A[i];

            temp[c++] = A[n - 1];

            // Modify original array
            for (int i = 0; i < c; i++)
                A[i] = temp[i];


            Console.WriteLine("Unique Array");
            for (int i = 0; i<c; i++)
            {
                Console.Write(A[i]+" ");
            }
            Console.WriteLine();
        }
    }


    /*Q4. wap to find out the addition of two matrix.*/
    class MatrixAddition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row and column");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] mat1 = new int[n, m];
            int[,] mat2 = new int[n, m];
            int[,] result = new int[n, m];

            // taking input from user
            Console.WriteLine();
            Console.WriteLine("Enter 1st Matrix");
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Enter 2nd Matrix");
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            // display Matrix
            System.Console.WriteLine("1st Matrix");
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    System.Console.Write(mat1[i, j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.WriteLine();
            System.Console.WriteLine("2nd Matrix");
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    System.Console.Write(mat2[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            MatrixAddition p = new MatrixAddition();
            p.fun(mat1, mat2, result);
        }

        public void fun(int[,] mat1, int[,] mat2, int[,] result)
        {
            // addition
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = mat1[i, j] + mat2[i, j];
                }
            }

            // display addition
            Console.WriteLine();
            System.Console.WriteLine("result Matrix");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    System.Console.Write(result[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }


    /*Q5.wap to find out the columnwise sum.*/
    class MatrixColumnSum
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter row & column");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] mat1 = new int[n, m];
            int[] res = new int[n];

            // taking input from user
            System.Console.WriteLine();
            System.Console.WriteLine("Enter matrix values");
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // display Matrix
            System.Console.WriteLine();
            System.Console.WriteLine("1st Matrix");
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    System.Console.Write(mat1[i, j] + " ");
                }
                System.Console.WriteLine();
            }
            MatrixColumnSum p = new MatrixColumnSum();
            p.fun(mat1, res);
        }

        public void fun(int[,] mat1, int[] res)
        {
            // addition
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                int s = 0;
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    s += mat1[j, i];
                }
                res[i] = s;
            }

            // display addition
            System.Console.WriteLine();
            System.Console.WriteLine("Column-wise sum");
            System.Console.WriteLine(string.Join(" ", res));
        }
    }


    // 1 2 3
    // 4   6
    // 7 8 9

    /*Q6.to display pattern using 2d array.*/
    class MatrixP1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter row & column");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];

            // taking input from user
            System.Console.WriteLine();
            System.Console.WriteLine("Enter matrix values");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // display Matrix
            System.Console.WriteLine();
            System.Console.WriteLine("Matrix");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    System.Console.Write(mat[i, j] + " ");
                }
                System.Console.WriteLine();
            }

            MatrixP1 p = new MatrixP1();
            p.fun(mat);
        }

        public void fun(int[,] mat)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Pattern");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (
                        i == 0 ||
                        j == 0 ||
                        i == mat.GetUpperBound(0) ||
                        j == mat.GetUpperBound(1)
                    )
                    {
                        System.Console.Write(mat[i, j]
                            +" ");
                    }
                    else
                    {
                        System.Console.Write("  ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }


    class MatrixP2
    {

    }
}
