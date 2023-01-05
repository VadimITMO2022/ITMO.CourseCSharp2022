﻿// See https://aka.ms/new-console-template for more information

namespace StructType
{
    internal class Program
    {
        public enum AccountType { Checking, Deposit }
        public struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        } 
        static void Main(string[] args)
        {
                BankAccount goldAccount;

                goldAccount.accType = AccountType.Checking; 
                goldAccount.accBal = (decimal)3200.00;
                goldAccount.accNo = 123; 

      /*      Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine()); */

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType); 
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
            Console.Read();
        }
    }
}







