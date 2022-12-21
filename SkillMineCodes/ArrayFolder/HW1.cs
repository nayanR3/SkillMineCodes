using System;

namespace ArrayFolder
{

    /*Q1.sum of even number of array*/
    class EvenSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            EvenSum t = new EvenSum();
            System.Console.WriteLine(t.fun(arr));
        }

        public int fun(int[] arr)
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) s += arr[i];
            }
            return s;
        }
    }


    /*Q2. Count odd element from array*/
    class OddElementCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            OddElementCount t = new OddElementCount();
            Console.WriteLine(t.fun(arr));
        }

        public int fun(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    c++;
            }
            return c;
        }

    }


    /*Q3. Display vowel from the array*/
    class DisplayVowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            char[] ch = new char[n];
            for (int i = 0; i < n; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            DisplayVowel t = new DisplayVowel();
            t.fun(ch);
        }

        public void fun(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                char c = ch[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    Console.WriteLine(c);
                }
            }
        }
    }


    /*Q4. Find minimum element in array*/
    class FindMin
    {
        public void Fun(int[] a)
        {
            int m = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (m > a[i])
                {
                    m = a[i];
                }
            }
            Console.WriteLine(m);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            FindMin t = new FindMin();
            t.Fun(a);
        }
    }


    /*Q5. Find min-max from character array*/
    class MinMaxChar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());
            char[] ch = new char[n];
            for (int i = 0; i < n; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            MinMaxChar t = new MinMaxChar();
            t.fun(ch);
        }

        public void fun(char[] ch)
        {
            int max = Convert.ToInt32(ch[0]);
            int min = Convert.ToInt32(ch[0]);
            for (int i = 0; i < ch.Length; i++)
            {
                int c = Convert.ToInt32(ch[i]);
                if (max < c)
                {
                    max = c;
                }
                if (min > c)
                {
                    min = c;
                }
            }
            Console.WriteLine((char)min + " " + (char)max);
        }
    }


    /*Q6. Replace with Alternate character*/
    class AlternateChar
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());
            char[] ch = new char[n];
            for (int i = 0; i < n; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            AlternateChar t = new AlternateChar();
            t.fun(ch);
        }

        public void fun(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                char c = ch[i];

                if (c == 'y')
                {
                    Console.WriteLine(c + "+2 = " + "a");
                }
                else if (c == 'z')
                {
                    Console.WriteLine(c + "+2 = " + "b");
                }
                else if (c >= 'a' || c <= 'x')
                {
                    int v = Convert.ToInt32(c);
                    Console.WriteLine(c + "+2 = " + Convert.ToChar(c + 2));
                }
            }
        }

    }


    /*Q7. Display even index element*/
    class EvenIndex
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            EvenIndex t = new EvenIndex();
            t.Fun(a);
        }
        public void Fun(int[] a)
        {
            for (int i = 0; i < a.Length; i += 2)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }


    /*Q8. SUm of element of array*/
    class ArrSum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            ArrSum t = new ArrSum();
            t.Fun(a);
        }
        public void Fun(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            Console.WriteLine(s);
        }

    }


    /*Q9. Replace element by 0 if it's divisible by 3*/
    class ReplaceEleByZero
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            ReplaceEleByZero t = new ReplaceEleByZero();
            Console.WriteLine(string.Join(" ", t.Fun(a)));
        }

        public int[] Fun(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 3 == 0)
                {
                    a[i] = 0;
                }
            }
            return a;
        }

    }


    /*Q10. Prime no's of array*/
    class PrimeOfArr
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            PrimeOfArr t = new PrimeOfArr();
            t.Fun(a);
        }

        public void Fun(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                bool f = true;
                for (int j = 2; j * j <= a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        f = false;
                    }
                }
                if (f == true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

    }
}
