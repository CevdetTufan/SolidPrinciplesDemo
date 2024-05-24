namespace SolidPrinciplesDemoIsp.ISP1
{
	public interface IPrinter
	{
		void Print(string document);
		void Scan(string document);
		void Fax(string document);
	}


	//The class was forced to use methods it could not use.
	public class SimplePrinter : IPrinter
	{
		public void Print(string document)
		{
			// Print the document
		}

		public void Scan(string document)
		{
			//do not use
		}

		public void Fax(string document)
		{
			//do not use
		}
	}
}
