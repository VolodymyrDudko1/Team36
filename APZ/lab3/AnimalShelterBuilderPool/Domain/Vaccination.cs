namespace AnimalShelterBuilderPool.Domain
{
/// <summary> Щеплення тварини. </summary>
public sealed class Vaccination
{
public Vaccination(string name, DateOnly date)
{ Name = name; Date = date; }
public string Name { get; }
public DateOnly Date { get; }
public override string ToString() => $"{Name} ({Date:yyyy-MM-dd})";
}
}