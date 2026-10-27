using Oop.Fundamentals;


var iphone = new Phone(maxBatteryCapacity: 13, maxChargingPowerWatts: 20);
var samsung = new Phone(maxBatteryCapacity: 19, maxChargingPowerWatts: 45);
var tesla = new ElectricCar(maxBatteryCapacity: 75_000, maxChargingPowerWatts: 250_000);
var corolla = new GasolineCar(gasCapacity: 50);

iphone.Charge();
samsung.Charge();
tesla.Charge();
corolla.Refuel();


tesla.Move();
corolla.Move();

try
{
    var broken = new Phone(maxBatteryCapacity: -500, maxChargingPowerWatts: 20);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Rejected: {ex.Message}");
}
