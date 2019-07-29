namespace MediatR.CQRS
{
    public interface IEventHandler<in T> : INotificationHandler<T> where T : IEvent
    {

    }
}
