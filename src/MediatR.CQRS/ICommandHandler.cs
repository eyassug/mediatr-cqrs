namespace MediatR.CQRS
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand> where TCommand : ICommand
    {

    }
}
