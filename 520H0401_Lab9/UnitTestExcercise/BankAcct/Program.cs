// See https://aka.ms/new-console-template for more information
using BankAcct;

Console.WriteLine("Hello, World!");

BankAccount ba = new BankAccount("Mr Trung Pham", 50);
ba.Credit(20);
ba.Debit(30);
Console.WriteLine("Current balance is ${0}", ba.Balance);