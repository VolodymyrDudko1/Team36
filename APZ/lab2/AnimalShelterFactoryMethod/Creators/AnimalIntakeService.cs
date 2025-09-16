using AnimalShelterFactoryMethod.Domain;

namespace AnimalShelterFactoryMethod.Creators
{
    public abstract class AnimalIntakeService
    {
        protected abstract IAnimal CreateAnimal(IntakeRecord record);

        public IAnimal Intake(IntakeRecord record)
        {
            Console.WriteLine($"[{GetType().Name}] Первинний огляд та реєстрація...");
            var animal = CreateAnimal(record); // фабричний метод
            var kennel = AssignKennel(animal);
            Console.WriteLine($"[{GetType().Name}] Призначено вольєр: {kennel.Code}");
            Console.WriteLine($"[{GetType().Name}] Прийом завершено\n");
            return animal;
        }

        protected virtual Kennel AssignKennel(IAnimal animal) =>
            new(animal.Species switch { "Dog" => "D-12", "Cat" => "C-07", _ => "R-01" });
    }
}