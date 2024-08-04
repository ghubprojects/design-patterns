namespace Mediator;

public interface IMediator {
    void Join(Colleague participant);
    void Broadcast(Colleague sender, string message);
    void Send(Colleague sender, Colleague receiver, string message);
}