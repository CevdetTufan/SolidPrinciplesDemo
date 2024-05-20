
using SolidPrinciplesDemo.SRP1;

EmployeeModel employee = new("John Doe", "john.doe@exa.com", "1234567890");

EmployeeManager employeeManager = new();
employeeManager.AddEmployee(employee);

NotificationService notificationService = new();
notificationService.SendEmail(employee);
notificationService.SendSMS(employee);
