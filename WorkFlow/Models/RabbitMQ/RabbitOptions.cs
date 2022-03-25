namespace WorkFlow.Models.RabbitMQ
{
    public class RabbitOptions
    {
        public string Host { get; set; }
        public string VirtualHost { get; set; } = "/";
        public string User { get; set; }
        public string Password { get; set; }
    }
}
