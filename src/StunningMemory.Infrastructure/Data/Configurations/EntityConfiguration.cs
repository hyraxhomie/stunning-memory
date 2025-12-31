using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StunningMemory.Domain.Entities;

namespace StunningMemory.Infrastructure.Data.Configurations;

public class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
{
    public virtual void Configure( EntityTypeBuilder<T> builder )
    {
        builder.HasKey( e => e.Guid );

        builder.Property( e => e.Name )
          .IsRequired()
          .HasMaxLength( 100 );

        builder.Property( e => e.DisplayName )
          .IsRequired()
          .HasMaxLength( 100 );

        builder.Property( e => e.Description )
          .HasMaxLength( 500 );

        builder.Property( e => e.CreatedAt )
          .IsRequired();


        builder.Property( e => e.LastModified )
          .IsRequired();
    }
}