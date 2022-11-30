using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Nested_Loop
{

    // 1 2 3 4
    // 1 2 3 4
    // 1 2 3 4
    // 1 2 3 4
    class P1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter no of columns");
            int col = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                int val = 1;
                for (int j = 1; j <= col; j++)
                {
                    System.Console.Write(val + " ");
                    val++;
                }
                System.Console.WriteLine();
            }
        }

    }


    // 1 
    // 1 2
    // 1 2 3
    // 1 2 3 4
    class P2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter no of columns");
            int col = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                int val = 1;
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(val + " ");
                    val++;
                }
                System.Console.WriteLine();
            }
        }

    }


    // 1 2 3 4 
    // 1 2 3
    // 1 2
    // 1
    class P3
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter no of columns");
            int col = int.Parse(Console.ReadLine());

            for (int i = row - 1; i >= 0; i--)
            {
                int val = 1;
                for (int j = 0; j <= i; j++)
                {
                    System.Console.Write(val + " ");
                    val++;
                }
                System.Console.WriteLine();
            }
        }
    }


    // * * * * 
    // * * *
    // * *
    // *
    class p4
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter no of columns");
            int col = int.Parse(Console.ReadLine());

            for (int i = row - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    System.Console.Write("*" + " ");
                }
                System.Console.WriteLine();
            }
        }
    }


    // 1 
    // 2 3 
    // 4 5 6
    // 7 8 9 10 
    class P5
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter no of columns");
            int col = int.Parse(Console.ReadLine());

            int val = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(val + " ");
                    val++;
                }
                System.Console.WriteLine();
            }
        }

    }


    // * 
    // * *
    // *   *
    // *     *
    // * * * * *
    class P6
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 | j == i)
                    {
                        System.Console.Write("* ");
                    }
                    else if (i == row)
                    {
                        System.Console.Write("* ");
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


    // *       * 
    // * *     *
    // *   *   *
    // *     * *
    // *       *
    class P7
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter no of columns");
            int col = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (j == 1 || j == col)
                    {
                        System.Console.Write("* ");
                    }
                    else if (i == j)
                    {
                        System.Console.Write("* ");
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


    // *  
    // *  o
    // *  o *
    // *  o *  o
    // *  o *  o *
    class P8
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        System.Console.Write("o ");
                    }
                    else
                    {
                        System.Console.Write("*  ");
                    }
                }
                System.Console.WriteLine();
            }
        }

    }


    //     *     
    //     *
    // * * * * *
    //     *     
    //     *
    class P10
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter no of rows");
            int row = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter no of col");
            int col = int.Parse(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (j == col / 2 + 1 || i == row / 2 + 1)
                    {
                        System.Console.Write("* ");
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



    // Q1. Display table between 1 to 5 Number
    class Q1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    System.Console.Write(i * j + " ");
                }
                System.Console.WriteLine();
            }
        }

    }


    // Q2. Find out the avg of prime number in between 1 to 20.
    class Q2
    {
        static void Main(string[] args)
        {
            int s = 0, c = 0;
            for (int i = 1; i <= 20; i++)
            {
                bool f = true;
                if (i == 1)
                {
                    f = false;
                }
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        f = false;
                    }
                }
                if (f == true)
                {
                    s += i;
                    c++;
                }
            }
            System.Console.WriteLine(s / c);
        }

    }



    // Q3. Calculate the sum of factorial between 1 to 5.
    class Q3
    {
        static void Main(string[] args)
        {
            int s = 0;
            for (int i = 1; i <= 5; i++)
            {
                int ts = 1;
                for (int j = 1; j <= i; j++)
                {
                    ts = ts * j;
                }
                System.Console.WriteLine(i + " " + ts);
                s += ts;
            }
            System.Console.WriteLine(s);
        }

    }
}


