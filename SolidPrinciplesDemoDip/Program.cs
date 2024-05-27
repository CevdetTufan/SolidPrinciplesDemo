using SolidPrinciplesDemoDip.Dip1;

//violated
PaymentProcessorViolated paymentProcessorviolated = new PaymentProcessorViolated();
paymentProcessorviolated.ProcessCreditCardPayment(100.00m);
paymentProcessorviolated.ProcessPayPalPayment(50.00m);

//adhering
IPayment paymentMethod = new CreditCardPayment(); // or new PayPalPayment()
PaymentProcessor paymentProcessor = new PaymentProcessor(paymentMethod);
paymentProcessor.ProcessPayment(100.00m);

