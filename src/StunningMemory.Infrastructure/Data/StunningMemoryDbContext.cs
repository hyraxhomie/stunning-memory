using Microsoft.EntityFrameworkCore;
using StunningMemory.Domain.Entities;
using StunningMemory.Infrastructure.Data.Configurations;

namespace StunningMemory.Infrastructure.Data;

public class StunningMemoryDbContext : DbContext
{
    public StunningMemoryDbContext(DbContextOptions<StunningMemoryDbContext> options) : base(options){}
    public DbSet<EntityType> EntityTypes { get; set; }
    public DbSet<DataType> DataTypes { get; set; }
    public DbSet<PropertyDefinition> PropertyDefinitions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            foreach(var prop in entityType.GetProperties())
            {
                if(prop.ClrType == typeof(DateTime))
                {
                    prop.SetColumnType("timestamptz");
                }
            }
        }
        modelBuilder.ApplyConfiguration(new EntityTypeConfigurations());
        modelBuilder.ApplyConfiguration(new DataTypeConfigurations());
        modelBuilder.ApplyConfiguration(new PropertyDefinitionConfigurations());
    }
}
