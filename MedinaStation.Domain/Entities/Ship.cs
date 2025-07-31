namespace MedinaStation.Domain.Entities;

public class Ship
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string IdentityUserId { get; set; } = null!;
    public string CurrentLocation { get; set; } = null!;
    public double Mass { get; set; }

    public List<TransferRequest> TransferRequests { get; set; } = new();
}