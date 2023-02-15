using Dapper;
using System.Collections;
using System.Data;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }
    }
        /*public System.Collections.IEnumerable<Product> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }
    } */
}
