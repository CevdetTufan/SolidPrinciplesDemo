namespace SolidPrinciplesDemoLsp.LCP2
{
	//client code that uses the Payment class
	public class PaymentProcessor
	{
		//public void Process(Payment payment, decimal amount)
		//{
		//	payment.ProcessPayment(amount);
		//}

		public void Process(Payment payment, decimal amount)
		{
			if (payment is IPaymentValidator validator && !validator.ValidatePayment(amount))
			{
				Console.WriteLine("Payment validation failed.");
				return;
			}
			payment.ProcessPayment(amount);
		}
	}
}
