namespace OrderManagementAPI.Models
{
    public class DeliveryDriver : User
    {
        public string LicensePlate { get; set; }
        public DeliveryDriver(string username, string password, string licensePlate, string role) : base(username, password, role)
        {
            this.LicensePlate = licensePlate;
        }
    }
}
