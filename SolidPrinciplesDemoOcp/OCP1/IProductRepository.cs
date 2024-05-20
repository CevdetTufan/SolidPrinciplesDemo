namespace SolidPrinciplesDemoOcp.OCP1
{
	public interface IProductRepository
	{
		ProductModel GetById(int id);
		IEnumerable<ProductModel> GetAll();
		void Add(ProductModel product);
		void Remove(int id);

		// New method to filter products by category
		IEnumerable<ProductModel> GetByCategory(string category);
	}
	
	public class ProductModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string Category { get; set; }
	}
}
