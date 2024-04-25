namespace ChatOnline.Data
{
    public class User
    {
        public User(string email, string fullname, string password, string username, string status, string avatar)
        {
            Id = Guid.NewGuid().ToString();
            Email = email;
            FullName = fullname;
            Username = username;
            Password = password;
            Status = status;
            Avatar = avatar;
        }
        public string Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Avatar { get; set; }
    }
}
