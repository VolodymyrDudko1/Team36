namespace AnimalShelterFactoryMethod.Domain
{
    public sealed class Kennel
    {
        public Kennel(string code) { Code = code; }
        public string Code { get; }
    }
}
