namespace Mediator;

public interface IMediator {
    void Join(Notification sender, User participant);
    void Broadcast(Colleague sender, string message);
    void Send(User sender, User receiver, string message);
}