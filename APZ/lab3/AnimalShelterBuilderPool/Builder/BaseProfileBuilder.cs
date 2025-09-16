using AnimalShelterBuilderPool.Domain;


namespace AnimalShelterBuilderPool.Builder
{
/// <summary>
/// Базова реалізація будівельника: зберігає поточний стан продукту та надає типові операції.
/// </summary>
public abstract class BaseProfileBuilder : IAnimalProfileBuilder
{
protected AnimalProfile Profile = new();


public void Reset(string name, int ageYears)
{
Profile = new AnimalProfile { Name = name, AgeYears = ageYears };
Console.WriteLine($"[Builder] Reset(name={name}, ageYears={ageYears})");
}


public void SetKind(AnimalKind kind)
{
    Profile.Kind = kind;
    Console.WriteLine($"[Builder] SetKind({kind})");
}

public void AddVaccination(string name, DateOnly date)
{
Profile.Vaccinations.Add(new Vaccination(name, date));
Console.WriteLine($"[Builder] AddVaccination(name={name}, date={date:yyyy-MM-dd})");
}


public void SetDiet(string description)
{
    Profile.Diet = new DietPlan(description);
    Console.WriteLine($"[Builder] SetDiet({description})");
}


public void AddNote(string text)
{
Profile.Notes.Add(new Note(text));
Console.WriteLine($"[Builder] AddNote({text})");
}


public AnimalProfile Build()
{
Console.WriteLine("[Builder] Build() → готовий профіль");
return Profile;
}
}
}