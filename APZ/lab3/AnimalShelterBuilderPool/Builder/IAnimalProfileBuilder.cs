using AnimalShelterBuilderPool.Domain;


namespace AnimalShelterBuilderPool.Builder
{
/// <summary>
/// Builder: визначає кроки побудови профілю. Дозволяє змінювати порядок/складність.
/// </summary>
public interface IAnimalProfileBuilder
{
void Reset(string name, int ageYears);
void SetKind(AnimalKind kind);
void AddVaccination(string name, DateOnly date);
void SetDiet(string description);
void AddNote(string text);
AnimalProfile Build();
}
}