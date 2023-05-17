using EventHandler.Interfaces;

namespace EventHandler.Events
{
    public readonly struct OnGainMoney : IEvent
    {
        public int Number { get; }

        public OnGainMoney(int number)
        {
            Number = number;
        }
    }
}
