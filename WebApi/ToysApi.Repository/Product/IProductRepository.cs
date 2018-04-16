using System.Collections.Generic;
using ToysApi.Model;

namespace ToysApi.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
    }
}