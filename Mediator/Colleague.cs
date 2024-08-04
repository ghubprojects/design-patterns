namespace Mediator;

public class Colleague(IMediator mediator, string name) {
    protected IMediator mediator = mediator;
    protected string name = name;
}
