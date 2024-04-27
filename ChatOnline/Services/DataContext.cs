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
            _userChats.Remove(user);
        }
        public void UpdateUser(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.FullName = user.FullName;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.Status = user.Status;
                existingUser.Avatar = user.Avatar;
            }
        }
        public void AddChat(User user)
        {
            if (!_userChats.ContainsKey(user))
            {
                var newChat = new Chat(user);
                _userChats[user] = newChat;
            }
        }
        public void DeleteChat(Chat chat)
        {
            chat.Messages.Clear();
        }
        public void UpdateChat(Chat chat)
        {
            if (chat.Messages.Count > 0)
            {
                chat.Messages.RemoveAt(chat.Messages.Count - 1);
            }
        }
    }
}