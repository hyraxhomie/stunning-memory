using Microsoft.EntityFrameworkCore;
using StunningMemory.Domain.Entities;

namespace StunningMemory.Infrastructure.Data.Configuration;

public class DataTypeConfigurations : IEntityTypeConfiguration<DataType>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DataType> builder)
    {
        builder.ToTable("DataTypes");

        builder.HasKey( dt => dt.Guid );

        builder.Property( dt => dt.Name )
        .IsRequired()
        .HasMaxLength(50);

        builder.HasIndex( dt => dt.Name )
        .IsUnique();

        builder.Property( dt => dt.SqlType )
        .IsRequired()
        .HasMaxLength(50);

        builder.Property( dt => dt.DotNetType )
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(dt => dt.ValidationRules)
        .HasColumnType("jsonb");
    }
}