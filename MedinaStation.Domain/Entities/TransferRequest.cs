using MedinaStation.Domain.Enums;

namespace MedinaStation.Domain.Entities;

public class TransferRequest
{
    public Guid Id { get; set; }
    public Guid ShipId { get; set; }
    public Ship Ship { get; set; } = null!;
    
    public string FromSystem { get; set; } = null!;
    public string ToSystem { get; set; } = null!;

    public DateTime RequestedAt { get; set; }
    public DateTime? ApprovedAt { get; set; }
    public DateTime? ExpireAt { get; set; }

    public TransferStatus Status { get; set; }
    public double RequestedMass { get; set; }
}