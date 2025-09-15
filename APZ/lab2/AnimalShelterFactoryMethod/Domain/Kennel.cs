namespace AnimalShelter.App.Domain
{
/// <summary>
/// Клас предметної області: Вольєр/клітка.
/// </summary>
public sealed class Kennel
{
public Kennel(string code)
{
Code = code;
}
public string Code { get; }
}
}