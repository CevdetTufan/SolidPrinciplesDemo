namespace SolidPrinciplesDemoLsp.LCP2
{
	//sub class of Payment
	public class CreditCardPayment : Payment
	{
		public override void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing credit card payment of {amount:C}");
		}
	}
}
