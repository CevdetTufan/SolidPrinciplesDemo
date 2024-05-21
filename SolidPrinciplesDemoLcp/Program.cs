using SolidPrinciplesDemoLsp.LCP2;

PaymentProcessor processor = new PaymentProcessor();

Payment creditCardPayment = new CreditCardPayment();
Payment payPalPayment = new PayPalPayment();
Payment bitcoinPayment = new BitcoinPayment();
Payment cashPayment = new CashPayment();



processor.Process(creditCardPayment, 100.00m);  // Output: Processing credit card payment of $100.00
processor.Process(payPalPayment, 200.00m);      // Output: Processing PayPal payment of $200.00
processor.Process(bitcoinPayment, 300.00m);     // Output: Processing Bitcoin payment of $300.00

processor.Process(cashPayment, 1500.00m);  // Output: Payment validation failed.
processor.Process(cashPayment, 500.00m);   // Output: Processing cash payment of $500.00