using System;

namespace SkillMineCodes.OOPS.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Mustang = new Car(); //Object 1
            Mustang.carName = "Ford Mustang";
            Mustang.carType = "3.7L V6";
            Mustang.price = 24645F;
            Mustang.modelYear = 2017;
            Console
                .WriteLine("Car Name - {0}, Car Type - {1}, Year - {2}",
                Mustang.carName,
                Mustang.carType,
                Mustang.modelYear);

            Car Beetle = new Car(); //Object 2
            Beetle.carName = "Volkswagen Beetle";
            Beetle.carType = "Beetle 1.8T";
            Beetle.price = 19795F;
            Beetle.modelYear = 2017;
            Console
                .WriteLine("Car Name - {0}, Car Type - {1}, Year - {2}",
                Beetle.carName,
                Beetle.carType,
                Beetle.modelYear);

            Console.ReadKey();
        }
    }

    class Car
    {
        //Properties
        public int modelYear;

        public string carName;

        public string carType;

        public float price;

        //Methods
        public void DriveCar()
        {
            Console.WriteLine("Car is driving");
        }

        public void ApplyBrake()
        {
            Console.WriteLine("Car is applying brakes");
        }
    }
}
