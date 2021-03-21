using Messages.Events;
using NServiceBus;
using NServiceBus.Logging;
using System.Threading.Tasks;

namespace Billing
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        private static ILog log = LogManager.GetLogger<OrderPlacedHandler>();

        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderPlaced, OrderId = {message.OrderId} - Should we ship now?");

            return Task.CompletedTask;
        }
    }
}