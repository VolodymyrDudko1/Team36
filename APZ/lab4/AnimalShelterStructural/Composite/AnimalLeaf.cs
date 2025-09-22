using AnimalShelterStructural.Domain;

namespace AnimalShelterStructural.Composite
{
    /// <summary>
    /// Leaf: конкретна тварина. Має екзогенний контекст + посилання на Flyweight тип.
    /// </summary>
    public sealed class AnimalLeaf : IEnclosureComponent
    {
        public AnimalLeaf(AnimalContext context, IAnimalType type)
        {
            Context = context; Type = type;
        }

        public string Name => Context.Name;
        public AnimalContext Context { get; }
        public IAnimalType Type { get; }

        public void Print(int indent)
        {
            Console.WriteLine($"{new string(' ', indent)}- Animal: {Type.Species}/{Type.Size} '{Context.Name}' ({Context.AgeYears}y)");
        }

        public void FeedAll() => Type.Feed(Context);

        public decimal GetMonthlyCareCost() => Type.EstimateMonthlyCareCost(Context);
    }
}
