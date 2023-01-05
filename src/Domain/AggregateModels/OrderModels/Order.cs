using Domain.AggregateModels.BuyerModels;
using Domain.Events;
using Domain.SeedWork;
using MediatR;

namespace Domain.AggregateModels.OrderModels
{
    public class Order:BaseEntity,IAggregateRoot
    {
        public DateTime OrderDate { get;private set; }
        public string Description { get; private set; }    
        public string OrderStatus { get; private set; }
        public Buyer Buyer { get; private set; }
        public Address Address { get; private set; }
        public List<OrderItem> OrderItems { get; private set; }

        public Order(DateTime orderDate, string description, string orderStatus, Buyer buyer, Address address, List<OrderItem> orderItems)
        {
            if (OrderDate<DateTime.Now)
            {
                throw new Exception("Tarih bugünün tarihinden eski olamaz!");
            }
            if (address.City=="")
            {
                throw new Exception("Şehir bilgisi boş geçilemez!");
            }

            OrderDate = orderDate;
            Description = description;
            OrderStatus = orderStatus;
            Buyer = buyer;
            Address = address;
            OrderItems = orderItems;

            AddDomainEvents(new OrderStartedDomainEvent(buyer,this));
        }
        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItem _orderItem = new(orderItem.Quantity,orderItem.Price,orderItem.ProductId);
            OrderItems.Add(_orderItem);
        }
    }
}
