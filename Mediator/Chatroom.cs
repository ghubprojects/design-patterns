namespace Mediator;

public class Chatroom : IMediator {
    private readonly List<User> users = [];

    public void Join(Notification sender, User participant) {
        users.Add(participant);
        Broadcast(sender, $"{participant.name} Joins the chatroom");
    }

    public void Broadcast(Colleague sender, string message) {
        users.ForEach(x => {
            if (!x.Equals(sender))
                x.Receive(sender, message);
        });
    }

    public void Send(User sender, User receiver, string message) {
        users.ForEach(x => {
            if (x.Equals(receiver))
                x.Receive(sender, message);
        });
    }
}