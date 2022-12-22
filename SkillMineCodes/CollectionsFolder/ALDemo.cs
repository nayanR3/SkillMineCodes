using System;

namespace SkillMineCodes.CollectionsFolder
{
    class ALDemo1
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine($"Capacity ->{list.Capacity}");
            int[] arr = new int[] { 100, 200, 300 };
            list.Add(10); // boxing
            list.Add("Hello");
            list.Add(67.88);
            Console.WriteLine($"Capacity ->{list.Capacity}");

            //string name =list[1].ToString();
            //double d = Convert.ToDouble(list[2]); // unboxing
            list.Insert(0, 5);
            list.Insert(2, 15);
            list.AddRange (arr);
            Console.WriteLine($"Capacity ->{list.Capacity}");

            // list.Remove(67.88);
            // list.RemoveAt(3);
            foreach (var item in list)
            {
                Console.WriteLine (item);
            }
            Console.WriteLine("-----------------");

            // list.RemoveRange(3, 4);
            list.Clear();
            Console.WriteLine($"Capacity ->{list.Capacity}");
            foreach (var item in list)
            {
                Console.WriteLine (item);
            }
            list.Sort();
            list.Reverse();
        }
    }

    class ALDemo2
    {
        static void Main(string[] args)
        {
            Product p1 =
                new Product { Id = 3, Name = "pendrive", Price = 2400 };
            Emp e1 = new Emp { Id = 101, Name = "Tushar", Salary = 4500 };
            ArrayList list = new ArrayList();
            list.Add (p1);
            list.Add (e1);
            foreach (var
                item
                in
                list // p1
            )
            {
                if (
                    typeof (Product) == item.GetType() // Product
                )
                {
                    Product p = (Product) item;
                    Console.WriteLine(p.Id + " " + p.Name + " " + p.Price);
                }
                else if (typeof (Emp) == item.GetType())
                {
                    Emp e = (Emp) item;
                    Console.WriteLine(e.Id + " " + e.Name + " " + e.Salary);
                }
            }
        }
    }
}
