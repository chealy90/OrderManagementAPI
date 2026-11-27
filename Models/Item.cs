namespace OrderManagementAPI.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int Quantity { get; set; }
        public Item(int itemId, string itemName, double itemPrice, int quantity)
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemPrice = itemPrice;
            Quantity = quantity;
        }
    }
}
