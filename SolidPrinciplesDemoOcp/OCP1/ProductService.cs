namespace SolidPrinciplesDemoOcp.OCP1
{
	public class ProductService
	{
		private readonly IProductRepository _productRepository;

		public ProductService(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public void AddProduct(ProductModel product)
		{
			_productRepository.Add(product);
			Console.WriteLine($"Added product: {product.Name}");
		}

		public void RemoveProduct(int id)
		{
			var product = _productRepository.GetById(id);
			if (product != null)
			{
				_productRepository.Remove(id);
				Console.WriteLine($"Removed product: {product.Name}");
			}
			else
			{
				Console.WriteLine("Product not found.");
			}
		}

		// New method to filter products by category
		public void DisplayProductsByCategory(string category)
		{
			var products = _productRepository.GetByCategory(category);
			Console.WriteLine($"\nProducts in category '{category}':");
			foreach (var product in products)
			{
				Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
			}
		}
	}
}
