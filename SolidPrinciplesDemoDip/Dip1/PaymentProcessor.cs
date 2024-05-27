namespace SolidPrinciplesDemoDip.Dip1
{
	//Violation of DIP, PaymentProcessor is dependent on CreditCardPayment and PayPalPayment
	public class PaymentProcessorViolated
	{
		private readonly CreditCardPayment _creditCardPayment;
		private readonly PayPalPayment _payPalPayment;

		public PaymentProcessorViolated()
		{
			_creditCardPayment = new CreditCardPayment();
			_payPalPayment = new PayPalPayment();
		}

		public void ProcessCreditCardPayment(decimal amount)
		{
			_creditCardPayment.ProcessPayment(amount);
		}

		public void ProcessPayPalPayment(decimal amount)
		{
			_payPalPayment.ProcessPayment(amount);
		}
	}

	//Adhering to DIP, PaymentProcessor is dependent on IPayment
	public class PaymentProcessor
	{
		private readonly IPayment _payment;

		public PaymentProcessor(IPayment payment)
		{
			_payment = payment;
		}

		public void ProcessPayment(decimal amount)
		{
			_payment.ProcessPayment(amount);
		}
	}
}
