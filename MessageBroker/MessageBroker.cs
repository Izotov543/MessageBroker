using System;

namespace MessageBroker
{
    /// <summary>
    /// Concrete example of implementation of the <see cref="IMessageBroker"/> interface
    /// </summary>
    public sealed class MessageBroker : IMessageBroker
    {
        private event EventHandler<MessageEventArgs> OnNewMessage;


        void IMessageBroker.Post(IMessage message)
        {
            OnNewMessage?.Invoke(this, new MessageEventArgs(message));
        }


        void IMessageBroker.Subscribe(ISubscriber subscriber)
        {
            OnNewMessage += new EventHandler<MessageEventArgs>(subscriber.DoSomething);
        }


        void IMessageBroker.Unsubscribe(ISubscriber subscriber)
        {
            OnNewMessage -= new EventHandler<MessageEventArgs>(subscriber.DoSomething);
        }
    }
}
