namespace StunningMemory.Domain.Entities;

public class PropertyDefinition : Entity
{
    public Guid EntityTypeId { get; set; }
    public EntityType EntityType { get; set; }
    public Guid DataTypeId { get; set; }
    public DataType DataType { get; set; }
    public Guid? ReferencedEntityTypeId { get; set; }
    public EntityType? ReferencedEntityType { get; set; }
    public bool IsRequired { get; set; } = false;
    public string? Configuration { get; set; }
    public int DisplayOrder { get; set; }
}
