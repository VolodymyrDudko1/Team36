namespace AnimalShelterFactoryMethod.Domain
{
    public sealed class AdoptionService
    {
        public bool Adopt(IAnimal animal, Adopter adopter)
        {
            Console.WriteLine($"[AdoptionService] Adopt(animal={animal.Species}:{animal.Name}, adopter={adopter.FullName})");
            Console.WriteLine("→ Перевірка документів, підписання договору, оновлення статусу...");
            Console.WriteLine("✔ Успіх: тварину усиновлено!\n");
            return true;
        }
    }
}