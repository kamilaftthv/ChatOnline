namespace ChatOnline.Data
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public ChatMessage(string author, string message, DateTime timestamp, int id)
        {
            Author = author;
            Message = message;
            Timestamp = timestamp;
            Id = id;
        }
    }
}
