using AnimalShelterFactoryMethod.Domain;

namespace AnimalShelterFactoryMethod.Creators
{
    public sealed class DogIntakeService : AnimalIntakeService
    {
        protected override IAnimal CreateAnimal(IntakeRecord record)
            => new Dog(record.Name, record.AgeYears, record.Notes);
    }
}
