using MassTransit;
using MasstransitRabbitMQ.Consumer.API.DependencyInjection.Extensions;
using System.Reflection;

namespace MasstransitRabbitMQ.Consumer.API
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMediatR(this IServiceCollection services)
            => services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

        public static IServiceCollection AddConfigureMasstransitRabbitMQ(this IServiceCollection services, IConfiguration configuration)
        {
            var config = new MasstransitConfiguration();

            configuration.GetSection(nameof(MasstransitConfiguration)).Bind(config);

            services.AddMassTransit(mt =>
            {
                mt.AddConsumers(Assembly.GetExecutingAssembly());

                mt.SetKebabCaseEndpointNameFormatter();

                mt.UsingRabbitMq((context, bus) =>
                {
                    bus.Host(config.Host, config.VHost, x =>
                    {
                        x.Username(config.UserName);
                        x.Password(config.Password);
                    });

                    bus.MessageTopology.SetEntityNameFormatter(new KebabCaseEntityNameFormatter());

                    bus.ConfigureEndpoints(context);
                });
            });

            return services;
        }
    }
}
