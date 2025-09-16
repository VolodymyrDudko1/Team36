namespace AnimalShelterFactoryMethod.Domain
{
    public sealed class Cat : AnimalBase
    {
        public Cat(string name, int ageYears, string notes) : base(name, ageYears, notes) { }
        public override string Species => "Cat";
        public override decimal EstimateMonthlyCareCost() => 900m;
    }
}
