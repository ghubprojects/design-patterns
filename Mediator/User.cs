namespace Mediator;

public class User(IMediator mediator, string name) : Colleague(mediator, name) {

    public void Broadcast(string message) {
        mediator.Broadcast(this, message);
    }

    public void Receive(Colleague sender, string message) {
        Console.WriteLine($"{name} chat screen: {sender.name}: Aye Aye Captain !!!");
    }

    public void Send(Colleague target, string message) {
        mediator.Send(this, target, message);
    }
}
