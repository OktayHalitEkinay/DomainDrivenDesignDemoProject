

using Application.Interfaces.Repositories;
using Domain.AggregateModels.BuyerModels;
using Domain.Events;
using MediatR;

namespace Application.DomainEventsHandlers
{
    public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IBuyerRepository _buyerRepository;

        public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            if (notification.Order.BuyerId==0)
            {
                Buyer buyer = new(notification.Buyer.FirstName,notification.Buyer.LastName);
                _buyerRepository.AddAsync(buyer);
            }            
        }
    }
}
