public interface ILifeForm
{
    public string Species { get; set; }
    public string Name { get; set; }
    public string Sound { get; set; }
    public string Image { get; set; }
}

public class Human : ILifeForm
{
    public string Species { get; set; } = "Homo Sapiens";
    public string Name { get; set; } = "Human";
    public string Sound { get; set; } = "I am Chad";
    public string Image { get; set; } = @""

}

public class Dog : ILifeForm
{
    public string Species { get; set; } = "Mammal";
    public string Name { get; set; } = "Dog";
    public string Sound { get; set; } = "DOG DOG DOG DOG DOG";
