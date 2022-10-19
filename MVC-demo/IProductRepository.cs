namespace MVC_demo
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
