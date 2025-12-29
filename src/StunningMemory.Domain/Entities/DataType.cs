namespace StunningMemory.Domain.Entities;

public class DataType
{
    public Guid Guid { get; set; }
    public required string Name { get; set; } = string.Empty;
    public required string BaseStorageType { get; set; } = string.Empty;
    public bool RequiresReference { get; set; } = false;
    public ICollection<PropertyDefinition> PropertyDefinitions { get; set; } = [];
}