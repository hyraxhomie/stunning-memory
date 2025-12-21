namespace StunningMemory.Domain.Entities;

public class ObjectType : BaseObject
{
    ICollection<PropertyDefinition> PropertyDefinitions { get; set; } = [];
}
