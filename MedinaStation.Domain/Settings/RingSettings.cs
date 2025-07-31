namespace MedinaStation.Domain.Settings;

public class RingSettings
{
    public double MaxMassThreshold { get; set; }
    public double SafetyPercentage { get; set; }
    public double DecayStep { get; set; }

    public double SafetyLimit => MaxMassThreshold * SafetyPercentage;
}