namespace OrderManagementAPI.Models
{
    public class Customer : User
    {
        public string Address { get; set; }
        public Customer(string username, string password, string address, string role) : base(username, password, role)
        {
            this.Address = address;
        }
    }
}
