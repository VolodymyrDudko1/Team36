namespace AnimalShelter.App.Domain
{
    /// <summary>
    /// Concrete Product: Кіт.
    /// </summary>
    public sealed class Cat : AnimalBase
    {
        public Cat(string name, int ageYears, string notes) : base(name, ageYears, notes) { }
        public override string Species => "Cat";
        public override decimal EstimateMonthlyCareCost() => 900m; // заглушка
    }
}
