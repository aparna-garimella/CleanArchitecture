using MediatR;
using Resource;

namespace CleanArchitecture.Application.Common.CQRS
{
    public interface ICommand<out TResponse> : IRequest<TResponse> where TResponse : IResource
    {
    }
}
