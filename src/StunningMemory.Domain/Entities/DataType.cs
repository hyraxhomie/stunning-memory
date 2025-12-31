namespace StunningMemory.Domain.Entities;

public class DataType
{
    public Guid Guid { get; set; }
    public required string Name { get; set; } = string.Empty;
    public required string SqlType { get; set; } = string.Empty;
    public required string DotNetType { get; set; } = string.Empty;
    public bool RequiresReference { get; set; } = false;
    public string ValidationRules { get; set; } = string.Empty;
    public ICollection<PropertyDefinition> PropertyDefinitions { get; set; } = [];
}