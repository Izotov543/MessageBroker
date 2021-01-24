using System;

namespace MessageBroker
{
    public sealed class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(IMessage message)
        {
            Message = message;
        }


        public IMessage Message { get; }
    }
}
