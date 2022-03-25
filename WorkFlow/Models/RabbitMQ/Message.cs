namespace WorkFlow.Models.RabbitMQ
{
    public class Message
    {
        public MessageHeader Header { get; set; }
        public MessageBody Body { get; set; }
        public MessageSecurity Security { get; set; }
    }
    public class MessageHeader
    {
        public string MessageId { get; set; }
        public DateTime ResponseDate { get; set; }
        public long CurrUserId { get; set; }
        public List<Error> Errors { get; set; }
    }
    public class Error
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public DateTime ErrorTime { get; set; }
    }
    public class MessageBody
    {
        public dynamic Content { get; set; }
    }

    public class MessageSecurity
    {
        public string Signature { get; set; }
    }
}
