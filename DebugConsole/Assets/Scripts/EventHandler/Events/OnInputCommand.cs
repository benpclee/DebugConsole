using EventHandler.Interfaces;

namespace EventHandler.Events
{
    public readonly struct OnInputCommand : IEvent
    {
        public OnInputCommand(string commandStatement)
        {
            CommandStatement = commandStatement;
        }
        
        public string CommandStatement { get; }
    }
}