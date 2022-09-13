using Module6HW4.core.Entity;
namespace Module6HW4.core.Interfaces
{
    public interface IProductService
    {
        public Product ProductAdd(Product product);

        public Product ProductDelete(int id);

        public void ProductUpdate(Product product);

        public IList<Product> GetProductById(int id);

        public IList<Product> GetAll();
    }
}
