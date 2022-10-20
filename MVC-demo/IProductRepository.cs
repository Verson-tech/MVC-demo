using System.Data.Common;

namespace MVC_demo
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
   
    }
}
