namespace SolidPrinciplesDemo.SRP1
{
	// EmployeeManager class is responsible for managing employees
	public class EmployeeManager
	{
		public void AddEmployee(EmployeeModel employee)
		{
            // Add employee to database
            Console.WriteLine($"Added employee : {employee.Name}");
        }

		public void RemoveEmployee(EmployeeModel employee)
		{
			// Remove employee from database
			Console.WriteLine($"Removed employee : {employee.Name}");
		}
	}
}
