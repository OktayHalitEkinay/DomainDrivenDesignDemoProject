using Application.Interfaces.Repositories;
using Domain.AggregateModels.BuyerModels;
using Domain.AggregateModels.OrderModels;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.EntityFramework
{
    public class BuyerRepository : EfGenericRepository<Buyer>, IBuyerRepository
    {
        public BuyerRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    }
}
