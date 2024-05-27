namespace SolidPrinciplesDemoDip.Dip1
{
	public class BankTransferPayment : IPayment
	{
		public void ProcessPayment(decimal amount)
		{
			// Logic to process bank transfer payment
			Console.WriteLine($"Bank transfer payment of {amount:C} processed.");
		}
	}
}
