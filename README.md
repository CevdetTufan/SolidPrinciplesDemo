#S.O.L.I.D Principles

The SOLID principles are a set of five design principles that guide software developers in writing clean and maintainable code. 
1.	Single Responsibility Principle
2.	Open-closed Principle
3.	Liskov Subsutiation Principle
4.	Interface Segration Principle
5.	Dependency Inversion Principle

Single Responsibility Principle

A class should have a single responsibility, meaning it should have only one reason to change.
In the SolidPrinciplesDemoSrp example, there are two classes: EmployeeManager and NotificationService. EmployeeManager is responsible for managing employees, such as adding and removing them. NotificationService is responsible for sending emails and SMS messages.  
At the same time, if the EmployeeManager also sends emails or SMS messages, it violates the Single Responsibility Principle (SRP).

Open-Closed Principle

A class should be open for extension but closed to modification. We should be able to add new functionality without touching existing code, as modifying existing code might introduce new bugs in the tested code.
In the SolidPrinciplesDemoOcp, there is a ProductService class, an InMemoryProductRepository class, and a ProductRepository interface in the OCP1 folder.
We extended the InMemoryProductRepository class to include a new method GetByCategory() to filter products by category.
We extended the ProductService class to include a new method DisplayProductsByCategory() to display products filtered by category.
These extensions were made without modifying the existing code, adhering to the Open/Closed Principle. Now, the system can be extended to support new filtering criteria without changing the existing behavior.

Liskov Substitution Principle

Subclasses should be substitutable base classes. The base class defines a contract, including methods and behaviors, that its subclasses are expected to adhere to.
In the SolidPrinciplesDemoLsp example, there is a Payment base class and the subclasses BitcoinPayment, CashPayment, CreditCardPayment, and PayPalPayment. These classes are subclasses of the Payment base class and implement the behavior to process payments. However, CashPayment does not fully adhere to the base class behavior because it throws an exception if the amount is greater than $1000, as shown in the commented code.  This is a violation of LSP.
CashPayment extends with the IPaymentValidator interface and the ValidatePayment method validates the amount. In the PaymentProcessor class, payment validates and CashPayment adheres to its base class behaviour.

Interface Segregation Principle

Clients should not be forced to depend on interfaces they do not use. The class should not be forced implement interface that it is not needed.
In the SolidPrinciplesDemoIsp example, there is an IPrinter interface that is implemented to the SimplePrinter class. However, the SimplePrinter class does not need the scan and fax methods.
The IPrint interface is separated into three distinct interfaces: IPrinterIsp, IScannerIsp, and IFaxIsp. The IPrinterIsp interface is implemented to the SimplePrinterIsp class, which is not forced to include methods it doesn't need. 
The IPrinterIsp, IScannerIsp, and IFaxIsp interfaces are implemented to the MultifunctionPrinter class, which includes the methods it needs.
Thus, the client isn’t forced to implement methods it doesn’t need.

Dependency Inversion Principle

High-level modules should not depend on low-level modules. Both should depend on abstractions. 
In the SolidPrinciplesDemoDip example, the PaymentProcessorViolated class depends the CreditCardPayment class and the PayPalPayment class. The PaymentProcessorViolated is tightly coupled to the specific payment method classes, CreditCardPayment and PayPalPayment, which violates the Dependency Inversion Principle.
The PaymentProcessor class depends the IPayment interface which adhere DIP and high level class is low-coupled to low-level class.


