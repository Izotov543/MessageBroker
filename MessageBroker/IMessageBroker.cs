namespace MessageBroker
{
    public interface IMessageBroker
    {
        /// <summary>
        /// Posts new <see cref="IMessage"/> <paramref name="message"/>
        /// to subscribed <see cref="ISubscriber"/>s
        /// </summary>
        public void Post(IMessage message);


        /// <summary>
        /// Subscribes <see cref="ISubscriber"/> <paramref name="subscriber"/>
        /// for receiving of new <see cref="IMessage"/>s
        /// </summary>
        public void Subscribe(ISubscriber subscriber);


        /// <summary>
        /// Unsubscribes <see cref="ISubscriber"/> <paramref name="subscriber"/>
        /// from receiving of new <see cref="IMessage"/>s
        /// </summary>
        public void Unsubscribe(ISubscriber subscriber);
    }
}
