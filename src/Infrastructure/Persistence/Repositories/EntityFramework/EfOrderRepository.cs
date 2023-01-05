using Application.Interfaces.Repositories;
using Domain.AggregateModels.OrderModels;
using Persistence.Context;


namespace Persistence.Repositories.EntityFramework
{
    public class OrderRepository : EfGenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    }
}
