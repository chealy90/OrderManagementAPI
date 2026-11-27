namespace OrderManagementAPI.Models
{
    public abstract class User
    {
        //public 
        public int? Id { get;}
        public string username { get; }

        //private
        private string password { get; set; }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            //TODO: hash password
        }
        
    }
}
