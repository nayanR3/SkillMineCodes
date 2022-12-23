using System;

// Assignment on Delegate & Event
// Create a class Bank with Debit & Credit method. Use constructor to initialize ac balance (5000)
// Credit method will add amount to the balance amt - 1000 → 6000
// Debit method will debit the amount from the balance , if amount is greater than balance – > raise an event that “insufficient balance”
// If balance is zero after the debit raise an event “Zero balance”

// Display the updated balance
namespace SkillMineCodes.DelegateEvent
{
    public delegate void MD1();

    public class Bank
    {
        public event MD1 ZeroBalance;

        public event MD1 InsufficientBalance;

        private int balance;

        public Bank(int balance)
        {
            this.balance = balance;
        }

        public void Credit(int amount)
        {
            balance = amount + balance;
            System.Console.WriteLine("Credited "+ amount + "Current balance after credit "+ balance);
        }

        public int Debit(int amount)
        {
            if (balance >= amount)
            {
                balance = balance - amount;
                System.Console.WriteLine("Account balance " + balance);

                if (balance == 0)
                {
                    ZeroBalance();
                }
            }
            else
            {
                System.Console.WriteLine("Account balance is " + balance +" and you try to debit "+ amount);
                InsufficientBalance();
            }
            return balance;
        }

        public override string ToString()
        {
            return $"{balance} ";
        }
    }

    public static class Message
    {
        public static void ZeroBalanceM()
        {
            Console.WriteLine("Zero Balance");
        }

        public static void InsufficientBalanceM()
        {
            Console.WriteLine("Sorry, Insufficient balance");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(1000);
            System.Console.WriteLine("Default Amount " + b);

            b.InsufficientBalance += new MD1(Message.InsufficientBalanceM);
            b.ZeroBalance += new MD1(Message.ZeroBalanceM);

            b.Credit(2000);
            // System.Console.WriteLine("Credit " + b);

            b.Debit(3000);
            // System.Console.WriteLine("Debit " + b);

            b.Debit(1000);
        }
    }
}
