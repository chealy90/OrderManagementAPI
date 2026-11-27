namespace OrderManagementAPI.Models
{
    public class StoreAssistant : User
    {
        public string Department { get; set; }
        public StoreAssistant(string username, string password, string department, string role) : base(username, password, role)
        {
            this.Department = department;
        }
    }
}
