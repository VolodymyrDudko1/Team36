using AnimalShelterFactoryMethod.Domain;

namespace AnimalShelterFactoryMethod.Creators
{
    public sealed class CatIntakeService : AnimalIntakeService
    {
        protected override IAnimal CreateAnimal(IntakeRecord record)
            => new Cat(record.Name, record.AgeYears, record.Notes);
    }
}
