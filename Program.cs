using System;

namespace TernaryOperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000, withdrawal;
            Console.Write("Enter Withdrawal Amount: ");
            withdrawal = Convert.ToInt32(Console.ReadLine());
            balance = withdrawal > balance ? balance : balance - withdrawal;
            Console.WriteLine("Balance= " + balance);


        }
    }
}
