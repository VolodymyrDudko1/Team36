namespace AnimalShelter.App.Domain
{
/// <summary>
/// Клас предметної області: Заявка/Запис на прийом тварини до притулку.
/// </summary>
public sealed record IntakeRecord(string Name, int AgeYears, string Notes);
}