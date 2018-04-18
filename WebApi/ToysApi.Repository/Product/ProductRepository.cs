using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysApi.Model;

namespace ToysApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private IEnumerable<Product> products = new List<Product>() {
            new Product(){ Id = 1, Name = "Teady bear", Description = "Big teady bear", Price = 24, Rating = 4.5 },
            new Product(){ Id = 2, Name = "Bricks", Description = "200 pieces", Price = 30, Rating = 3.5 },
            new Product(){ Id = 3, Name = "Doll", Description = "Small, pink dall", Price = 15, Rating = 4.2 }};

        public Task<Product> GetProduct(int id)
        {
            return Task.Run(() => products.FirstOrDefault(x => x.Id == id));
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            return Task.Run(()=>products);
        }
    } 
}
