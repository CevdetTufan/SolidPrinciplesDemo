namespace SolidPrinciplesDemoLsp.LCP2
{
	//sub class of Payment
	public class PayPalPayment : Payment
	{
		public override void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing PayPal payment of {amount:C}");
		}
	}
}
