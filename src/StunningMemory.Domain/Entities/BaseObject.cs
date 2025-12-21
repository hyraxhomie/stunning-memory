namespace StunningMemory.Domain.Entities;

public abstract class BaseObject
{
    Guid id { get; set; }
    string Name { get; set; }
    string DisplayName { get; set; }
    string Description { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime LastModified { get; set; }
}