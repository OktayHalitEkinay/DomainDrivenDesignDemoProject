using Domain.SeedWork;


namespace Domain.AggregateModels.OrderModels
{
    public class Order:BaseEntity,IAggregateRoot
    {
        public DateTime OrderDate { get;private set; }
        public string Description { get; private set; }    
        public string OrderStatus { get; private set; }
        public int BuyerId { get; private set; }
        public Address Address { get; private set; }
        public List<OrderItem> OrderItems { get; private set; }

        public Order(DateTime orderDate, string description, string orderStatus, int buyerId, Address address, List<OrderItem> orderItems)
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
            BuyerId = buyerId;
            Address = address;
            OrderItems = orderItems;
        }
        public void AddOrderItem(OrderItem item)
        {

        }
    }
}
