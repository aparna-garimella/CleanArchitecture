namespace Resource;

public record Author(Guid AuthorId, string FirstName, string LastName) : IResource;