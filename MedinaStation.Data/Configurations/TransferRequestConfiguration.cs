using MedinaStation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedinaStation.Data.Configurations;

public class TransferRequestConfiguration : IEntityTypeConfiguration<TransferRequest>
{
    public void Configure(EntityTypeBuilder<TransferRequest> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FromSystem).IsRequired().HasMaxLength(100);
        builder.Property(x => x.ToSystem).IsRequired().HasMaxLength(100);
        builder.Property(x => x.RequestedAt).IsRequired();
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.RequestedMass).IsRequired();
    }
}