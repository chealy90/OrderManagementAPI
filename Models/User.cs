namespace OrderManagementAPI.Models
{
    public class User
    {
        //public 
        public int UserId { get; set; }
        public string Username { get; }
        public string Role { get; set; } = "user";

        //private
        private string Password { get; set; }

        public User() { }

        public User(string username, string password, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            //TODO: hash password
        }
        
    }
}
