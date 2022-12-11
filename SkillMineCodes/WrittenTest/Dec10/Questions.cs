using SkillMineCodes.AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.WrittenTest.Dec10
{
    /*Q1. Check if given number is Armstrong or not*/
    public class DecQ1
    {
        private int n;

        public DecQ1(int n)
        {
            this.n = n;
        }

        public string Cal()
        {
            int copy = n;
            int sum = 0;

            while (copy != 0)
            {
                int rem = copy % 10;
                copy /= 10;
                sum += (rem * rem * rem);
            }

            string s = "";
            if (sum == n)
            {
                s += $"{n} is Armstrong number";
            }
            else
            {
                s += $"{n} is not a Armstrong number";
            }
            return s;
        }
    }


    /*Q2. Swap values of two integer variables without using third variable.*/
    public class DecQ2
    {
        public int A { get; set; }
        public int B { get; set; }

        public void Cal()
        {
            A = A + B;
            B = A - B;
            A = A - B;
        }
        public override string ToString()
        {
            return $"A= {A} and B= {B}";
        }

    }


    /*Q3. Count number of digits in any number.*/
    public class DecQ3
    {
        private int n;
        public DecQ3(int n)
        {
            this.n = n;
        }


        int d = 0;
        public void CountDigit()
        {
            int copy = n;
            while (copy != 0)
            {
                int r = copy % 10;
                d++;
                copy /= 10;
            }
        }

        public override string ToString()
        {
            return $"Total digits in number {n} is {d}";
        }
    }


    /* 4. Accept a number from user and Create table of a number.*/
    public class DecQ4
    {
        private int n;
        public DecQ4(int n)
        {
            this.n = n;
        }

        public void Table()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
    }


    /*Q5. Find first 10 even numbers.*/
    public class DecQ5
    {
        public void Even()
        {
            int c = 0;
            int v = 1;
            while (c != 10)
            {
                if (v % 2 == 0)
                {
                    Console.WriteLine(v);
                    c++;
                }
                v++;
            }
        }
    }

}
