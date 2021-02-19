using Domain.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Feed
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetPopularProduct(int count);
    }
}
