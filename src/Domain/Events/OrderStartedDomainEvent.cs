using Domain.AggregateModels.BuyerModels;
using Domain.AggregateModels.OrderModels;
using MediatR;


namespace Domain.Events
{
    public class OrderStartedDomainEvent:INotification
    {
        public Buyer Buyer { get; set; }
        public Order Order { get; set; }
    }
}
