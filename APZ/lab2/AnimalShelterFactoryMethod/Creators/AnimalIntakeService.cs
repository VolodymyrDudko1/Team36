using AnimalShelter.App.Domain;


namespace AnimalShelter.App.Creators
{
/// <summary>
/// Creator (абстрактний творець): оголошує фабричний метод CreateAnimal,
/// а також містить незмінний сценарій прийняття тварини до притулку.
/// </summary>
public abstract class AnimalIntakeService
{
protected abstract IAnimal CreateAnimal(IntakeRecord record);


/// <summary>
/// Шаблонний сценарій: первинний огляд, створення тварини (фабричний метод),
/// призначення вольєра.
/// </summary>
public IAnimal Intake(IntakeRecord record)
{
Console.WriteLine($"[{GetType().Name}] Первинний огляд та реєстрація...");
var animal = CreateAnimal(record); // точка варіації типу продукту


var kennel = AssignKennel(animal);
Console.WriteLine($"[{GetType().Name}] Призначено вольєр: {kennel.Code}");
Console.WriteLine($"[{GetType().Name}] Прийом завершено\n");
return animal;
}


protected virtual Kennel AssignKennel(IAnimal animal)
{
// Заглушка логіки розподілу місць
return new Kennel(code: animal.Species switch
{
"Dog" => "D-12",
"Cat" => "C-07",
_ => "R-01"
});
}
}
}