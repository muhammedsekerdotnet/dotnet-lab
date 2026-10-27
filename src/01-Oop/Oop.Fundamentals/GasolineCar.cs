namespace Oop.Fundamentals;

public class GasolineCar : Vehicle, IRefuelable
{
    public double GasCapacity { get; }

    public GasolineCar(double gasCapacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(gasCapacity);

        GasCapacity = gasCapacity;
    }

    public void Refuel()
    {
        Console.WriteLine($"Gasoline car refueling (tank: {GasCapacity} L)");
    }

    public override void Move()
    {
        Console.WriteLine("Accelerates from Slow to Fast");
    }
}
