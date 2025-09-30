// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ConsoleBank;
//Given a client makes a deposit of 1000 on 10-01-2012
//And a deposit of 2000 on 13-01-2012
//And a withdrawal of 500 on 14-01-2012
Account account = new Account();
account.SetTransactionDate("10-01-2012");
account.deposit(1000);
account.SetTransactionDate("13-01-2012");
account.deposit(2000);
account.SetTransactionDate("14-01-2012");
account.withdraw(500);
account.printStatement();
Console.ReadLine();