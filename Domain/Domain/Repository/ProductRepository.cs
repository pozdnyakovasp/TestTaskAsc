using Domain.Feed;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetPopularProduct(int count)
        {
            throw new NotImplementedException();
        }
    }
}
