namespace OrderManagementAPI.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int Quantity { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); //needed to link to m.m table
        public ICollection<Order> Orders { get; set; } = new List<Order>(); //needed to link to m.m table

        public Item(int itemId, string itemName, double itemPrice, int quantity)
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemPrice = itemPrice;
            Quantity = quantity;
        }
    }
}
