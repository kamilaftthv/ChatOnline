using ChatOnline.Data;

namespace ChatOnline.Services
{
    public class Chat
    {
        public User User { get; }
        public List<ChatMessage> Messages { get; } = new List<ChatMessage>();

        public void UpdateMessages(List<ChatMessage> messages)
        {
            Messages.Clear();
            Messages.AddRange(messages);
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
