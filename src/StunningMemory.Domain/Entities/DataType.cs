namespace StunningMemory.Domain.Entities;

public class DataType
{
    Guid id { get; set; }
    string Name { get; set; }
    string BaseStorageType { get; set; }
    bool RequiresReference { get; set; }
    ICollection<PropertyDefinition> PropertyDefinitions { get; set; }
}