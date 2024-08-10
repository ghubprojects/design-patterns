namespace Mediator;

public class Notification(IMediator mediator, string name) : Colleague(mediator, name) {
    public void Broadcast(string message) {
        mediator.Broadcast(this, message);
    }
}