// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ConsoleBank;
//Given a client makes a deposit of 1000 on 10-01-2012
//And a deposit of 2000 on 13-01-2012
//And a withdrawal of 500 on 14-01-2012
BankAccountService accountService = new BankAccountService();
accountService.SetTransactionDate("10-01-2012");
accountService.deposit(1000);
accountService.SetTransactionDate("13-01-2012");
accountService.deposit(2000);
accountService.SetTransactionDate("14-01-2012");
accountService.withdraw(500);
accountService.printStatement();
Console.ReadLine();