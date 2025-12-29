namespace StunningMemory.Domain.Entities;

public abstract class Entity
{
    public Guid Guid { get; set; }
    public string Name { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.MinValue;
    public DateTime LastModified { get; set; } = DateTime.MinValue;
}