using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreateEvent>
    {
        private readonly ITransferRepository _transerRepository;
        public TransferEventHandler(ITransferRepository transerRepository)
        {
            _transerRepository = transerRepository;
        }

        public Task Handle(TransferCreateEvent @event)
        {
            var transferLog = new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            };
            _transerRepository.AddTransferLog(transferLog);
            return Task.CompletedTask;
        }
    }
}
