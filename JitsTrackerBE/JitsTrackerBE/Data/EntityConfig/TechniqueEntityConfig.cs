using JitsTrackerBE.Data.Enitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JitsTrackerBE.Data.EntityConfig;

public class TechniqueEntityConfig : IEntityTypeConfiguration<TechniqueEntity>
{
    public void Configure(EntityTypeBuilder<TechniqueEntity> builder)
    {

        builder
            .Property(t => t.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();
        
        builder.Property(t => t.TechniqueName)
            .IsRequired();
        
        builder.HasMany(t => t.Moves)
            .WithOne(m => m.Technique)
            .IsRequired();
    }
    
}