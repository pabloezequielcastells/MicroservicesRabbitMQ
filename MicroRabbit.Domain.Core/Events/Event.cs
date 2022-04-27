namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timespan { get; protected set; }

        protected Event()
        {
            Timespan = DateTime.Now;    
        }
    }
}
