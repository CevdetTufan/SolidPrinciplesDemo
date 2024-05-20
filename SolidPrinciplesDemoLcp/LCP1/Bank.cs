namespace SolidPrinciplesDemoLsp.LCP1
{
	public class Bank
	{
		private List<BankAccount> accounts = new List<BankAccount>();

		public void AddAccount(BankAccount account)
		{
			accounts.Add(account);
		}

		public void PerformOperations()
		{
			foreach (var account in accounts)
			{
				account.Deposit(100);
				try
				{
					account.Withdraw(50);
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
				}
				Console.WriteLine($"Account Balance: {account.Balance}");
			}
		}
	}
}
