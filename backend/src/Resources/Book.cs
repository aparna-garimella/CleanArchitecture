namespace Resource;

public record Book
    (Guid BookId,
        string Name,
        Author Author,
        DateTime PublishedOn,
        string Edition)
    : IResource;