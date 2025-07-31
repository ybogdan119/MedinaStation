using MedinaStation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedinaStation.Data.Configurations;

public class ShipConfiguration : IEntityTypeConfiguration<Ship>
{
    public void Configure(EntityTypeBuilder<Ship> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.IdentityUserId).IsRequired();
        builder.Property(x => x.CurrentLocation).IsRequired();
        builder.Property(x => x.Mass).IsRequired();

        builder.HasMany(x => x.TransferRequests)
            .WithOne(x => x.Ship)
            .HasForeignKey(x => x.ShipId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}