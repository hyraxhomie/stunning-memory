using Microsoft.EntityFrameworkCore;
using StunningMemory.Domain.Entities;
using StunningMemory.Infrastructure.Data.Configuration;

namespace StunningMemory.Infrastructure.Data;

public class StunningMemoryDbContext : DbContext
{
    public StunningMemoryDbContext(DbContextOptions<StunningMemoryDbContext> options) : base(options)
    {   
    } 
    public DbSet<EntityType> EntityTypes { get; set; }
    public DbSet<DataType> DataTypes { get; set; }
    public DbSet<PropertyDefinition> PropertyDefinitions { get; set; }
    public string DbPath { get; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new EntityTypeConfigurations());
        modelBuilder.ApplyConfiguration(new DataTypeConfigurations());
        modelBuilder.ApplyConfiguration(new PropertyDefinitionConfigurations());
    }
}
