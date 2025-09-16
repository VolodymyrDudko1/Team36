using AnimalShelterFactoryMethod.Domain;

namespace AnimalShelterFactoryMethod.Creators
{
    public sealed class RabbitIntakeService : AnimalIntakeService
    {
        protected override IAnimal CreateAnimal(IntakeRecord record)
            => new Rabbit(record.Name, record.AgeYears, record.Notes);
    }
}
