namespace MedinaStation.Domain.Entities;

public class RingGate
{
    public Guid Id { get; set; }
    
    public string SystemName { get; set; } = null!;
    
    public double OverloadMass { get; set; }
}