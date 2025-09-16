namespace AnimalShelterBuilderPool.Domain
{
/// <summary> План харчування. </summary>
public sealed class DietPlan
{
public DietPlan(string description) { Description = description; }
public string Description { get; }
public override string ToString() => Description;
}
}