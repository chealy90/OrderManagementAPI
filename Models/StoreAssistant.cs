namespace OrderManagementAPI.Models
{
    public class StoreAssistant : User
    {
        public string department { get; set; }
        public StoreAssistant(string username, string password, string department) : base(username, password)
        {
            this.department = department;
        }
    }
}
