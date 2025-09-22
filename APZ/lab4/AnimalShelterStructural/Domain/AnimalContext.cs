namespace AnimalShelterStructural.Domain
{
    /// <summary>
    /// Екзогенний (змінний) стан конкретної тварини: ім'я, вік, нотатки.
    /// </summary>
    public sealed class AnimalContext
    {
        public AnimalContext(string name, int ageYears, string notes)
        {
            Name = name; AgeYears = ageYears; Notes = notes;
        }
        public string Name { get; }
        public int AgeYears { get; }
        public string Notes { get; }
    }
}
