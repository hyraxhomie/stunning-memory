namespace StunningMemory.Domain.Entities;

public class PropertyDefinition : Entity
{
    public required Guid EntityTypeId { get; set; }
    public required EntityType EntityType { get; set; }
    public required Guid DataTypeId { get; set; }
    public required DataType DataType { get; set; }
    public Guid? ReferencedEntityTypeId { get; set; } = null;
    public EntityType? ReferencedEntityType { get; set; } = null;
    public bool IsRequired { get; set; } = false;
    public string? Configuration { get; set; }
    public int DisplayOrder { get; set; }
}
