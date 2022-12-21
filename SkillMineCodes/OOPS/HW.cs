using System;

namespace SkillMineCodes.AccessModifiers
{
    /*Q1.create student class, 
	student has different different properties, declare that properties with different different modifier
    and their is some methods with different access modifiers
    Access this student data in same class, in another class and inside the sub-class.*/

    class Student
    {
       internal string name="Nayan";
        int rollno;
       public string address;
       protected int phone;
    }
    class StudInfo : Student
    {
        static void Main(string[] args)
        {
            StudInfo so = new StudInfo();
            so.address = "Dapoli";
            so.phone = 1111111;
            
            Console.WriteLine(so.name+" "+so.address+" "+so.phone);
        }
    }




    /*Q2.Create account class which accNo, accType, Balance, CustomerName
    Write property for account and access it*/

    class Account
    {
        int accNo;
        string accType;
        double balance;
        string customerName;

        public int AccNo
        {
            set
            {
                accNo = value;
            }
            get
            {
                return accNo;
            }
        }

        public string AccType
        {
            set
            {
                accType = value;
            }
            get
            {
                return accType;
            }
        }

        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }

        public string CustomerName
        {
            set
            {
                customerName = value;
            }
            get
            {
                return customerName;
            }
        }
    }

    class AccInfo
    {
        static void Main(string[] args)
        {
            Account o = new Account();
            o.AccNo = 123;
            o.AccType = "Saving";
            o.Balance = 1000000.00;
            o.CustomerName = "ABC";

            Console.WriteLine(o.AccNo + " "+ o.AccType+" "+o.Balance+" "+o.CustomerName);
        }
    }




    
    /*Q3.WAC to create student class
    student has id, name, 3 subjects marks
    access this student detaails, calculate percentage of subjects 
	& display all the details of student with percentage*/

    class Student1
    {
        int id;
        string name;
        int phy, chem, bio;

        // Constructor
        public Student1(int id, string name, int phy, int chem, int bio){
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
