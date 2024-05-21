namespace SolidPrinciplesDemoLsp.LCP2
{
	public interface IPaymentValidator
	{
		bool ValidatePayment(decimal amount);
	}

	public class CashPayment : Payment, IPaymentValidator
	{
		public bool ValidatePayment(decimal amount)
		{
			return amount <= 1000;
		}

		public override void ProcessPayment(decimal amount)
		{
			if (!ValidatePayment(amount))
			{
				throw new InvalidOperationException("Cannot process cash payment over $1000");
			}
			Console.WriteLine($"Processing cash payment of {amount:C}");
		}

		//public override void ProcessPayment(decimal amount)
		//{
		//	if (amount > 1000)
		//	{
		//		throw new InvalidOperationException("Cannot process cash payment over $1000");
		//	}
		//	Console.WriteLine($"Processing cash payment of {amount:C}");
		//}
	}
}
