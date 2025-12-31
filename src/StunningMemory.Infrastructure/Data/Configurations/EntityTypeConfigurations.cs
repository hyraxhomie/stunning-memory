using Microsoft.EntityFrameworkCore;
using StunningMemory.Domain.Entities;

namespace StunningMemory.Infrastructure.Data.Configuration;

public class EntityTypeConfigurations : IEntityTypeConfiguration<EntityType>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<EntityType> builder)
    {
        builder.ToTable("EntityTypes");

        builder.HasKey( et => et.Guid );
        builder.Property( et => et.Name )
        .IsRequired()
        .HasMaxLength(100);

        builder.HasIndex( et => et.Name )
        .IsUnique();

        builder.Property( et => et.Description )
        .HasMaxLength(500);

        builder.HasMany( et => et.Properties)
        .WithOne(pd => pd.EntityType)
        .HasForeignKey( pd => pd.EntityTypeId)
        .OnDelete(DeleteBehavior.Cascade);
    }
}