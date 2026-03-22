using Encapsulation;
using System;


BankAccount bankAccount = new BankAccount(200);

Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(100);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(300);
Console.WriteLine(bankAccount.GetBalance());

