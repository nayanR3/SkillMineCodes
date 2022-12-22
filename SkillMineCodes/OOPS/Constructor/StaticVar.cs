using System;

namespace SkillMineCodes.OOPS.Constructor
{
    public class Student
    {
        private int rollno;

        private string

                name,
                country;

        private double percentage;

        private static int count;

        public Student(string name, double percentage, string country = "India")
        {
            count++;
            rollno = count;
            this.name = name;
            this.percentage = percentage;
            this.country = country;
        }

        public override string ToString()
        {
            return $"{rollno} -> {name} -> {percentage}->{country}";
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Amol", 88.99); // 4 +4 + 8+ 5 =21
            Student s3 = new Student("John", 77.77, "USA"); // 4 +4 + 8 +3 =19

            // named argument
            Student s2 = new Student(percentage: 77.55, name: "Ajay");
            Console.WriteLine (s1);
            Console.WriteLine (s2);
            Console.WriteLine (s3);
        }
    }
}
