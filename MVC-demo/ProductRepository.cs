using Dapper;
using System.Data;

namespace MVC_demo
{
    public class ProductRepository : IProductRepository
    {

        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }



        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM PRODUCTS");
        }
    }
}
