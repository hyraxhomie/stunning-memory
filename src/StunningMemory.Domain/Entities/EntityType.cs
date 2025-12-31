namespace StunningMemory.Domain.Entities;

public class EntityType : Entity
{
    public ICollection<PropertyDefinition> Properties { get; set; } = [];
}
