using MassTransit;
using MasstransitRabbitMQ.Contract;
using MasstransitRabbitMQ.Contracte;

namespace MasstransitRabbitMQ.Consumer.API
{
    public abstract class Consumer<TMessage> : IConsumer<TMessage> where TMessage : class, INotificationEvent
    {
        public async Task Consume(ConsumeContext<TMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}
