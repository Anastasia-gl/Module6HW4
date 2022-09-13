using Module6HW4.core.Entity;
namespace Module6HW4.core.Interfaces
{
    public interface IProductStore
    {
        public void Add(Product product);
        public Product Delete(int id);
        public void Update(Product product);
        public IList<Product> Get(int id);
        public IList<Product> GetAll();
    }
}
