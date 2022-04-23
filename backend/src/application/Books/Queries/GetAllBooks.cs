using CleanArchitecture.Application.Common.CQRS;
using Resource;

namespace CleanArchitecture.Application.Books.Queries
{
    public record GetAllBooksQuery : IQuery<BookCollection> { }

    public class GetAllBooksQueryHandler : IQueryHandler<GetAllBooksQuery, BookCollection>
    {
        public Task<BookCollection> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new BookCollection(
                new List<Book>()
                {
                    new Book(Guid.NewGuid(), "Harry Potter and the Philosopher's Stone",
                        new Author(Guid.NewGuid(), "J.K.", "Rowling"), new DateTime(1998, 10, 1), "1"),
                }));
        }
    }
}
