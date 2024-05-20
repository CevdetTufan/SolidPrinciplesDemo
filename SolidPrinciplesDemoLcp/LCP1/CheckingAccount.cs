namespace SolidPrinciplesDemoLsp.LCP1
{
	//subclass of BankAccount
	public class CheckingAccount : BankAccount
	{
        public CheckingAccount(decimal intialBalance)
        {
            if(intialBalance < 0)
			{
				throw new ArgumentException("Initial balance cannot be negative.");
			}
			Balance = intialBalance;
        }
		public override void Deposit(decimal amount)
		{
			if (amount <= 0)
			{
				throw new ArgumentException("Deposit amount must be positive.");
			}

			Balance += amount;
		}

		public override void Withdraw(decimal amount)
		{
			if (amount <= 0)
			{
				throw new ArgumentException("Withdrawal amount must be positive.");
			}

			if (Balance - amount < 0)
			{
				throw new InvalidOperationException("Cannot withdraw more than the available balance.");
			}

			Balance -= amount;
		}
	}
}
