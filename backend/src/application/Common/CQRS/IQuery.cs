using MediatR;

namespace CleanArchitecture.Application.Common.CQRS
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : class
    {
    }
}
