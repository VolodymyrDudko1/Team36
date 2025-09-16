using System.Text;


namespace AnimalShelterBuilderPool.Domain
{
/// <summary>
/// Продукт для Builder: складний профіль тварини з опційними частинами.
/// </summary>
public sealed class AnimalProfile
{
 public string Name { get; set; } = string.Empty;
    public int AgeYears { get; set; }
    public AnimalKind Kind { get; set; }
    public List<Vaccination> Vaccinations { get; set; } = new();
    public DietPlan? Diet { get; set; }
    public List<Note> Notes { get; set; } = new();


public string ToMultilineString()
{
var sb = new StringBuilder();
sb.AppendLine($"Ім'я: {Name}");
sb.AppendLine($"Вид: {Kind}");
sb.AppendLine($"Вік: {AgeYears}");
sb.AppendLine("Щеплення: " + (Vaccinations.Count == 0 ? "—" : string.Join(", ", Vaccinations)));
sb.AppendLine("Раціон: " + (Diet is null ? "—" : Diet));
sb.AppendLine("Примітки: " + (Notes.Count == 0 ? "—" : string.Join("; ", Notes)));
return sb.ToString();
}
}
}