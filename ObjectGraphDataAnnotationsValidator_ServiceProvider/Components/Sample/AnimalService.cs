namespace ObjectGraphDataAnnotationsValidator_ServiceProvider.Components.Sample;

public interface IAnimalService
{
    public void MakeSound();
}

public class AnimalService : IAnimalService
{
    public void MakeSound()
    {
        Console.Out.WriteLine("WUFF");
    }
}