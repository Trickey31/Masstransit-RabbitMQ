using MasstransitRabbitMQ.Contract;

namespace MasstransitRabbitMQ.Contract
{
    public static class DomainEvent
    {
        public record SmsNotificationEvent : INotificationEvent
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public Guid TransactionId { get; set; }
            public Guid Id { get; set; }
            public DateTime CreatedDate { get; set; }
        }
    }
}
