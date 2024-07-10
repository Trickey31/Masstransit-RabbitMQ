using static MasstransitRabbitMQ.Contract.DomainEvent;

namespace MasstransitRabbitMQ.Consumer.API
{
    public class SendSmsWhenReceivedSmsEventConsumer : Consumer<SmsNotificationEvent>
    {
        public SendSmsWhenReceivedSmsEventConsumer()
        {

        }
    }
}
 