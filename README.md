# MessageBroker
Test task solution

Реализовать брокер сообщений:
Сигнатура брокера для публикации:
void Post(IMessage message);

Сигнатура брокера для подписки:
void Subscribe(ISubscriber Subscriber);
void Unsubscribe(ISubscriber Subscriber);

Содержимое IMessage и ISubscriber определить кандидатом.

Требования к решениям:
1) Основное ядро должно быть написано кандидатом.
2) Предоставляемый код должен собираться и работать.
3) Функционал должен быть покрыт минимальным набором тестов.
4) Стиль кодирования должно соответствовать МS и Code Style Guide (STS)
