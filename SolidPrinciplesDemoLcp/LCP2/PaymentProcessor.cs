namespace SolidPrinciplesDemoLsp.LCP2
{
	//client code that uses the Payment class
	public class PaymentProcessor
	{
		//without validation
		//public void Process(Payment payment, decimal amount)
		//{
		//	payment.ProcessPayment(amount);
		//}

		//validate payment before processing and process only if validation is successful
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
