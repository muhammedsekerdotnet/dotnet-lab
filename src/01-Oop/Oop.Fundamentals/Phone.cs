namespace Oop.Fundamentals;

public class Phone : IChargeable
{
    public double MaxBatteryCapacity { get; }
    public double MaxChargingPowerWatts { get; }

    public Phone(double maxBatteryCapacity, double maxChargingPowerWatts)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maxBatteryCapacity);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maxChargingPowerWatts);

        MaxBatteryCapacity = maxBatteryCapacity;
        MaxChargingPowerWatts = maxChargingPowerWatts;
    }

    public void Charge()
    {
        Console.WriteLine($"Phone charging at {MaxChargingPowerWatts} W (battery: {MaxBatteryCapacity} Wh)");
    }
}
