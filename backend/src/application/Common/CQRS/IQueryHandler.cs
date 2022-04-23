using MediatR;
using Resource;

namespace CleanArchitecture.Application.Common.CQRS;

public interface IQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IQuery<TResponse>
    where TResponse : class, IResource
{
}