using ChatOnline.Data;

namespace ChatOnline.Services
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
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

    public class Chat
    {
        public User User { get; }
        public List<ChatMessage> Messages { get; } = new List<ChatMessage>();

        public void UpdateMessages(List<ChatMessage> messages)
        {
            Messages.Clear();
            Messages.AddRange(messages);
        }

        public void AddMessage(ChatMessage message)
        {
            Messages.Add(message);
        }

        public void DeleteMessage(ChatMessage message)
        {
            Messages.Remove(message);
        }

        public Chat(User user)
        {
            User = user;
        }
    }

}