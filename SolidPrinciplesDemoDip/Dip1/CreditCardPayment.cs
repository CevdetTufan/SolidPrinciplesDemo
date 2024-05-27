namespace SolidPrinciplesDemoDip.Dip1
{
	public class CreditCardPayment : IPayment
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Credit Card payment of {amount:C} processed.");
		}
	}
}
