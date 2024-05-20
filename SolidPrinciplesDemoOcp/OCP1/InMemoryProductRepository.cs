namespace SolidPrinciplesDemoOcp.OCP1
{
	public class InMemoryProductRepository : IProductRepository
	{
		private List<ProductModel> _products;

		public InMemoryProductRepository()
		{
			_products = new List<ProductModel>();
		}

		public ProductModel GetById(int id)
		{
			return _products.Find(p => p.Id == id);
		}

		public IEnumerable<ProductModel> GetAll()
		{
			return _products;
		}

		public void Add(ProductModel product)
		{
			product.Id = _products.Count + 1; // Simulating auto-increment ID
			_products.Add(product);
		}

		public void Remove(int id)
		{
			_products.RemoveAll(p => p.Id == id);
		}

		// New method to filter products by category
		public IEnumerable<ProductModel> GetByCategory(string category)
		{
			return _products.Where(p => p.Category == category);
		}
	}
}
