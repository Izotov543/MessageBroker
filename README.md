# MessageBroker
Test task solution

Реализовать брокер сообщений:
Сигнатура брокера для публикации:
void Post(IMessage message);

Сигнатура брокера для подписки:
void Subscribe(ISubscriber Subscriber);
void Unsubscribe(ISubscriber Subscriber);

Содержимое IMessage и ISubscriber определить кандидатом.
