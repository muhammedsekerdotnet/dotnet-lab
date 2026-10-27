namespace Oop.Fundamentals;

internal interface IChargeable
{
    double MaxBatteryCapacity { get; }
    double MaxChargingPowerWatts { get; }

    void Charge();
}
