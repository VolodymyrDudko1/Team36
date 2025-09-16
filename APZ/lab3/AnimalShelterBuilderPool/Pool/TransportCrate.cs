namespace AnimalShelterBuilderPool.Pool
{
/// <summary>
/// Пулюваний ресурс: транспортна клітка.
/// </summary>
public sealed class TransportCrate
{
public string Label { get; set; } = string.Empty;
public string? OccupantName { get; private set; }
public string? OccupantKind { get; private set; }


public void Load(string animalName, AnimalShelterBuilderPool.Domain.AnimalKind kind)
{
OccupantName = animalName;
OccupantKind = kind.ToString();
Console.WriteLine($"[Crate] Load(name={animalName}, kind={kind})");
}


public void Unload()
{
Console.WriteLine($"[Crate] Unload(name={OccupantName}, kind={OccupantKind})");
OccupantName = null; OccupantKind = null;
}


public void Reset()
{
Console.WriteLine($"[Crate] Reset(Label={Label})");
Label = string.Empty; OccupantName = null; OccupantKind = null;
}


public override string ToString() => $"Crate[{Label}] for {OccupantName ?? "—"} ({OccupantKind ?? "—"})";
}
}