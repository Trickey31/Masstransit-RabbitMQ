using MassTransit;

namespace MasstransitRabbitMQ.Contract
{
    [ExcludeFromTopology]
    public interface IMessage
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
