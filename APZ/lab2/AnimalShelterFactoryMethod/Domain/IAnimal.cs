namespace AnimalShelterFactoryMethod.Domain
{
    public interface IAnimal
    {
        string Name { get; }
        int AgeYears { get; }
        string Species { get; }
        string Notes { get; }
        void PrintCard();
        decimal EstimateMonthlyCareCost();
    }
}