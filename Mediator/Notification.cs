namespace Mediator;
public class Notification(Chatroom mediator) : Colleague {
    private readonly Chatroom _mediator = mediator;
}
