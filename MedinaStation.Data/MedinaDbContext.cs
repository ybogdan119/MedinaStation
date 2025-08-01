using MedinaStation.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedinaStation.Data;

public class MedinaDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public MedinaDbContext(DbContextOptions<MedinaDbContext> options) : base(options) { }

    public DbSet<Ship> Ships => Set<Ship>();
    public DbSet<RingGate> Rings => Set<RingGate>();
    public DbSet<TransferRequest> TransferRequests => Set<TransferRequest>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MedinaDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}