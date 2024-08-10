namespace Mediator;

public class User(IMediator mediator, string name) : Colleague(mediator, name) {

    public void Broadcast(string message) {
        mediator.Broadcast(this, message);
    }

    public void Receive(Colleague sender, string message) {
        Console.WriteLine("{0,-20} | {1,-20} | {2}", name, sender.name, message);
    }

    public void Send(User target, string message) {
        mediator.Send(this, target, message);
    }
}