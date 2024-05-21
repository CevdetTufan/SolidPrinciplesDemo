namespace SolidPrinciplesDemoLsp.LCP2
{
	//sub class of Payment
	public class BitcoinPayment : Payment
	{
		public override void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing Bitcoin payment of {amount:C}");
		}
	}
}
