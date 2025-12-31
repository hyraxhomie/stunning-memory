using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StunningMemory.Domain.Entities;

namespace StunningMemory.Infrastructure.Data.Configurations;

public class EntityTypeConfigurations : EntityConfiguration<EntityType>
{
    public override void Configure(EntityTypeBuilder<EntityType> builder)
    {
        base.Configure(builder);
        builder.ToTable("EntityTypes");

        builder.HasIndex( et => et.Name )
        .IsUnique();

        builder.HasMany( et => et.Properties) // ET has many Properties (PD)
        .WithOne(pd => pd.EntityType) // PD has one ET
        .HasForeignKey( pd => pd.EntityTypeId) // The PD FK to ET is EntityTypeId
        .OnDelete(DeleteBehavior.Cascade); // On ET delete, cascade to PD
    }
}