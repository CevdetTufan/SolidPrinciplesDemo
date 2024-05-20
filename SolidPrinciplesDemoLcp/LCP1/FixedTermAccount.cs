namespace SolidPrinciplesDemoLsp.LCP1
{

	/*
FixedTermAccount does not allow withdrawals before the term ends. This introduces behavior that is inconsistent with the expectations set by the BankAccount base class.
When PerformOperations tries to withdraw from a FixedTermAccount, an InvalidOperationException is thrown if the term has not ended. This violates the LSP because FixedTermAccount cannot be substituted for BankAccount without altering the expected behavior of the program.
The code in PerformOperations method assumes that all BankAccount objects can withdraw funds immediately after depositing. However, FixedTermAccount breaks this assumption, leading to runtime errors. This inconsistency shows that FixedTermAccount does not properly adhere to the contract defined by the BankAccount class, thereby violating the Liskov Substitution Principle.
	 */


	//subclass of BankAccount
	public class FixedTermAccount : BankAccount
	{
		private readonly DateTime termEndDate;

		public FixedTermAccount(decimal initialBalance, DateTime termEndDate)
		{
			if (initialBalance < 0)
			{
				throw new ArgumentException("Initial balance cannot be negative.");
			}

			Balance = initialBalance;
			this.termEndDate = termEndDate;
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
			if (DateTime.Now < termEndDate)
			{
				throw new InvalidOperationException("Cannot withdraw before the term ends.");
			}

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
