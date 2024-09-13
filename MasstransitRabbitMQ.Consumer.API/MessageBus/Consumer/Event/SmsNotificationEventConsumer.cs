using static MasstransitRabbitMQ.Contract.DomainEvent;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API
{
    public class SmsNotificationEventConsumer : Consumer<SmsNotificationEvent>
    {
        public SmsNotificationEventConsumer(ISender sender) : base(sender) { }
    }
}
 