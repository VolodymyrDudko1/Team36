using AnimalShelter.App.Domain;


namespace AnimalShelter.App.Creators
{
/// <summary>
/// Concrete Creator: створює кота.
/// </summary>
public sealed class CatIntakeService : AnimalIntakeService
{
protected override IAnimal CreateAnimal(IntakeRecord record)
=> new Cat(record.Name, record.AgeYears, record.Notes);
}
}