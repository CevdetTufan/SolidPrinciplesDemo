namespace SolidPrinciplesDemo.SRP1
{
	// NotificationService class is responsible for sending notifications
	public class NotificationService
	{
		public void SendEmail(EmployeeModel employee)
		{
            // Send email
            Console.WriteLine($"Sent email notification to {employee.Email}");
        }

		public void SendSMS(EmployeeModel employee)
		{
			// Send SMS
			Console.WriteLine($"Sent SMS notification to {employee.PhoneNumber}");
		}
	}
}
