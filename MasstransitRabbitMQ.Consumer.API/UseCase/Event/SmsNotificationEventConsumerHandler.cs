using MasstransitRabbitMQ.Contract;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API
{
    public class SmsNotificationEventConsumerHandler : IRequestHandler<DomainEvent.SmsNotificationEvent>
    {
        private readonly ILogger<SmsNotificationEventConsumerHandler> _logger;

        public SmsNotificationEventConsumerHandler(ILogger<SmsNotificationEventConsumerHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(DomainEvent.SmsNotificationEvent request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Message received: {messasge}", request);
        }
    }
}
