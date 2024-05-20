namespace SolidPrinciplesDemoLsp.LCP1
{
	//subclass of BankAccount
	public class SavingsAccount : BankAccount
	{
		private const decimal MinimumBalance = 500m;

        public SavingsAccount(decimal initialBalance)
        {
            if(initialBalance < MinimumBalance)
			{
				throw new ArgumentException($"The initial balance must be at least {initialBalance}");
			}

			this.Balance = initialBalance;
        }
        public override void Deposit(decimal amount)
		{
			if(amount <= 0)
			{
				throw new ArgumentException("Deposit amount must be greater than zero");
			}

			Balance += amount;
		}

		public override void Withdraw(decimal amount)
		{
			if(amount <= 0)
			{
				throw new ArgumentException("Withdrawal amount must be greater than zero");
			}

			Balance -= amount;
		}
	}
}
