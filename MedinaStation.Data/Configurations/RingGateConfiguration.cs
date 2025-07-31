using MedinaStation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedinaStation.Data.Configurations;

public class RingGateConfiguration : IEntityTypeConfiguration<RingGate>
{
    public void Configure(EntityTypeBuilder<RingGate> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.SystemName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.OverloadMass).IsRequired();
    }
}