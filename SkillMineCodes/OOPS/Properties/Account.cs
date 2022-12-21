using System;

namespace SkillMineCodes.OOPS.Properties
{
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

            Console
                .WriteLine(o.AccNo +
                " " +
                o.AccType +
                " " +
                o.Balance +
                " " +
                o.CustomerName);
        }
    }
}
