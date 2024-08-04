namespace Mediator;

public class Chatroom : IMediator {
    private List<User> users = [];

    public void Broadcast(Colleague sender, string message) {
        throw new NotImplementedException();
    }

    public void Join(Colleague participant) {
        string msg_join = p->name + " Joins the chatroom";
			broadcast ("chatroom", msg_join);
			p->room = this;
			persons.push_back (p);
    }

    public void Message(Colleague sender, Colleague receiver, string message) {
        throw new NotImplementedException();
    }
}