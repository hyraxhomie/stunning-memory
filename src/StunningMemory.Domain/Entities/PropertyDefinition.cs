namespace StunningMemory.Domain.Entities;

public class PropertyDefinition : BaseObject
{
    Guid ObjectTypeId { get; set; }
    ObjectType ObjectType { get; set; }
    Guid DataTypeId { get; set; }
    DataType DataType { get; set; }
    Guid? ReferencedObjectTypeId { get; set; }
    ObjectType? ReferencedObjectType { get; set; }
    bool IsRequired { get; set; }
    string? Configuration { get; set; }
    int DisplayOrder { get; set; }
}
