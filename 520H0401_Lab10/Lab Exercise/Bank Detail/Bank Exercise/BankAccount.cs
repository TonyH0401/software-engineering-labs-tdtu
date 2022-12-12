﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcct
{
    public class BankAccount
    {
        private readonly string s_customerName;
        private double d_balance;
        //Constructors
        private BankAccount() { }
        public BankAccount(string customerName, double balance)
        {
            s_customerName = customerName;
            d_balance = balance;
        }

        //Accessor : get
        public string CustomerName
        {
            get { return s_customerName; }
        }
        public double Balance
        {
            get { return d_balance; }
        }

        //Mutator: set
        public void Debit(double amount)
        {
            if (amount > d_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            d_balance -= amount; //intentionally incorrect code. Note: this code is not wrong though?
        }
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            d_balance += amount;
        }
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mr Trung Pham", 50);
            ba.Credit(20);
            ba.Debit(30);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }

    }
}
