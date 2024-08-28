using System.ComponentModel.DataAnnotations;

namespace ObjectGraphDataAnnotationsValidator_ServiceProvider.Components.Sample;

public class Animal : IValidatableObject
{
    public string Name { get; set; }

    [Required] [ValidateComplexType] public List<Friend> Friends { get; set; } = [];

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        Console.Out.WriteLine("====> Validate Animal");

        return new List<ValidationResult>();
    }
}

public class Friend : IValidatableObject
{
    [Required] public string Name { get; set; }
    
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        Console.Out.WriteLine("====> Validate Complex Friend");

        var animalService = validationContext.GetRequiredService<IAnimalService>();
        animalService.MakeSound();

        return new List<ValidationResult>();
    }
}