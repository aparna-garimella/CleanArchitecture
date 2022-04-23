using MediatR;
using Resource;

namespace CleanArchitecture.Application.Common.CQRS
{
    public interface ICommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : ICommand<TResponse>
    where TResponse : IResource
    {
    }
}
