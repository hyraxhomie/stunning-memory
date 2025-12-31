using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StunningMemory.Domain.Entities;

namespace StunningMemory.Infrastructure.Data.Configurations;

public class PropertyDefinitionConfigurations : EntityConfiguration<PropertyDefinition>
{
    public override void Configure(EntityTypeBuilder<PropertyDefinition> builder)
    {
        base.Configure(builder);

        builder.ToTable("PropertyDefinitions");
        
        // PD Props
        builder.Property( pd => pd.DisplayOrder)
        .IsRequired();

        builder.Property( pd => pd.IsRequired)
        .IsRequired();

        builder.Property(pd => pd.Configuration)
        .HasColumnType("jsonb");

        // Relationships
        builder.HasOne( pd => pd.DataType)
        .WithMany()
        .HasForeignKey(pd => pd.DataTypeId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne( pd => pd.ReferencedEntityType)
        .WithMany()
        .HasForeignKey( pd => pd.ReferencedEntityTypeId)
        .OnDelete(DeleteBehavior.Restrict);

        // Indexes
        builder.HasIndex( pd => new {pd.EntityTypeId, pd.Name})
        .IsUnique();
    }
}