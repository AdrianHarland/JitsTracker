using JitsTrackerBE.Data.Enitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JitsTrackerBE.Data.EntityConfig;

public class MoveEntityConfig : IEntityTypeConfiguration<MoveEntity>
{
    public void Configure(EntityTypeBuilder<MoveEntity> builder)
    {
        builder
            .Property(m => m.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder
            .HasOne(m => m.TechniqueId)
            .WithMany(t => t.Moves)
            .HasForeignKey(m => m.TechniqueId)
            .IsRequired();
        
        builder
            .Property(m => m.MoveName)
            .IsRequired();
    }
    
}