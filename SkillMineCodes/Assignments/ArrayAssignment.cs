using System;
using System.Collections;

namespace SkillMineCodes.Assignments
{
    /*Q1. WAP to search for a given number in an array and 
           accordingly print the index if exists */
    class ArrayQ1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine();
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine();
            System.Console.WriteLine("Enter search element among array");
            int x = int.Parse(Console.ReadLine());

            ArrayQ1 p = new ArrayQ1();
            p.fun (arr, x);
        }

        public void fun(int[] arr, int x)
        {
            Console.WriteLine();
            int val = -1;
            bool f = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    f = true;
                    val = i;
                    break;
                }
            }

            if (f == true)
            {
                System
                    .Console
                    .WriteLine("element " + x + " found at " + val + " index");
            }
            else
            {
                System.Console.WriteLine("Not found");
            }
        }
    }

    /*Q2. Write two methods that return the average of an array with following headers.
            i. public static int average(int[] array)
            ii. public static double average(double[] array).
            iii.Write main and invoke the 2 methods. */
    class ArrayQ2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // int array
            int[] iArr = new int[n];
            System.Console.WriteLine("Enter int Array element :");
            for (int i = 0; i < n; i++)
            {
                iArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            System.Console.WriteLine("Entered int Array is :");
            System.Console.WriteLine(string.Join(" ", iArr));

            Console.WriteLine();

            // double array
            double[] dArr = new double[n];
            System.Console.WriteLine("Enter double Array element :");
            for (int i = 0; i < n; i++)
            {
                dArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            System.Console.WriteLine("Entered double Array is :");
            System.Console.WriteLine(string.Join(" ", dArr));

            int avg1 = average(iArr);
            Console.WriteLine();
            System.Console.WriteLine("int array average is " + avg1);
            double avg2 = average(dArr);
            System.Console.WriteLine("double array average is " + avg2);
        }

        public static int average(int[] array)
        {
            int
                s = 0,
                n = array.Length;
            for (int i = 0; i < n; i++)
            {
                s += array[i];
            }
            return s / n;
        }

        public static double average(double[] array)
        {
            double s = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                s += array[i];
            }
            return s / n;
        }
    }

    /*Q3. WAP to print all negative elements in an array and also
          count total number of negative elements in an array. */
    class ArrayQ3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // int array
            int[] arr = new int[n];
            System.Console.WriteLine("Enter int Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            System.Console.WriteLine("Entered int Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ3 p = new ArrayQ3();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            Console.WriteLine();
            int c = 0;
            System.Console.WriteLine("Negative values");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    System.Console.Write(arr[i] + " ");
                    c++;
                }
            }
            System.Console.WriteLine();
            Console.WriteLine();
            System.Console.WriteLine("Count of negative values " + c);
        }
    }

    /*Q4. WAP to put even and odd elements of array in two separate arrays. */
    class ArrayQ4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[n];
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ4 p = new ArrayQ4();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            ArrayList even = new ArrayList();
            ArrayList odd = new ArrayList();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even.Add(arr[i]);
                }
                else
                {
                    odd.Add(arr[i]);
                }
            }
            Console.WriteLine();
            System.Console.WriteLine("Even array");
            foreach (int i in even)
            {
                System.Console.Write(i + " ");
            }
            Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Odd array");
            foreach (int i in odd)
            {
                System.Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    /*Q5. WAP to find the maximum and minimum value in an array.*/
    class ArrayQ5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[n];
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ5 p = new ArrayQ5();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i]) max = arr[i];

                if (min > arr[i]) min = arr[i];
            }

            Console.WriteLine();
            System.Console.WriteLine("Minimum value in array is : " + min);
            System.Console.WriteLine("Maximum value in array is : " + max);
        }
    }

    /*Q6. WAP to find and count total number of duplicate elements in an array.*/
    class ArrayQ6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine();
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ6 p = new ArrayQ6();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
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
            System.Console.WriteLine("Sorted Array");
            System.Console.WriteLine(string.Join(" ", arr));

            Console.WriteLine();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i]) c++;
            }
            System.Console.WriteLine("Count of duplicate elements " + c);
        }
    }

    /*Q7. WAP to print all unique elements in the array.*/
    class ArrayQ7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            System.Console.WriteLine();
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ7 p = new ArrayQ7();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array");
            System.Console.WriteLine(string.Join(" ", arr));
            System.Console.WriteLine();
            System.Console.WriteLine("Unique element");
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] != arr[i])
                {
                    System.Console.Write(arr[i - 1] + " ");
                }
            }
            System.Console.WriteLine(arr[arr.Length - 1]);
            Console.WriteLine();
        }
    }

    /*Q8. WAP to find the second smallest element in an array.*/
    class ArrayQ8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            System.Console.WriteLine();
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ8 p = new ArrayQ8();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            System.Console.WriteLine();
            System
                .Console
                .WriteLine("2nd Smallest element in array is " + arr[1]);
        }
    }

    /*Q9. WAP to count frequency of each element in an array.*/
    class ArrayQ9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            System.Console.WriteLine();
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ9 p = new ArrayQ9();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted array");
            System.Console.WriteLine(string.Join(" ", arr));
            System.Console.WriteLine();
            int c = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] != arr[i])
                {
                    System
                        .Console
                        .WriteLine("Count of " + arr[i - 1] + " is " + c);
                    c = 1;
                }
                else
                {
                    c++;
                }
            }
            System
                .Console
                .WriteLine("Count of " + arr[arr.Length - 1] + " is " + c);
        }
    }

    /*Q10.WAP to merge 2 arrays to 3rd array. 3rd array should not
have elements of same value.*/
    class ArrayQ10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());
            int[] a1 = new int[n];
            int[] a2 = new int[n];

            System.Console.WriteLine();
            Console.WriteLine("Enter 1st Array element");
            for (int i = 0; i < n; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            Console.WriteLine("Enter 2nd Array element");
            for (int i = 0; i < n; i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
            }
            ArrayQ10 p = new ArrayQ10();
            p.fun (a1, a2);
        }

        public void fun(int[] a1, int[] a2)
        {
            // merge array
            int n = a1.Length + a2.Length;
            int[] A = new int[n];

            for (int i = 0; i < n / 2; i++)
            {
                A[i] = a1[i];
            }
            for (int i = n / 2; i < n; i++)
            {
                A[i] = a2[i - (n / 2)];
            }

            // sorting
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int t = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = t;
                    }
                }
            }
            System.Console.WriteLine();
            Console.WriteLine("Sorted Array");
            Console.WriteLine(string.Join(" ", A));

            // remove duplicates
            int[] temp = new int[A.Length];
            int c = 0;
            for (int i = 0; i < n - 1; i++)
            if (A[i] != A[i + 1])
            {
                temp[c++] = A[i];
            }
            temp[c++] = A[n - 1];

            // Modify original array
            for (int i = 0; i < c; i++)
            {
                A[i] = temp[i];
            }

            System.Console.WriteLine();
            Console.WriteLine("Unique Array");
            for (int i = 0; i < c; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
    }

    /*Q11.WAP sort array elements in ascending order.*/
    class ArrayQ11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            System.Console.WriteLine();
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ11 p = new ArrayQ11();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Sorted Array");
            System.Console.WriteLine(string.Join(" ", arr));
        }
    }

    /* Q12. WAP to reverse the array itself, 
            don’t print array in reverse
            I want current array reverse.
            Means e.g.arr[] = [3, 90, 45,29, 37, 78] 
            so your same array must be [78, 37, 29, 45, 90,3] 
            without using temporary array */
    class ArrayQ12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            System.Console.WriteLine();
            System.Console.WriteLine("Enter Array element :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Entered Array is :");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ12 p = new ArrayQ12();
            p.fun (arr);
        }

        public void fun(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int t = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = t;
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Reverse Array");
            System.Console.WriteLine(string.Join(" ", a));
        }
    }

    /*Q13.Write a program to test the equality of two arrays.
          Means e.g arr1[] = [12, 22, 32, 42, 52,62] and 
                    arr2[] = [52, 22, 62, 12, 42, 22] 
          Here both arrays are equal.*/
    class ArrayQ13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());
            int[] a1 = new int[n];
            int[] a2 = new int[n];

            System.Console.WriteLine();
            Console.WriteLine("Enter 1st Array element");
            for (int i = 0; i < n; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            Console.WriteLine("Enter 2nd Array element");
            for (int i = 0; i < n; i++)
            {
                a2[i] = int.Parse(Console.ReadLine());
            }
            ArrayQ13 p = new ArrayQ13();
            p.fun (a1, a2);
        }

        public void fun(int[] a1, int[] a2)
        {
            // sorting 1st array
            for (int i = 0; i < a1.Length - 1; i++)
            {
                for (int j = 0; j < a1.Length - i - 1; j++)
                {
                    if (a1[j] > a1[j + 1])
                    {
                        int t = a1[j];
                        a1[j] = a1[j + 1];
                        a1[j + 1] = t;
                    }
                }
            }
            System.Console.WriteLine();
            Console.WriteLine("Sorted 1st Array");
            Console.WriteLine(string.Join(" ", a1));

            // sorting 2nd array
            for (int i = 0; i < a2.Length - 1; i++)
            {
                for (int j = 0; j < a2.Length - i - 1; j++)
                {
                    if (a2[j] > a2[j + 1])
                    {
                        int t = a2[j];
                        a2[j] = a2[j + 1];
                        a2[j + 1] = t;
                    }
                }
            }
            System.Console.WriteLine();
            Console.WriteLine("Sorted 2nd Array");
            Console.WriteLine(string.Join(" ", a2));

            System.Console.WriteLine();
            bool f = true;
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i])
                {
                    f = false;
                    break;
                }
            }

            if (f == true)
            {
                System.Console.WriteLine("Matched Array");
            }
            else
            {
                System.Console.WriteLine("Unmatched");
            }
        }
    }

    /*Q14.WAP to replace all negative value with its immediate left elements square.
    Means arr[] = [12, 3, -19, 29, 5, -61, 44, 7, -9] 
    Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].*/
    class ArrayQ14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            System.Console.WriteLine();
            Console.WriteLine("Enter  Array element");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            ArrayQ14 p = new ArrayQ14();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            System.Console.WriteLine();
            int i = 0;
            while (i < arr.Length)
            {
                int v = arr[i];
                if (v < 0)
                {
                    arr[i] = arr[i - 1] * arr[i - 1];
                }

                i++;
            }
            System.Console.WriteLine(string.Join(" ", arr));
        }
    }

    /*Q15.WAP to arrange the elements of an given array of integers 
        where all negative integers appear before all the positive integers.*/
    class ArrayQ15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            System.Console.WriteLine();
            Console.WriteLine("Enter  Array element");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Entered Array is");
            System.Console.WriteLine(string.Join(" ", arr));

            ArrayQ15 p = new ArrayQ15();
            p.fun (arr);
        }

        public void fun(int[] arr)
        {
            System.Console.WriteLine();
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
            System.Console.WriteLine("Negative Positive array");
            System.Console.WriteLine(string.Join(" ", arr));
        }
    }
}
