using System.Threading.Tasks;

namespace Domain.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : IAggregateRoot
    {
        void Add(TEntity entity);
        TEntity GetBy(int id);

        // todo update delete etc.
    }
}
