namespace OrderManagementAPI.Models
{
    public class LargeParcel : Order, IDeliverable
    {
        public LargeParcel(int orderId, string deliveryAddress, bool isDelivered) : base(orderId, deliveryAddress, isDelivered)
        {
            BaseDeliveryCost = CalculateDeliveryCost();
        }

        public LargeParcel(int orderId, string deliveryAddress) : base(orderId, deliveryAddress)
        {
            BaseDeliveryCost = CalculateDeliveryCost();
        }

        public double CalculateDeliveryCost()
        {
            //large parcels increase delivery cost by 6
            return base.CalculateDeliveryCost() + 6;
        }


    }
}
