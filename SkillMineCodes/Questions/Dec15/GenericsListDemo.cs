using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.HW.Dec15
{
    public class GenericsListDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tInteger list");
            List<int> l1 = new List<int>();
            l1.Add(21);
            l1.Add(11);
            l1.Add(98);
            l1.Add(25);
            l1.Add(4);
            l1.Add(3);
            l1.Add(15);
            l1.Add(6);
            l1.Add(20);

            Console.Write("\nElements --> ");
            foreach(int i in l1)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            Console.WriteLine("\nSize of list --> "+ l1.Count);

            Console.WriteLine("\nMax element in list --> "+l1.Max());
            Console.WriteLine("\nMin element in list --> "+l1.Min());
            Console.WriteLine("\nTotal sum of list --> " + l1.Sum());
            Console.WriteLine("\nAverage of the list --> "+l1.Average());
            
            l1.Remove(15);
            l1.Remove(6);
            Console.WriteLine("\nRemove 15 and 6 from list");

            Console.Write("Elements after removing elements --> ");
            foreach (int i in l1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            /*           l1.Append(l1.Max());
                        Console.Write("\nAppend max element --> ");
                        foreach (int i in l1)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
            */


            l1.Sort();
            Console.Write("\nSort the list -> ");
            foreach (int i in l1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



/*          
            int index = l1.BinarySearch(21);
            Console.WriteLine($"\nIndex where insert the element {index}");
            if (index < 0) // if element not found then insert otherwise not
            {
                l1.Insert(~index, 71);
            }
            Console.Write("Binary search -> ");
            foreach (int i in l1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
*/

            l1.Reverse();
            Console.Write("\nReverse the list --> ");
            foreach (int i in l1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            


            List<int> l2 = new List<int>();
            l2.Add(24);
            l2.Add(12);
            l2.Add(3);
            l2.Add(27);
            l2.Add(1);
            l2.Add(97);

            Console.WriteLine();
            Console.Write("\nList 1 --> ");
            foreach (int i in l1)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nList 2 --> ");
            foreach (int i in l2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var l3 = l1.Concat(l2);
            Console.Write("\nConcatenate of 2 list --> ");
            foreach (int i in l3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var l4 = l1.Union(l2);
            Console.Write("\nUnion of 2 list --> ");
            foreach (int i in l4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var l5 = l1.Intersect(l2);
            Console.Write("\nIntersect of 2 list --> ");
            foreach (int i in l5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
