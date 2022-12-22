using System;
using System.Collections.Generic;

namespace SkillMineCodes.Questions
{
    public enum AccountType
    {
        Saving,
        Current
    }

    public class Customer
    {
        public int AccNo { get; set; }

        public string Name { get; set; }

        public AccountType AccountType;

        public List<Loan> Loans = new List<Loan>();
    }

    public class Loan
    {
        public int Id { get; set; }

        public string LoanName { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list =
                new List<Customer>()
                {
                    new Customer {
                        AccNo = 101,
                        Name = "NAYAN",
                        AccountType = AccountType.Saving,
                        Loans =
                            {
                                new Loan { Id = 1, LoanName = "Car" },
                                new Loan { Id = 2, LoanName = "Home" }
                            }
                    },
                    new Customer {
                        AccNo = 102,
                        Name = "Adi",
                        AccountType = AccountType.Current,
                        Loans = { new Loan { Id = 1, LoanName = "Business" } }
                    }
                };

            foreach (Customer c in list)
            {
                Console.WriteLine($"Account Holder - {c.Name}");
                Console.WriteLine($"AccountType - {c.AccountType}");
                foreach (Loan L in c.Loans)
                {
                    Console.WriteLine("\t" + L.LoanName);
                }
            }
        }
    }
}
