namespace OrderManagementAPI.Models
{
    public class Order : IDeliverable
    {
        public int OrderId { get; set; }
        public string DeliveryAddress { get; set; }
        public bool IsDelivered { get; set; }
        public double BaseDeliveryCost { get; set; }
        public Dictionary<Item, int> OrderItems { get; set; } = new Dictionary<Item, int>();
        public Order(int orderId, string deliveryAddress, bool isDelivered)
        {
            OrderId = orderId;
            DeliveryAddress = deliveryAddress;
            IsDelivered = isDelivered;
            BaseDeliveryCost = CalculateDeliveryCost();

        }

        public Order(int OrderId, string deliveryAddress)
        {
            this.OrderId = OrderId;
            this.DeliveryAddress = deliveryAddress;
            this.IsDelivered = false;
            BaseDeliveryCost = CalculateDeliveryCost();
        }

        public double CalculateDeliveryCost()
        {
            //minimum is 5, decorators add extra depending on package 
            if (this.BaseDeliveryCost == null)
            {
                return 5;

            }
            else
            {
                return this.BaseDeliveryCost;
            }
    }
}
