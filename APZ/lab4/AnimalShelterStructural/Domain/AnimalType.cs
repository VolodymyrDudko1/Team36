namespace AnimalShelterStructural.Domain
{
    /// <summary>
    /// Конкретний Flyweight: описує спільні атрибути виду (Species, Size, Diet, BaseCareCost).
    /// </summary>
    public sealed class AnimalType : IAnimalType
    {
        public AnimalType(string species, string size, decimal baseCareCost, string diet)
        {
            Species = species; Size = size; BaseCareCost = baseCareCost; Diet = diet;
        }

        public string Species { get; }
        public string Size { get; }
        public decimal BaseCareCost { get; }
        public string Diet { get; }

        public void Feed(AnimalContext context)
        {
            Console.WriteLine($"[Feed] {Species}/{Size} '{context.Name}' age={context.AgeYears} ← раціон: {Diet}");
        }

        public decimal EstimateMonthlyCareCost(AnimalContext context)
        {
            // Заглушка: простий коефіцієнт по віку
            var k = context.AgeYears switch { <= 1 => 0.9m, >= 8 => 1.2m, _ => 1.0m };
            var cost = BaseCareCost * k;
            Console.WriteLine($"[Cost] {Species}/{Size} '{context.Name}' → {cost:0.00} UAH (base={BaseCareCost:0.00}, k={k})");
            return cost;
        }
    }
}
