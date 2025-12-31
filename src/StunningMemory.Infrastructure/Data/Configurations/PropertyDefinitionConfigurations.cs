using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore;
using StunningMemory.Domain.Entities;

namespace StunningMemory.Infrastructure.Data.Configuration;

public class PropertyDefinitionConfigurations : IEntityTypeConfiguration<PropertyDefinition>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PropertyDefinition> builder)
    {
        builder.ToTable("PropertyDefinitions");

        builder.HasKey( pd => pd.Guid );
        builder.Property( pd => pd.Name )
        .IsRequired()
        .HasMaxLength(100);

        builder.HasIndex( pd => pd.Name )
        .IsUnique();

        builder.Property( pd => pd.Description )
        .HasMaxLength(500);

        builder.Property( pd => pd.DisplayOrder)
        .IsRequired();

        builder.Property( pd => pd.IsRequired)
        .IsRequired();

        builder.Property(pd => pd.Configuration)
        .HasColumnType("jsonb");

        builder.HasOne( pd => pd.DataType)
        .WithMany()
        .HasForeignKey(pd => pd.DataTypeId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex( pd => new {pd.EntityTypeId, pd.Name})
        .IsUnique();
    }
}