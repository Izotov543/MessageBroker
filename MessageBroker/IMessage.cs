using System;

namespace MessageBroker
{
    /// <summary>
    /// Contains <paramref name="MessageEntry"/> and <paramref name="DateTime"/> of this message
    /// </summary>
    public interface IMessage
    {
        public DateTime DateTime { get; }
        public string MessageEntry { get; }
    }
}
