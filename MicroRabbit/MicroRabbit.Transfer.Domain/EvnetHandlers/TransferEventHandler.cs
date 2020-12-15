
using MicroRabbit.Banking.Domain.Evnets;
using MicroRabbit.Domain.Core.Bus;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EvnetHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {

        }

        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
