namespace AnimalShelter.App.Domain
{
/// <summary>
/// Concrete Product: Кролик.
/// </summary>
public sealed class Rabbit : AnimalBase
{
public Rabbit(string name, int ageYears, string notes) : base(name, ageYears, notes) { }
public override string Species => "Rabbit";
public override decimal EstimateMonthlyCareCost() => 600m; // заглушка
}
}