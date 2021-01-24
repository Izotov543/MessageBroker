namespace MessageBroker
{
    public interface ISubscriber
    {
        /// <summary>
        /// Does something with <see cref="MessageEventArgs"/> <paramref name="e"/>
        /// which contains <see cref="IMessage"/> 
        /// </summary>
        public void DoSomething(object sender, MessageEventArgs e);
    }
}
