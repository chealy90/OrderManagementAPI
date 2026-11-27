namespace OrderManagementAPI.Models
{
    public interface IDeliverable
    {
        public int OrderId { get; set; }
        public string DeliveryAddress { get; set; }
        public bool IsDelivered { get; set; }
        public double BaseDeliveryCost { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        abstract double CalculateDeliveryCost();
        
    }
}
