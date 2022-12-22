using System;
using System.Collections.Generic;

namespace SkillMineCodes.CollectionsFolder
{
    class Emp
    {
        public int Id { get; set; }

        public int Salary { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary}";
        }
    }

    class GEmp
    {
        static void Main(string[] args)
        {
            List<Emp> l =
                new List<Emp>()
                {
                    new Emp { Id = 1, Name = "Nayan", Salary = 100000 },
                    new Emp { Id = 2, Name = "Adi", Salary = 100000 },
                    new Emp { Id = 3, Name = "Nomya", Salary = 10000 }
                };
            foreach (Emp e in l)
            {
                Console.WriteLine($"{e.Id} {e.Name} {e.Salary}");
            }
        }
    }
}
