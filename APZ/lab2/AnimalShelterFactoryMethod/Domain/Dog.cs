namespace AnimalShelter.App.Domain
{
/// <summary>
/// Concrete Product: Собака.
/// </summary>
public sealed class Dog : AnimalBase
{
public Dog(string name, int ageYears, string notes) : base(name, ageYears, notes) { }
public override string Species => "Dog";
public override decimal EstimateMonthlyCareCost() => 1500m; // заглушка
}
}