using AnimalShelter.App.Domain;


namespace AnimalShelter.App.Creators
{
/// <summary>
/// Concrete Creator: створює собаку.
/// </summary>
public sealed class DogIntakeService : AnimalIntakeService
{
protected override IAnimal CreateAnimal(IntakeRecord record)
=> new Dog(record.Name, record.AgeYears, record.Notes);
}
}