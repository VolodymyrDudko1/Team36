using AnimalShelter.App.Creators;
using AnimalShelter.App.Domain;


namespace AnimalShelter.App
{
/// <summary>
/// Демонстрація шаблону "Фабричний метод" на темі "Притулок для тварин".
/// Обираємо конкретного "Творця" (конкретну службу прийому), який створює
/// відповідний тип тварини, не змінюючи загальний сценарій прийому.
/// </summary>
internal class Program
{
private static void Main(string[] args)
{
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Animal Shelter — Factory Method ===\n");


Console.WriteLine("Введіть тип тварини: dog | cat | rabbit");
Console.Write("> ");
var choice = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();


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


var animal = intake.Intake(record); // тут викликається фабричний метод
Console.WriteLine();
animal.PrintCard();


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