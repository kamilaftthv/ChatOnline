using ChatOnline.Data;

namespace ChatOnline.Services
{
    public class DataContext
    {
        private List<User> _users = new List<User>();
        private Dictionary<User, Chat> _userChats = new Dictionary<User, Chat>();

        public void AddUser(User user)
        {
            _users.Add(user);
            _userChats[user] = new Chat(user);
        }

        public void DeleteUser(User user)
        {
            _users.Remove(user);
        }
        public void UpdateUser(User user, string username, string status, string avatar)
        {
            user.Username = username;
            user.Status = status;
            user.Avatar = avatar;
        }
    }
}