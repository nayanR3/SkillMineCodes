using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.HW.Dec15
{
    internal class GenericsQueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(21);
            q1.Enqueue(8);
            q1.Enqueue(24);
            q1.Enqueue(27);
            q1.Enqueue(1);
            q1.Enqueue(11);
            q1.Enqueue(12);
            q1.Enqueue(3);
            q1.Enqueue(97);
            q1.Enqueue(98);
            q1.Enqueue(20);
            q1.Enqueue(23);


            Console.Write("Queue elements  --> ");
            foreach (int i in q1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Size of Queue --> " + q1.Count);
            Console.WriteLine("Fisrt element in Queue --> " + q1.First());
            Console.WriteLine("Last element in Queue --> " + q1.Last());
            Console.WriteLine("Max element in Queue --> " + q1.Max());
            Console.WriteLine("Min element in Queue --> " + q1.Min());
            Console.WriteLine("Total sum of Queue --> " + q1.Sum());
            Console.WriteLine("Average of the Queue --> " + q1.Average());

            Console.WriteLine("\nPeek element from Queue --> " + q1.Peek());
            Console.WriteLine("\nDequeue element from Queue --> " + q1.Dequeue());
            Console.WriteLine("Dequeue element from Queue --> " + q1.Dequeue());
            Console.WriteLine("Dequeue element from Queue --> " + q1.Dequeue());


            Console.Write("\nQueue elements  --> ");
            foreach (int i in q1)
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

            Console.WriteLine("\nQueue contains 3 --> " + q1.Contains(3));
            Console.WriteLine("Queue contains 22 --> " + q1.Contains(22));


            Queue<int> q2 = new Queue<int>();
            q2.Enqueue(71);
            q2.Enqueue(746);
            q2.Enqueue(171);
            q2.Enqueue(3);

            Console.Write("\nQueue 1 elements  --> ");
            foreach (int i in q1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Queue 2 elements  --> ");
            foreach (int i in q2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var s3 = q1.Concat(q2);
            Console.Write("\nConcate  --> ");
            foreach (int i in s3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var s4 = q1.Union(q2);
            Console.Write("Union  --> ");
            foreach (int i in s4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            var s5 = q1.Intersect(q2);
            Console.Write("Intersect  --> ");
            foreach (int i in s5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
