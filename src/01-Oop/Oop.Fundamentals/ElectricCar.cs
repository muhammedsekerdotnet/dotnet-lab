namespace Oop.Fundamentals;

public class ElectricCar : Vehicle, IChargeable
{
    public double MaxBatteryCapacity { get; }
    public double MaxChargingPowerWatts { get; }

    public ElectricCar(double maxBatteryCapacity, double maxChargingPowerWatts)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maxBatteryCapacity);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maxChargingPowerWatts);

        MaxBatteryCapacity = maxBatteryCapacity;
        MaxChargingPowerWatts = maxChargingPowerWatts;
    }

    public void Charge()
    {
        Console.WriteLine($"Electric car charging at {MaxChargingPowerWatts} W (battery: {MaxBatteryCapacity} Wh)");
    }

    public override void Move()
    {
        Console.WriteLine("Advances with Rapid Acceleration");
    }
}
