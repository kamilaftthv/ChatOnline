using ChatOnline.Data;

namespace ChatOnline.Services
{
    public class UserContext
    {
        private List<User> _users = new List<User>();
        public void CreateUser(string email, string fullname, string password, string username, string status, string avatar)
        {
            var newUser = new User(email, fullname, password, username, status, avatar);
            _users.Add(newUser);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public bool UserExists(string username, string password)
        {
            return _users.Any(u => u.Username == username && u.Password == password);
        }

        public List<User> SearchUsers(string searchTerm)
        {
            return _users.Where(u => u.Username.Contains(searchTerm)).ToList();
        }


        private Dictionary<User, Chat> _userChats = new Dictionary<User, Chat>();

        public void AddUser(User user)
        {
            if (!_userChats.ContainsKey(user))
            {
                _userChats[user] = new Chat(user);
            }
        }

        public Chat GetChatForUser(User user)
        {
            if (_userChats.ContainsKey(user))
            {
                return _userChats[user];
            }
            else
            {
                var newChat = new Chat(user);
                _userChats[user] = newChat;
                return newChat;
            }
        }
    }
}