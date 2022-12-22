using System;
using System.Collections.Generic;

namespace SkillMineCodes.Questions
{
    public class C3
    {
        static void Main(string[] args)
        {
            List<Grossery> list = new List<Grossery>();
            list
                .Add(new Grossery {
                    Product = "Soup",
                    Price = 50,
                    Quantity = 10
                });
            list
                .Add(new Grossery {
                    Product = "Brush",
                    Price = 30,
                    Quantity = 6
                });
            list
                .Add(new Grossery {
                    Product = "Dish",
                    Price = 300,
                    Quantity = 6
                });

            Console.WriteLine("Display Grossery item");
            foreach (Grossery l in list)
            {
                Console.WriteLine (l);
            }

            Console.WriteLine("\nRequired Money");
            Grossery g = new Grossery();
            int total = 0;
            foreach (Grossery i in list)
            {
                int v = g.cal(i.Price, i.Quantity);
                Console
                    .WriteLine(v +
                    " for " +
                    i.Product +
                    " and 10% discount price " +
                    g.DisPrice(v));
                total += v;
            }

            Console.WriteLine("\nTotal required Money " + total);
            Console
                .WriteLine("apply 10% discount on total money " +
                g.DisPrice(total));
        }
    }

    public class Grossery
    {
        public string Product { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Product} {Price} {Quantity}";
        }

        int sum = 1;

        public int cal(int p, int q)
        {
            sum = p * q;
            return sum;
        }

        public int DisPrice(int total)
        {
            int dicP = (10 * total) / 100;
            total = total - dicP;

            return total;
        }
    }
}
