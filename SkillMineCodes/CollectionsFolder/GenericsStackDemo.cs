using System;
using System.Collections;

namespace SkillMineCodes.CollectionsFolder
{
    public class GenericsStackDemo
    {
        static void Main(string[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(21);
            s1.Push(8);
            s1.Push(24);
            s1.Push(27);
            s1.Push(1);
            s1.Push(11);
            s1.Push(12);
            s1.Push(3);
            s1.Push(97);
            s1.Push(98);
            s1.Push(20);
            s1.Push(23);


            Console.Write("Stack elements  --> ");
            foreach(int i in s1)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            Console.WriteLine("\nSize of list --> " + s1.Count);

            Console.WriteLine("\nFisrt element in list --> " + s1.First());
            Console.WriteLine("\nLast element in list --> " + s1.Last());
            Console.WriteLine("\nMax element in list --> " + s1.Max());
            Console.WriteLine("\nMin element in list --> " + s1.Min());
            Console.WriteLine("\nTotal sum of list --> " + s1.Sum());
            Console.WriteLine("\nAverage of the list --> " + s1.Average());

            Console.WriteLine("\nPeek element from stack --> " + s1.Peek());
            Console.WriteLine("\nPop element from stack --> " + s1.Pop());
            Console.WriteLine("Pop element from stack --> " + s1.Pop());
            Console.WriteLine("Pop element from stack --> " + s1.Pop());

            
            Console.Write("\nStack elements  --> ");
            foreach (int i in s1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            /*var s2 = s1.Append(69);
            Console.Write("\nAppend element  --> ");
            foreach (int i in s2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();*/

            Console.WriteLine("\nStack contains 21 --> "+s1.Contains(21));
            Console.WriteLine("Stack contains 22 --> "+s1.Contains(22));


            Stack<int> s2 = new Stack<int>();
            s2.Push(71);
            s2.Push(746);
            s2.Push(171);
            s2.Push(3);

            Console.Write("\nStack 1 elements  --> ");
            foreach (int i in s1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Stack 2 elements  --> ");
            foreach (int i in s2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var s3 = s1.Concat(s2);
            Console.Write("\nConcate  --> ");
            foreach (int i in s3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var s4 = s1.Union(s2);
            Console.Write("Union  --> ");
            foreach (int i in s4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var s5 = s1.Intersect(s2);
            Console.Write("Intersect  --> ");
            foreach (int i in s5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
