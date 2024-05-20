namespace SolidPrinciplesDemoLsp.LCP1
{
	public abstract class BankAccount
	{
        public decimal Balance { get; protected set; }
        public abstract void Deposit(decimal amount);
		public abstract void Withdraw(decimal amount);
	}
}
