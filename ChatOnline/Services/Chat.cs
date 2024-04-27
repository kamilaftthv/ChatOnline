using ChatOnline.Data;

namespace ChatOnline.Services
{
    public class Chat
    {
        public User User { get; }
        public List<ChatMessage> Messages { get; } = new List<ChatMessage>();
        public Chat(User user)
        {
            User = user;
        }
    }
}
