using MassTransit;
using MediatR;

namespace MasstransitRabbitMQ.Contract
{
    public interface IMessage : IRequest
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
