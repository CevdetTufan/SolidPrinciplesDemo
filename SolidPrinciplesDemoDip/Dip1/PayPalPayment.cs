using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemoDip.Dip1
{
	public class PayPalPayment : IPayment
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"PayPal payment of {amount:C} processed.");
		}
	}
}
