namespace AnimalShelter.App.Domain
{
/// <summary>
/// Product (інтерфейс продукту): спільні операції для всіх тварин, що
/// приймаються у притулок.
/// </summary>
public interface IAnimal
{
string Name { get; }
int AgeYears { get; }
string Species { get; }
string Notes { get; }


/// <summary>
/// Вивести картку тварини (stub-бізнес логіка).
/// </summary>
void PrintCard();


/// <summary>
/// Оцінити щомісячну вартість догляду (stub-логіка).
/// </summary>
decimal EstimateMonthlyCareCost();
}
}