namespace OrderManagementAPI.Models
{
    public class DeliveryDriver : User
    {
        public string licensePlate { get; set; }
        public DeliveryDriver(string username, string password, string licensePlate) : base(username, password)
        {
            this.licensePlate = licensePlate;
        }
    }
}
