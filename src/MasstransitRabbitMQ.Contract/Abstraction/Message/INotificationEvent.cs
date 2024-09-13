using MassTransit;

namespace MasstransitRabbitMQ.Contract
{
    [ExcludeFromTopology]
    public interface INotificationEvent : IMessage
    {
    }
}
