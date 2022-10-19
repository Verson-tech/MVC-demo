using Dapper;
using System.Data;

namespace MVC_demo
{
    public class ProductRepository
    {

        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducys()
        {
            return _connection.Query<Product>("SELECT * FROM");
        }
    }
}
