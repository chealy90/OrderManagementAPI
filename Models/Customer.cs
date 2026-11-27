namespace OrderManagementAPI.Models
{
    public class Customer : User
    {
        public string address { get; set; }
        public Customer(string username, string password, string address) : base(username, password)
        {
            this.address = address;
        }
    }
}
