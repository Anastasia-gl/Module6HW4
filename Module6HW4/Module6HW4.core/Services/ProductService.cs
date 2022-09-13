using Module6HW4.core.Interfaces;
using Module6HW4.core.Entity;
namespace Module6HW4.core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductStore _productStore;


        public ProductService(IProductStore productStore)
        {
            _productStore = productStore;
        }

        public Product ProductAdd(Product product)
        {
            _productStore.Add(product);
            return product;
        }

        public Product ProductDelete(int id)
        {
            return _productStore.Delete(id);
        }

        public void ProductUpdate(Product product)
        {
            if (product != null)
            {
                _productStore.Update(product);
            }
        }

        public IList<Product> GetProductById(int id)
        {
            var list = _productStore.Get(id);
            return list;

        }

        public IList<Product> GetAll()
        {
            return _productStore.GetAll();
        }
    }
}
