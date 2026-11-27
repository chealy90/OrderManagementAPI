namespace OrderManagementAPI.Models
{
    public class SmallParcel : Order, IDeliverable
    {
        public SmallParcel(int orderId, string deliveryAddress, bool isDelivered) : base(orderId, deliveryAddress, isDelivered)
        {
            BaseDeliveryCost = CalculateDeliveryCost();
        }

        public SmallParcel(int orderId, string deliveryAddress) : base(orderId, deliveryAddress)
        {
            BaseDeliveryCost = CalculateDeliveryCost();
        }

        public double CalculateDeliveryCost()
        {
            //small parcels increase delivery cost by 4
            return base.CalculateDeliveryCost() + 4;
        }


    }
}
