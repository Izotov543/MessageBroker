using FakeItEasy;
using NUnit.Framework;
using System;

namespace MessageBroker.Tests
{
    [TestFixture]
    public class MessageBrokerTests
    {
        [Test]
        public void MessageBrokerPostesMessage()
        {
            //Arrange
            IMessageBroker messageBroker = new MessageBroker();
            ISubscriber fakeSubscriber = A.Fake<ISubscriber>();
            IMessage fakeMessage = A.Fake<IMessage>();
            messageBroker.Subscribe(fakeSubscriber);
            A.CallTo(() => fakeMessage.MessageEntry).Returns("Test message");
            A.CallTo(() => fakeMessage.DateTime).Returns(DateTime.Now);

            //Act
            messageBroker.Post(fakeMessage);

            //Assert
            A.CallTo(() => fakeSubscriber.DoSomething(
                A<IMessageBroker>.That.IsSameAs(messageBroker),
                A<MessageEventArgs>.That.IsSameAs(new MessageEventArgs(fakeMessage))));
        }


        [Test]
        public void MessageBrokerSubscribes()
        {
            //Arrange
            IMessageBroker messageBroker = new MessageBroker();
            ISubscriber fakeSubscriber = A.Fake<ISubscriber>();

            //Act
            messageBroker.Subscribe(fakeSubscriber);
            messageBroker.Post(A.Fake<IMessage>());

            //Assert
            A.CallTo(() => fakeSubscriber.DoSomething(
                A<IMessageBroker>.That.IsSameAs(messageBroker), 
                A<MessageEventArgs>.Ignored))
                .MustHaveHappened();
        }


        [Test]
        public void MessageBrokerUnsubscribes()
        {
            //Arrange
            IMessageBroker messageBroker = new MessageBroker();
            ISubscriber fakeSubscriber = A.Fake<ISubscriber>();

            //Act
            messageBroker.Subscribe(fakeSubscriber);
            messageBroker.Post(A.Fake<IMessage>());
            messageBroker.Unsubscribe(fakeSubscriber);
            messageBroker.Post(A.Fake<IMessage>());

            //Assert
            A.CallTo(() => fakeSubscriber.DoSomething(
                A<IMessageBroker>.That.IsSameAs(messageBroker), 
                A<MessageEventArgs>.Ignored))
                .MustHaveHappenedOnceExactly();
        }
    }
}