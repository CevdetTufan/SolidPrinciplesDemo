/*
BankAccount is the base class.
SavingsAccount and CheckingAccount are subclasses.
The Bank class works with a collection of BankAccount objects and performs operations without knowing the specific type of account.
This setup adheres to the Liskov Substitution Principle because you can replace BankAccount objects with SavingsAccount or CheckingAccount objects, and the program behaves correctly. The PerformOperations method in the Bank class does not need to change if you add more account types in the future, as long as those account types adhere to the contracts defined by the BankAccount class.
 */

using SolidPrinciplesDemoLsp.LCP1;

var bank = new Bank();

BankAccount savings = new SavingsAccount(1000m);
BankAccount checking = new CheckingAccount(500m);

//violates Liskov Substitution Principle
BankAccount fixedTerm = new FixedTermAccount(1000m, DateTime.Now.AddMonths(6));

bank.AddAccount(savings);
bank.AddAccount(checking);
bank.AddAccount(fixedTerm);

bank.PerformOperations();