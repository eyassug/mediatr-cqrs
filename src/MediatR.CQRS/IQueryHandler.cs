namespace MediatR.CQRS
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
    {
    }
}
