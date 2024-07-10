using MassTransit;
using Microsoft.AspNetCore.Mvc;
using static MasstransitRabbitMQ.Contract.DomainEvent;

namespace MasstransitRabbitMQ.Producer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducerController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public ProducerController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost]
        public async Task<IActionResult> PublishSmsNotificationEvent()
        {
            var smsEvent = new SmsNotificationEvent()
            {
                Id = Guid.NewGuid(),
                Name = "sms notification",
                CreatedDate = DateTime.Now,
                Type = "sms"
            };

            await _publishEndpoint.Publish(smsEvent);

            return Accepted();
        }
    }
}
