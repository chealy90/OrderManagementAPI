namespace OrderManagementAPI.Models
{
    public class SoftPackage: Order, IDeliverable
    {
        public SoftPackage(int orderId, string deliveryAddress, bool isDelivered) : base(orderId, deliveryAddress, isDelivered)
        {
            BaseDeliveryCost = CalculateDeliveryCost();
        }

        public SoftPackage(int orderId, string deliveryAddress) : base(orderId, deliveryAddress)
        {
            BaseDeliveryCost = CalculateDeliveryCost();
        }

        public double CalculateDeliveryCost()
        {
            //soft packages increase delivery cost by 2
            return base.CalculateDeliveryCost() + 2;
        }


    }
}
