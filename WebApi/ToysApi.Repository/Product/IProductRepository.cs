using System.Collections.Generic;
using System.Threading.Tasks;
using ToysApi.Model;

namespace ToysApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
    }
}