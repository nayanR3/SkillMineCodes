using System;

namespace SkillMineCodes.CollectionsFolder
{
    class QDemo1
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();
            Console.WriteLine("first element in queue " + queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine (item);
            }
        }
    }
}
