using Module6HW4.core.Interfaces;
using Module6HW4.core.Entity;

namespace Module6HW4.infrasctracture
{
    public class ProductStore : IProductStore
    {
        public IList<Product> Products { get; }
        public ProductStore()
        {
            Products = new List<Product>()
            {
               new Product{Id=1, Name="a", Price=10},
               new Product{Id=2, Name="b", Price=10}
            };
        }

        public void Add(Product products)
        {
            Products.Add(products);
        }

        public Product Delete(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);
			if (product != null)
			{
                Products.Remove(product);
			}
            return product;
        }

        public IList<Product> Get(int id)
        {
            var products = Products.ToList().Where(p => p.Id == id).ToList();
            return products;
        }

        public void Update(Product product)
        {
            var index = Products.ToList().FindIndex(p => p.Id == product.Id);

            Products[index] = product;
        }

        public IList<Product> GetAll()
        {
            var list = Products.ToList();
            return list;

        }
    }
}
