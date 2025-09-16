using AnimalShelterFactoryMethod.Creators;
using AnimalShelterFactoryMethod.Domain;
using AnimalShelterFactoryMethod.Care;

namespace AnimalShelterFactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Animal Shelter — Factory Method + Abstract Factory ===\n");

            Console.WriteLine("Введіть тип тварини: dog | cat | rabbit");
            Console.Write("> ");
            var choice = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

            // Factory Method: обираємо конкретного творця
            AnimalIntakeService intake = choice switch
            {
                "dog" => new DogIntakeService(),
                "cat" => new CatIntakeService(),
                "rabbit" => new RabbitIntakeService(),
                _ => new DogIntakeService()
            };

            var record = new IntakeRecord(
                Name: "Lucky",
                AgeYears: 2,
                Notes: "Знайдена біля парку, дружня"
            );

            var animal = intake.Intake(record); // тут спрацьовує фабричний метод
            Console.WriteLine();
            animal.PrintCard();

            // Abstract Factory: сімейство продуктів догляду під вид тварини
            IAnimalCareFactory careFactory = animal.Species switch
            {
                "Dog" => new DogCareFactory(),
                "Cat" => new CatCareFactory(),
                "Rabbit" => new RabbitCareFactory(),
                _ => new DogCareFactory()
            };

            var food = careFactory.CreateFood();
            var bed  = careFactory.CreateBed();
            var toy  = careFactory.CreateToy();

            Console.WriteLine("\nРекомендований набір догляду (Abstract Factory):");
            Console.WriteLine($"- Їжа:  {food.Describe()} — {food.Price:0.00} UAH/міс");
            Console.WriteLine($"- Лігво: {bed.Describe()} — {bed.Price:0.00} UAH (разово)");
            Console.WriteLine($"- Іграшка: {toy.Describe()} — {toy.Price:0.00} UAH (разово)");

            Console.WriteLine();
            Console.WriteLine("Імітація усиновлення: введіть ім'я усиновителя:");
            Console.Write("> ");
            var adopterName = Console.ReadLine() ?? "Anon";
            var adopter = new Adopter(adopterName, phone: "+380000000000");

            var adoptionService = new AdoptionService();
            adoptionService.Adopt(animal, adopter);
        }
    }
}
