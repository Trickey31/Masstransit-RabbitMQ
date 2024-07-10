using MassTransit;

namespace MasstransitRabbitMQ.Producer.API
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddConfigureMasstransitRabbitMQ(this IServiceCollection services, IConfiguration configuration)
        {
            var config = new MasstransitConfiguration();

            configuration.GetSection(nameof(MasstransitConfiguration)).Bind(config);

            services.AddMassTransit(mt =>
            {
                mt.UsingRabbitMq((context, bus) =>
                {
                    bus.Host(config.Host, config.VHost, x =>
                    {
                        x.Username(config.UserName);
                        x.Password(config.Password);
                    });
                });
            });

            return services;
        }
    }
}
