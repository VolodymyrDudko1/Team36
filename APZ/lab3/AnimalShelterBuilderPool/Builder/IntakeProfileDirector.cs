using AnimalShelterBuilderPool.Domain;


namespace AnimalShelterBuilderPool.Builder
{
/// <summary>
/// Director: інкапсулює типові сценарії побудови профілю.
/// </summary>
public sealed class IntakeProfileDirector
{
public AnimalProfile BuildBasicIntakeProfile(IAnimalProfileBuilder builder, string name, int ageYears)
{
Console.WriteLine("[Director] BuildBasicIntakeProfile");
builder.Reset(name, ageYears);
builder.SetKind(AnimalKind.Dog); // значення буде змінене конкретним builder'ом при потребі
builder.AddNote("Первинний огляд пройдено");
return builder.Build();
}


public AnimalProfile BuildFullIntakeProfile(IAnimalProfileBuilder builder, string name, int ageYears)
{
Console.WriteLine("[Director] BuildFullIntakeProfile");
builder.Reset(name, ageYears);


// Визначаємо вид за типом будівельника
var kind = builder switch
{
DogProfileBuilder => AnimalKind.Dog,
CatProfileBuilder => AnimalKind.Cat,
RabbitProfileBuilder => AnimalKind.Rabbit,
_ => AnimalKind.Dog
};
builder.SetKind(kind);


builder.AddVaccination("Rabies", DateOnly.FromDateTime(DateTime.Today.AddDays(-30)));
builder.AddVaccination("MultiVax", DateOnly.FromDateTime(DateTime.Today.AddDays(-15)));
builder.SetDiet("Сухий корм + волога підкормка 2 рази/день");
builder.AddNote("Дружній, любить прогулянки");
return builder.Build();
}
}
}