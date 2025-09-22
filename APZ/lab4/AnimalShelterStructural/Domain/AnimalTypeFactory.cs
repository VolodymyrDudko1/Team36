using System.Collections.Concurrent;

namespace AnimalShelterStructural.Domain
{
    /// <summary>
    /// Фабрика Flyweight: повертає спільні об'єкти типів тварин із кеша.
    /// Ключ = Species|Size.
    /// </summary>
    public sealed class AnimalTypeFactory
    {
        private readonly ConcurrentDictionary<string, IAnimalType> _cache = new();

        public IAnimalType Get(string species, string size, decimal baseCare, string diet)
        {
            string key = $"{species}|{size}";
            return _cache.GetOrAdd(key, _ =>
            {
                Console.WriteLine($"[FlyweightFactory] Create type: {species}/{size} (base={baseCare}, diet='{diet}')");
                return new AnimalType(species, size, baseCare, diet);
            });
        }

        public string DumpStats()
            => $"У кеші типів: {_cache.Count} → {string.Join(", ", _cache.Keys)}";
    }
}
