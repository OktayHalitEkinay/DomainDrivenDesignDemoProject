
using Domain.SeedWork;

namespace Application.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> 
        where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> AddAsync(TEntity entity);

    }
}
