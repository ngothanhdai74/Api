using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using System.Reflection;
using WorkFlow.Models.RabbitMQ;

namespace WorkFlow.Extensions.RabbitMQ
{
    public static class RabbitMQExtensions
    {
        public static IServiceCollection AddRabbitMQ(this IServiceCollection services, IConfiguration configuration)
        {
            var options = new RabbitOptions();
            configuration.GetSection(nameof(RabbitOptions)).Bind(options);
            string connectionString = $"host={options.Host};virtualHost={options.VirtualHost};username={options.User};password={options.Password}";
            var instance = RabbitHutch.CreateBus(connectionString);
            services.AddSingleton(instance);
            return services;
        }
        public static async void UseRabbitMQ(this IApplicationBuilder app)
        {
            var bus = app.ApplicationServices.GetRequiredService<IBus>();
            await bus.Custom();
            var subscriber = new AutoSubscriber(bus, Guid.NewGuid().ToString());
            subscriber.Subscribe(Assembly.GetExecutingAssembly().GetTypes());
        }
        public static async Task Publish<T>(this IBus bus, T message)
        {
            var advanced = bus.Advanced;
            if(advanced.IsConnected)
            {
                await bus.PubSub.PublishAsync(message);
            }
            else
            {
                throw new Exception("RabbitMQ DIE");
            }
        }
        public static async Task Custom(this IBus bus)
        {
            var advanced = bus.Advanced;
            advanced.Blocked += Advanced_Blocked;
            advanced.Connected += Advanced_Connected;
            advanced.Disconnected += Advanced_Disconnected;
            advanced.MessageReturned += Advanced_MessageReturned;
            advanced.Unblocked += Advanced_Unblocked;
        }

        private static void Advanced_Unblocked(object? sender, EventArgs e)
        {
        }

        private static void Advanced_MessageReturned(object? sender, MessageReturnedEventArgs e)
        {
        }

        private static void Advanced_Disconnected(object? sender, DisconnectedEventArgs e)
        {
        }

        private static void Advanced_Connected(object? sender, ConnectedEventArgs e)
        {
        }

        private static void Advanced_Blocked(object? sender, BlockedEventArgs e)
        {
        }
    }
}
