using System;
using System.Collections;
using System.Text;

namespace SkillMineCodes.Collections
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            // ArrayList
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(22);
            al.Add(31);
            al.Add(30);
            al.Add(983);

            Console.WriteLine("ArrayList element");
            foreach (var i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            
            al.Remove(22);
            Console.WriteLine("\nAfter remove element 22");
            foreach (var i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");


//----------------------------------------------------------------------------------

            
            
            // Stack
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(13);
            st.Push(23);
            Console.WriteLine("\nstack element");
            foreach (var i in st)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nTop element in stack "+st.Peek());
            

            st.Pop();

            Console.WriteLine("\nAfter remove element");
            foreach(var i in st)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");



//----------------------------------------------------------------------------------


            
            //Queue
            Queue q = new Queue();
            q.Enqueue(11);
            q.Enqueue(12);
            q.Enqueue(31);
            q.Enqueue(13);

            Console.WriteLine("\nQueue element");
            foreach (var i in q)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nTop element in queue " + q.Peek());
            q.Dequeue();
            q.Dequeue();

            Console.WriteLine("\nAfter remove element");
            foreach (var i in q)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(q.Count);
            Console.WriteLine("-------------------------------------------------------------------------------");


            //----------------------------------------------------------------------------------



            // HashTable
            Hashtable ht = new Hashtable();
            ht.Add(1, 1);
            ht.Add(2, 2);
            ht.Add(3, 3);

            Console.WriteLine("\nHashTable element");
            foreach (DictionaryEntry i in ht)
            {
                Console.Write(i.Key + " " + i.Value);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------------------");


            //----------------------------------------------------------------------------------

            // SortedList

            SortedList sl = new SortedList();
            sl.Add(1, 11);
            sl.Add(33, 2);
            sl.Add(678, 9);
            sl.Add(8, 345);
            Console.WriteLine("\nSortedList element");
            foreach(DictionaryEntry i in sl)
            {
                Console.Write($"key -> {i.Key} & value -> {i.Value}");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
        }
    }
}
