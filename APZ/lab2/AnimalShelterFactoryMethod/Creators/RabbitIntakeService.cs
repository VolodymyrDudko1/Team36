using AnimalShelter.App.Domain;


namespace AnimalShelter.App.Creators
{
/// <summary>
/// Concrete Creator: створює кролика.
/// </summary>
public sealed class RabbitIntakeService : AnimalIntakeService
{
protected override IAnimal CreateAnimal(IntakeRecord record)
=> new Rabbit(record.Name, record.AgeYears, record.Notes);
}
}