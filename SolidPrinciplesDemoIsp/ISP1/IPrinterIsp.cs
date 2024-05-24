namespace SolidPrinciplesDemoIsp.ISP1
{
	public interface IPrinterIsp
	{
		void Print(string document);
	}

	public interface IScannerIsp
	{
		void Scan(string document);
	}

	public interface IFaxIsp
	{
		void Fax(string document);
	}

	//Class implements only the methods it needs
	public class SimplePrinterIsp : IPrinterIsp
	{
		public void Print(string document)
		{
			Console.WriteLine($"Print : {document}");
		}
	}

	public class MultifunctionPrinter : IPrinterIsp, IScannerIsp, IFaxIsp
	{
		public void Fax(string document)
		{
            Console.WriteLine($"Fax : {document}");
        }

		public void Print(string document)
		{
			Console.WriteLine($"Print : {document}");
		}

		public void Scan(string document)
		{
			Console.WriteLine($"Scan : {document}");
		}
	}
}
