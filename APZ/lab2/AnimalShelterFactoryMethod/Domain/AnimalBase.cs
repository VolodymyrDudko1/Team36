namespace AnimalShelter.App.Domain
{
/// <summary>
/// Базова реалізація спільних властивостей тварини.
/// </summary>
public abstract class AnimalBase : IAnimal
{
protected AnimalBase(string name, int ageYears, string notes)
{
Name = name;
AgeYears = ageYears;
Notes = notes;
}


public string Name { get; }
public int AgeYears { get; }
public abstract string Species { get; }
public string Notes { get; }


public abstract decimal EstimateMonthlyCareCost();


public virtual void PrintCard()
{
Console.WriteLine($"[{Species}] Ім'я: {Name}; Вік: {AgeYears}; Примітки: {Notes}; Місячна вартість: {EstimateMonthlyCareCost():0.00} UAH");
}
}
}