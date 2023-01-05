using Application.Interfaces.Repositories;
using Domain.AggregateModels.OrderModels;
using MediatR;
using Shared.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class AddOrder : IRequest<IDataResult<Order>>
    {
        Order order;

        public class AddOrderHandler : IRequestHandler<AddOrder, IDataResult<Order>>
        {
            private readonly IOrderRepository _orderRepository;

            public AddOrderHandler(IOrderRepository orderRepository)
            {
                _orderRepository = orderRepository;
            }
            public async Task<IDataResult<Order>> Handle(AddOrder request, CancellationToken cancellationToken)
            {
                Order result = _orderRepository.AddAsync(request.order);
                return new SuccessDataResult<Order>(result);
            }
        }
    }
}
