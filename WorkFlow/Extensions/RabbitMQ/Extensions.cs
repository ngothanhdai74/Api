using System.Reflection;
using WorkFlow.Models.RabbitMQ;

namespace WorkFlow.Extensions.RabbitMQ
{
    public static class RabbitMQExtensions
    {
        public static IServiceCollection AddRabbitMQ(this IServiceCollection services, IConfiguration configuration, params Assembly[] assemblies)
        {
            var options = new RabbitOptions();
            configuration.GetSection(nameof(RabbitOptions)).Bind(options);
            return null;
        }
    }
}
