namespace AnimalShelterStructural.Composite
{
    /// <summary>
    /// Composite: груповий вузол (притулок/зона/вольєр), містить інші компоненти.
    /// </summary>
    public sealed class EnclosureGroup : IEnclosureComponent
    {
        private readonly List<IEnclosureComponent> _children = new();

        public EnclosureGroup(string name) { Name = name; }
        public string Name { get; }

        public void Add(IEnclosureComponent c)
        {
            _children.Add(c);
            Console.WriteLine($"[Composite] Add → '{Name}' отримав '{c.Name}'");
        }

        public void Remove(IEnclosureComponent c)
        {
            _children.Remove(c);
            Console.WriteLine($"[Composite] Remove → '{Name}' втратив '{c.Name}'");
        }

        public void Print(int indent)
        {
            Console.WriteLine($"{new string(' ', indent)}+ Group: {Name}");
            foreach (var c in _children) c.Print(indent + 2);
        }

        public void FeedAll()
        {
            Console.WriteLine($"[Composite] FeedAll @ {Name}");
            foreach (var c in _children) c.FeedAll();
        }

        public decimal GetMonthlyCareCost()
        {
            decimal sum = 0m;
            foreach (var c in _children) sum += c.GetMonthlyCareCost();
            Console.WriteLine($"[Composite] Cost @ {Name} = {sum:0.00}");
            return sum;
        }
    }
}
