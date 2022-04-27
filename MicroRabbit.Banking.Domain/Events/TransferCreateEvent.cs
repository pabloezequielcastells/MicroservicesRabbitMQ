using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreateEvent : Event
    {
        public TransferCreateEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }

        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }
    }
}
