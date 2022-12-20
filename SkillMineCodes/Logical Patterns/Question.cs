using SkillMineCodes.AccessModifiers;
using SkillMineCodes.HW.Dec14;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillMineCodes.Logical_Patterns
{
    //1. Display sum of two integers. 
    public class Question01
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
        }
    }



    //2. Display numbers from 1 to 100.
    public class Question02
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }



    //3. Display all even numbers from 1 to 100.
    public class Question03
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }



    //4. Display all odd numbers from 1 to 100.
    public class Question04
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }



    /*5. Accept starting number ‘fromNum’ and end number ‘toNum’ and find odd numbers starting
from ‘fromNum’ till ‘toNum’.*/
    public class Question05
    {
        static void Main()
        {
            int fromNum = int.Parse(Console.ReadLine());
            int toNum = int.Parse(Console.ReadLine());
            for (int i = fromNum; i <= toNum; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }



    //6. Find maximum number from given 3 numbers
    public class Question06
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b & a > c)
            {
                Console.WriteLine($"{a} is grater");
            }
            else if (b > c & b > a)
            {
                Console.WriteLine($"{b} is grater");
            }
            else
            {
                Console.WriteLine($"{c} is grater");
            }
        }
    }



    //7. Add numbers 1 to 20 to array.
    public class Question07
    {
        static void Main()
        {
            int[] arr = new int[20];
            for (int i = 1; i <= 20; i++)
            {
                arr[i - 1] = i;
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }



    //8. Find first 10 even numbers.
    public class Question08
    {
        static void Main()
        {
            int c = 0;
            int i = 1;
            do
            {
                if (i % 2 == 0 && c != 10)
                {
                    Console.WriteLine(i);
                    c++;
                }
                i++;
            } while (c < 10);
        }
    }



    //9. Display maximum number from array of 10 numbers
    public class Question09
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 21, 11, 98, 3, 8, 25, 5 };
            int m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                {
                    m = arr[i];
                }
            }
            Console.WriteLine(m);
        }
    }



    //10. Print alternate number from an array
    public class Question10
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 21, 11, 98, 3, 8, 25, 5 };
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }



    //11. Create table of a number. 
    public class Question11
    {
        static void Main()
        {
            int n = 12;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i * n + " ");
            }
            Console.WriteLine();
        }
    }



    //12. Find if given number is odd or even.
    public class Question12
    {
        static void Main()
        {
            int n = 12;
            if (n % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }



    //13. Find if given number is prime or not.
    public class Question13
    {
        static void Main()
        {
            int n = 11;
            bool f = true;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    f = false;
                    break;
                }
            }

            if (f == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }



    //14. Calculate factorial of a number.
    public class Question14
    {
        static void Main()
        {
            int n = 5;
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);
        }
    }



    //15. Accept two numbers a and b.Find value of a**b
    public class Question15
    {
        static void Main()
        {
            int a = 2, b = 5;
            int s = 1;
            while (b > 0)
            {
                s *= a;
                b--;
            }
            Console.WriteLine(s);
        }
    }



    //16. Count number of digits in any number.
    public class Question16
    {
        static void Main()
        {
            int n = 2345;
            int c = 0;
            while (n != 0)
            {
                c++;
                n /= 10;
            }
            Console.WriteLine(c);
        }
    }



    //17. Accept radius of a circle.Display area of a circle.
    public class Question17
    {
        static void Main()
        {
            int r = 3;
            Console.WriteLine("Area of circle " + (3.14 * r * r));
        }
    }



    //18. Accept length and breadth of a rectangle and find perimeter.
    public class Question18
    {
        static void Main()
        {
            int length = 3, width = 5;
            Console.WriteLine("Parimeter of rectangle is " + 2 * (length + width));
        }
    }



    //19. Accept two angles of triangle and find third angle.
    public class Question19
    {
        static void Main()
        {
            int a = 45;
            int b = 60;

            Console.WriteLine($"Third angle of triangle is {180 - a - b}");
        }
    }



    //20. Find maximum number from array of 10 numbers.
    public class Question20
    {
        static void Main()
        {
            int[] arr = { 21, 11, 98, 26, 12, 20, 8, 3, 23, 25 };
            int m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m < arr[i])
                    m = arr[i];
            }
            Console.WriteLine(m);
        }
    }



    //21. Find minimum number from array of 10 numbers.
    public class Question21
    {
        static void Main()
        {
            int[] arr = { 21, 11, 98, 26, 12, 20, 8, 3, 23, 25 };
            int m = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (m > arr[i])
                    m = arr[i];
            }
            Console.WriteLine(m);
        }
    }



    //22. Reverse an array of 5 numbers.
    public class Question22
    {
        static void Main()
        {
            int[] arr = { 21, 11, 98, 24, 12 };

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int t = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = t;
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

        }
    }



    //23. Swap values of two interger variables using third variable.
    public class Question23
    {
        static void Main()
        {
            int a = 10, b = 20;
            Console.WriteLine($"a : {a} & b : {b}");

            int t = a;
            a = b;
            b = t;
            Console.WriteLine($"a : {a} & b : {b}");
        }

    }



    //24. Swap values of two integer variables without using third variable.
    public class Question24
    {
        static void Main()
        {
            int a = 10, b = 20;
            Console.WriteLine($"a : {a} & b : {b}");

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a : {a} & b : {b}");

        }
    }



    //25. Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ….. k.where k<n . n is entered by user
    public class Question25
    {
        static void Main()
        {
            int n = 10, a = 0, b = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a);
                int t = a + b;
                a = b;
                b = t;
            }
        }
    }



    //26. Generate Fibonacci series for first n terms.
    public class Question26
    {
        static void Main()
        {
            int n = 10, a = 0, b = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a);
                int t = a + b;
                a = b;
                b = t;
            }
        }
    }



    //27. Find duplicate numbers in an array of integers.
    public class Question27
    {
        // logic -> sort and find duplicates
        /*static void Main()
        {
            int[] arr = { 21, 11, 98, 26, 20, 8, 3, 21, 3, 23, 25, 95, 98 };
            // sort
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length - i-1 ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    Console.WriteLine(arr[i - 1]);
            }
        }*/


        // logic -> use extra array for store occurence & print value has occurence>1
        static void Main()
        {
            int[] arr = { 21, 11, 98, 26, 21, 21, 3, 98, 20, 8, 3, 21, 3, 23, 25, 95, 98 };
            int[] ans = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                ans[arr[i]]++;
            }

            for (int i = 0; i < ans.Length; i++)
            {
                if (ans[i] > 1)
                    Console.WriteLine(i);
            }
        }
    }



    //28. Convert decimal number to binary.
    public class Question28
    {
        static void Main()
        {
            int n = 20;
            int[] size = new int[40];
            int index = 0;
            while (n != 0)
            {
                size[index++] = n % 2;
                n /= 2;
            }
            for (int i = index - 1; i >= 0; i--)
                Console.Write(size[i] + " ");
            Console.WriteLine();
        }
    }



    //29. Check if two arrays (of integers) are equal.
    public class Question29
    {
        static void Main()
        {
            int[] a1 = { 21, 11, 98 };
            int[] a2 = { 21, 11, 99 };

            // sort a1
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
            foreach (int i in a1)
                Console.Write(i + " ");
            Console.WriteLine();

            // sort a2
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
            foreach (int i in a2)
                Console.Write(i + " ");
            Console.WriteLine();

            // compare
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
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not eqhal");
            }
        }
    }



    //30. Remove given element from an array.
    public class Question30
    {
        static void Main()
        {
            int n = 11;
            int[] arr = { 21, 11, 98, 26, 20, 8, 3, 23, 25, 95 };
            Console.WriteLine("Original Array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int si = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != n)
                {
                    si++;
                }
                else
                {
                    break;
                }
            }

            for (int i = si; i < arr.Length - 1; i++)
            {
                int t = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = t;
            }

            Console.WriteLine($"\nAfter delete {n}");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }



    //31. Check if given number is Armstrong or not.
    public class Question31
    {
        static void Main()
        {
            int n = 371;
            int s = 0, copy = n;
            while (copy != 0)
            {
                int r = copy % 10;
                s += r * r * r;
                copy /= 10;
            }

            if (s == n)
            {
                Console.WriteLine("number is Armstrong");
            }
            else
            {
                Console.WriteLine("Not armstrong number");
            }
        }
    }



    //32. Find sum of all digits of a number.
    public class Question32
    {
        static void Main()
        {
            int n = 12345, s = 0;
            while (n != 0)
            {
                int r = n % 10;
                s += r;
                n /= 10;
            }
            Console.WriteLine(s);
        }
    }



    //33. Count number of occurrences of a number in an array
    public class Question33
    {
        static void Main()
        {
            int n = 11;
            int[] arr = { 21, 11, 98, 26, 20, 8, 3, 11, 23, 25, 11, 95 };

            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                    c++;
            }
            Console.WriteLine(c);
        }
    }



    //34. Find out given number is palindrome or not.
    public class Question34
    {
        static void Main()
        {
            int n = 1221;
            int copy = n, s = 0;

            while (copy != 0)
            {
                int r = copy % 10;
                s = s * 10 + r;
                copy /= 10;
            }

            if (s == n)
            {
                Console.WriteLine($"number {n} is palindrom");
            }
            else
            {
                Console.WriteLine($"number {n} is not palindrom");
            }
        }
    }



    /*35. Find pair of elements in array whose number is given number.
        e.g.Given array is { 4,5,7,1,2,3,0}
        If number given is 7. Then pairs whose sum is equal to given
        number are – (4,3) (5,2) (7,0) */
    public class Question35
    {
        static void Main()
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
            pairsFinder(arr, k);
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
            int l = 0, h = arr.Length - 1;
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



    /*36. Find a continuous sub array whose sum is equal to given number.
    e.g. if given array is { 12 ,4, 2, 10 , 5 , 1 }
        and given number is 16 then sum of subarray { 4,2,10}
        and {10, 5,1} is equal to given number.*/
    /*public class Question36
    {
        static void Main()
        {
            int[] arr = { 12, 4, 2, 10, 5, 1 };
            int sum = 16, n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int currentSum = arr[i];

                if (currentSum == sum)
                {

                    Console.WriteLine("Sum found at " + arr[i]);
                }
                else
                {
                    // Try all subarrays starting with 'i'
                    int ci = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        currentSum += arr[j];
                        ci++;
                        if (currentSum == sum)
                        {
                           for(int x=i; x<ci; x++)
                            {
                                Console.Write(arr[x]+" ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }*/



    /*37. Move zeros to beginning or end of array.
        e.g. if given array is { 2 , 10 , 0 ,5 ,3, 0, 4 ,1}
    then output array should be
        a. { 0,0,2,10,5,3,4,1}
        b. {2,10,5,3,4,1,0,0}*/
    public class Question37
    {
        static void Main()
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




    /*38. Reverse and add till you get palindrome.
        If 7325 is given number then,
        7325 (Input Number) + 5237 (Reverse Of Input Number) = 12562
        12562 + 26521 = 39083
        39083 + 38093 = 77176
        77176 + 67177 = 144353
        144353 + 353441 = 497794 (Palindrome)*/

    /*39. Append one array to another array.
    If array1 is { 5,6,7,8}
and array 2 is { 9 ,10, 11, 12}
    resultant array will be { 5,6,7,8,9,10,11,12}*/

    //40.Sort array of 5 integers.

    //41. Divide array in two parts and reverse the two parts.
    //e.g. if array is { 1,2,3,4,5,6,} result should be { 4,5,6, 1,2,3}
    //if array contains odd elements e.g. { 1,2,3,4,5,6,7}
    //result should be {5,6,7,4,3,2,1}
    //42.Display all elements of two dimenstional array with dimensions 3X4.
    //43. If a number from a two dimensional array is given , its position in the array should be shown.
    //e.g. two dimensional array is { {1,2,3,4} , { 5,6,7,8} } if 7 is entered it will show its position as row
    //2 column 3
    //44. Find maximum number from each row of two dimensional array with dimensions ( 3 x 4)
    //45.Find minimum number from a two dimensional array .

}
