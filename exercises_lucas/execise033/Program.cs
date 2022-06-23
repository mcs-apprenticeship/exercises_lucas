public abstract class Vehicle
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int WheelAmount { get; set; }

    public void StartVehicle()
    {
        Console.WriteLine($"{Name} is starting its motor.");
    }

    public void StopVehicle()
    {
        Console.WriteLine($"{Name} is stopping its motor.");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Amount of Wheels: {WheelAmount}");
    }
}

public class MotorCycle : Vehicle
{
    public void DoWheelie()
    {
        Console.WriteLine($"{Name} did a wheelie.");
    }
}

public class Car : Vehicle
{
    public void Drift()
    {
        Console.WriteLine($"{Name} is doing a very cool drift");
    }
}

public class RaceCar : Vehicle
{
    public void Drivefatser()
    {
        Console.WriteLine($"{Name} is driving faster than all the other vehicles");
    }
}

public class SideWagonMotorcycle : Vehicle
{
    public void SeatSecondPerson()
    {
        Console.WriteLine($"A second person sits into the {Name} before it takes off.");
    }
}


