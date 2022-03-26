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
        public static void UseEasyNetQ(this IApplicationBuilder app)
        {
            var bus = app.ApplicationServices.GetRequiredService<IBus>();
            var subscriber = new AutoSubscriber(bus, Guid.NewGuid().ToString());
            subscriber.Subscribe(Assembly.GetExecutingAssembly().GetTypes());
        }
    }
}
