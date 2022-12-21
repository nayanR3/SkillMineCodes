using System;

namespace SkillMineCodes.OOPS.Constructor
{
    /*Q3.WAC to create student class
    student has id, name, 3 subjects marks
    access this student details, calculate percentage of subjects 
	& display all the details of student with percentage*/
    class Student1
    {
        int id;

        string name;

        int

                phy,
                chem,
                bio;

        // Constructor
        public Student1(int id, string name, int phy, int chem, int bio)
        {
            this.id = id;
            this.name = name;
            this.phy = phy;
            this.chem = chem;
            this.bio = bio;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public double getPercentage()
        {
            int total = phy + chem + bio;
            double per = (total * 100) / 300.0;
            return per;
        }
    }

    class Student1Info
    {
        static void Main(string[] args)
        {
            Student1 s = new Student1(1, "Nayan", 45, 50, 55);
            Console.WriteLine(s.getName());
            Console.WriteLine(s.getId());
            Console.WriteLine(s.getPercentage());
        }
    }
}
