namespace StunningMemory.Domain.Entities;

public class DataType
{
    public Guid Guid { get; set; }
    public string Name { get; set; } = string.Empty;
    public string BaseStorageType { get; set; } = string.Empty;
    public bool RequiresReference { get; set; } = false;
    public ICollection<PropertyDefinition> PropertyDefinitions { get; set; } = [];
}